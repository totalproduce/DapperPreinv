using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace Bsdl.FreshTrade.Repositories.PreInv.Audit
{
    public class DelAudToDoRecordRepository : DapperRepositoryBase<DTODelAudToDo>, IDelAudToDoRecordRepository
    {
        private const string _sqlQuery = @"SELECT * FROM DELAUDTODO";

        public DelAudToDoRecordRepository(IUnitOfWork unitOfWorkCurrent, ICacheManagerFactory cacheManagerFactory)
            : base
                (
                unitOfWorkCurrent,
                cacheManagerFactory,
                new List<ISearchFieldDef>
                    {
                    }
                )
        {
        }

        public override IList<EntityPropDef> GetTableFieldsDefs()
        {
            return DelAudToDo.GetPropDefs();
        }

        public override string GetTableName()
        {
            return "DELAUDTODO";
        }

        public override IBaseModel ToDbModel(DTODelAudToDo item)
        {
            var result =
                new DelAudToDo
                    {
                        Dalrecno = item.DelAuditID,
                        Dalupdind = item.UpdateIndicator ? 1 : 0
                    };
            return result;
        }


        protected override List<DTODelAudToDo> GetDataInternal(List<ISearchField> searchFields,
                                                               CachingStrategy allowFromCache, uint? topRows)
        {
            string query = ConstructSimpleQuery(_sqlQuery, searchFields, true, topRows);

            IEnumerable<DelAudToDo> results = null;

            try
            {
                results = UnitOfWorkCurrent.Query<DelAudToDo>(query);
            }
            catch (Exception ex)
            {
                throw new DatabaseQueryException("Could not load DELAUDTODO" + Environment.NewLine + ex.Message, ex);
            }

            return results
                .Select(item =>
                        new DTODelAudToDo
                            {
                                DelAuditID = item.Dalrecno,
                                UpdateIndicator = item.Dalupdind.GetValueOrDefault() == 1
                            })
                .ToList();
        }
    }
}
