using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using Bsdl.FreshTrade.Repositories.Basic.DBModel;

namespace Bsdl.FreshTrade.Repositories.Basic.Persistance
{
    /// <summary>
    /// Entity property definition.
    /// Contains information about property and mapped DB table column.
    /// </summary>
    public class EntityPropDef
    {
        public readonly string PropName;
        public readonly string ColumnName;
        public readonly string ColumnQuoted;
        public string ColumnAsProp { get { return ColumnQuoted + " as \"" + PropName + "\""; } }
        public readonly bool IsKey;
        public readonly PropertyInfo PropInfo;
        public readonly PropertyInfo KeyPropInfo; // property into for corresponding property from combined TKey
        public readonly Func<IBaseModel, IBaseModel, bool> CompareValues;
        public readonly Func<IBaseModel, object> GetValue;
        public readonly Func<IList<IBaseModel>, object> GetValues;
        public readonly bool IsNullable;
        public readonly bool IsDbCalc;
        public readonly bool IsRefProp;
        public readonly string RefEntityName;
        public readonly int Size;
        public readonly int? Precision;
        public readonly int? Scale;


        public EntityPropDef(PropertyInfo prop, string columnName, bool isKey, bool isNullable, string refEntityName, PropertyInfo keyPropInfo,
            int size, int? prec, int? scale, Type targetType)
        {
            PropName = prop.Name;
            ColumnName = columnName;
            ColumnQuoted = "\"" + ColumnName + "\"";
            IsKey = isKey;
            IsNullable = isNullable;
            IsRefProp = !string.IsNullOrEmpty(refEntityName);
            RefEntityName = refEntityName;
            PropInfo = prop;
            KeyPropInfo = keyPropInfo;
            IsDbCalc = false;
            CompareValues = ComparePropValues();
            Size = size;
            Precision = prec;
            Scale = scale;
            GetValue = GetPropValue(targetType);
            GetValues = GetPropValues(targetType);

        }


        private Func<IBaseModel, IBaseModel, bool> ComparePropValues()
        {
            return null;
        }



        private Func<IBaseModel, object> GetPropValue(Type targetType)
        {
            var pEntity = Expression.Parameter(typeof(IBaseModel), "pEntity");
            var vEntity = Expression.Variable(targetType, "vEntity");
            Expression body = Expression.Block(typeof(object),
                new[] { vEntity },
                new Expression[]
                {
                    Expression.Assign(vEntity, Expression.Convert(pEntity, targetType)),
                    Expression.Convert(Expression.Property(vEntity, PropInfo), typeof(object))
                });

            var compare = Expression.Lambda<Func<IBaseModel, object>>(body, pEntity);
            return compare.Compile();

        }

        private Func<IList<IBaseModel>, object> GetPropValues(Type targetType)
        {
            var pEntities = Expression.Parameter(typeof(IList<IBaseModel>), "pEntities");
            var vEntity = Expression.Variable(targetType, "vEntity");
            var vIdx = Expression.Variable(typeof(int), "vIdx");
            var vCount = Expression.Variable(typeof(int), "vCount");
            var vResult = Expression.Variable(PropInfo.PropertyType.MakeArrayType(), "vResult");
            var label = Expression.Label(vResult.Type, "loopEnd");

            BlockExpression body = Expression.Block(
                new[] { vIdx, vCount, vEntity, vResult },
                Expression.Assign(vIdx, Expression.Constant(0)),
                Expression.Assign(vCount, Expression.Property(pEntities, typeof(ICollection<IBaseModel>).GetProperty("Count"))),
                Expression.Assign(vResult, Expression.NewArrayBounds(PropInfo.PropertyType, vCount)),
                Expression.Loop(
                    Expression.IfThenElse(
                        Expression.LessThan(vIdx, vCount),
                        Expression.Block(
                            Expression.Assign(vEntity,
                                Expression.Convert(
                                    Expression.MakeIndex(pEntities, typeof(IList<IBaseModel>).GetProperty("Item"), new[] { vIdx }),
                                    vEntity.Type
                                )
                            ),
                            Expression.Assign(Expression.ArrayAccess(vResult, Expression.PostIncrementAssign(vIdx)), Expression.Property(vEntity, PropInfo))
                        ),
                        Expression.Break(label, vResult)
                    ),
                    label
                ),
                Expression.Convert(vResult, typeof(object))
            );
            var compare = Expression.Lambda<Func<IList<IBaseModel>, object>>(body, pEntities);
            return compare.Compile();
        }


        public decimal Round(decimal val)
        {
            return Scale != null ? Math.Round(val, Scale.Value) : val;
        }

        public decimal? Round(decimal? val)
        {
            return Scale != null && val != null ? Math.Round(val.Value, Scale.Value) : val;
        }
    }
}
