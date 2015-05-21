using System;
using System.Collections.Generic;
using Bsdl.FreshTrade.Domain.Basic.Enums;
using Bsdl.FreshTrade.Domain.Basic.Exceptions.DataAccess;
using Bsdl.FreshTrade.Domain.Basic.Interfaces;
using Bsdl.FreshTrade.Domain.PreInv.Entities;
using Bsdl.FreshTrade.Repositories.Basic;
using Bsdl.FreshTrade.Repositories.Basic.DBModel;
using Bsdl.FreshTrade.Repositories.Basic.Interfaces;
using Bsdl.FreshTrade.Repositories.Basic.Persistance;
using Bsdl.FreshTrade.Repositories.Basic.Utilities.Interfaces;
using Bsdl.FreshTrade.Repositories.PreInv.DBModel;
using Bsdl.FreshTrade.Repositories.PreInv.Interfaces;

namespace Bsdl.FreshTrade.Repositories.PreInv.DestinationRep
{

    public class IchDiscTypRepository : DapperRepositoryBase<DTOIchDiscTyp>, IIchDiscTypRepository
    {
        private const string _sqlQuery = @"SELECT * FROM ICHDISCTYP";

        public IchDiscTypRepository(IUnitOfWork unitOfWorkCurrent, ICacheManagerFactory cacheManagerFactory)
            : base
            (
                unitOfWorkCurrent,
                cacheManagerFactory,
                new List<ISearchFieldDef>
                {
                    new SearchFieldDef<DTOIchDiscTyp, int>(i => i.IchRecNo, IchDiscTyp.FieldNames.ICHRECNO, FieldType.Integer)
                }
            )
        {
        }


        public override IList<EntityPropDef> GetTableFieldsDefs()
        {
            return IchDiscTyp.GetPropDefs();
        }

        public override string GetTableName()
        {
            return "ICHDISCTYP";
        }

        public override IBaseModel ToDbModel(DTOIchDiscTyp item)
        {
            var result = new IchDiscTyp();
            result.Ichrecno = item.IchRecNo;
            result.Discdedstr = item.DiscDedStr;
            result.Discgrpglrecno = item.DiscGrpGlRecNo;
            return result;
        }

        protected override List<DTOIchDiscTyp> GetDataInternal(List<ISearchField> searchFields, CachingStrategy allowFromCache, uint? topRows)
        {
            string query = ConstructSimpleQuery(_sqlQuery, searchFields, true, topRows);

            var data = new List<DTOIchDiscTyp>();

            IEnumerable<IchDiscTyp> results = null;

            try
            {
                results = UnitOfWorkCurrent.Query<IchDiscTyp>(query);
            }
            catch (Exception ex)
            {
                throw new DatabaseQueryException("Could not load ICHDISCTYP" + Environment.NewLine + ex.Message, ex);
            }

            if (results != null)
            {
                foreach (var item in results)
                {
                    data.Add
                        (
                            new DTOIchDiscTyp
                            {
                                IchRecNo = item.Ichrecno,
                                DiscDedStr = item.Discdedstr,
                                DiscGrpGlRecNo = item.Discgrpglrecno,
                            }
                        );
                }
            }

            return data;
        }

        public List<DTOIchDiscTyp> GetByItemChargeIds(List<int> itemChargeIds)
        {
            return GetDataInChunks(i => i.IchRecNo, itemChargeIds);
        }

    }

}
