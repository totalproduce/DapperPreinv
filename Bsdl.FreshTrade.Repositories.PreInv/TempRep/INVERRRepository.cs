using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bsdl.FreshTrade.Domain.Basic.Exceptions;
using Bsdl.FreshTrade.Domain.Basic.Exceptions.DataAccess;
using Bsdl.FreshTrade.Domain.Basic.Interfaces;
using Bsdl.FreshTrade.Domain.Basic.Utilities.DataTypeHandling;
using Bsdl.FreshTrade.Domain.PreInv.Entities;
using Bsdl.FreshTrade.Domain.PreInv.Enums;
using Bsdl.FreshTrade.Repositories.Basic;
using Bsdl.FreshTrade.Repositories.Basic.DBModel;
using Bsdl.FreshTrade.Repositories.Basic.Interfaces;
using Bsdl.FreshTrade.Repositories.Basic.Persistance;
using Bsdl.FreshTrade.Repositories.Basic.Utilities.Interfaces;
using Bsdl.FreshTrade.Repositories.PreInv.DBModel;
using Bsdl.FreshTrade.Repositories.PreInv.Interfaces;

namespace Bsdl.FreshTrade.Repositories.PreInv.TempRep
{
    public class InvErrRepository : DapperRepositoryBase<DTOPreInvExtractionErrorsItem>, IInvErrRepository
    {
        private const string _sqlQuery = @"SELECT * FROM PREINVTEMP_INVERR";
        private const string _preInvSquence_InvErr_RecNo = "PREINVTEMP_InvErr_RecNo";

        private const string _sqlDeleteQuery = @"DELETE FROM PREINVTEMP_INVERR WHERE EXTRACTSESSIONID = {0}";


        public InvErrRepository(IUnitOfWork unitOfWorkCurrent, ICacheManagerFactory cacheManagerFactory)
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
            return INVERR.GetPropDefs();
        }

        public override string GetTableName()
        {
            return "PREINVTEMP_INVERR";
        }

        public override void Add(ICollection<DTOPreInvExtractionErrorsItem> entities)
        {
            var ids = UnitOfWorkCurrent.GenNextSequenceIDs(_preInvSquence_InvErr_RecNo, entities.Count).ToList();
            int i = 0;
            foreach (var item in entities)
            {
                item.Id = (int)ids[i];
                i++;
            }
            base.Add(entities);
        }

        public override IBaseModel ToDbModel(DTOPreInvExtractionErrorsItem item)
        {
            if (!item.Id.HasValue)
            {
                throw new FreshTradeException("Error log has empty Id");
            }
            return new INVERR
                             {
                                 Extractsessionid = item.ExtractSessionID,
                                 Logrecno = item.Id.Value,
                                 Errno = (int) item.Type,
                                 Ordcstcode = item.CustomerCode,
                                 Ordcustordno = item.OrderNo,
                                 Dlvordno = item.DeliveryNo
                             };
        }

        protected override List<DTOPreInvExtractionErrorsItem> GetDataInternal(List<ISearchField> searchFields, CachingStrategy allowFromCache, uint? topRows)
        {
            string query = ConstructSimpleQuery(_sqlQuery, searchFields, true, topRows);

            var data = new List<DTOPreInvExtractionErrorsItem>();

            IEnumerable<INVERR> results = null;

            try
            {
                results = UnitOfWorkCurrent.Query<INVERR>(query);
            }
            catch (Exception ex)
            {
                throw new DatabaseQueryException("Could not load PREINVTEMP_INVERR" + Environment.NewLine + ex.Message, ex);
            }

            if (results != null)
            {
                foreach (var item in results)
                {
                    data.Add
                        (
                            new DTOPreInvExtractionErrorsItem
                            {
                                ExtractSessionID = item.Extractsessionid,
                                Id = item.Logrecno,
                                Type = Enums<PreInvExtractionErrorTypes>.GetValue(item.Errno),
                                CustomerCode = item.Ordcstcode,
                                OrderNo = item.Ordcustordno,
                                DeliveryNo = item.Dlvordno,
                            }
                        );
                }
            }

            return data;
        }

        public void DeleteByExtractSessionID(int extractSessionID)
        {
            string sqlQuery = string.Format(_sqlDeleteQuery, extractSessionID);
            UnitOfWorkCurrent.Execute(sqlQuery);
        }

    }
}
