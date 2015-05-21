using System;
using System.Collections.Generic;
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
    public class AccAllValRepository : DapperRepositoryBase<DTOAccAllVal>, IAccAllValRepository
    {
        private const string _sqlQuery = @"SELECT * FROM ACCALLOC";

        public AccAllValRepository(IUnitOfWork unitOfWorkCurrent, ICacheManagerFactory cacheManagerFactory)
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
            return AccAllVal.GetPropDefs();
        }

        public override string GetTableName()
        {
            return "ACCALLVAL";
        }

        public override IBaseModel ToDbModel(DTOAccAllVal item)
        {
            var result = new AccAllVal();
            result.Aavrecno = item.AavRecNo;
            result.Aavamount = item.AavAmount;
            result.Aavbaseamount = item.AavBaseAmount;
            result.Aavcurrecno = item.AavCurRecNo;
            result.Aaveuroamount = item.AavEuroAmount;
            return result;
        }

        protected override List<DTOAccAllVal> GetDataInternal(List<ISearchField> searchFields, CachingStrategy allowFromCache, uint? topRows)
        {
            string query = ConstructSimpleQuery(_sqlQuery, searchFields, true, topRows);

            var data = new List<DTOAccAllVal>();

            IEnumerable<AccAllVal> results = null;

            try
            {
                results = UnitOfWorkCurrent.Query<AccAllVal>(query);
            }
            catch (Exception ex)
            {
                throw new DatabaseQueryException("Could not load ACCALLVAL" + Environment.NewLine + ex.Message, ex);
            }

            if (results != null)
            {
                foreach (var item in results)
                {
                    data.Add
                        (
                            new DTOAccAllVal
                            {
                                AavRecNo = item.Aavrecno,
                                AavAmount = item.Aavamount ?? 0,
                                AavBaseAmount = item.Aavbaseamount ?? 0,
                                AavCurRecNo = item.Aavcurrecno,
                                AavEuroAmount = item.Aaveuroamount ?? 0
                            }
                        );
                }
            }

            return data;
        }

        protected override long ReserveSequenceRangeInternal(int? keyNumber = 1)
        {
            return UnitOfWorkCurrent.GetNextIdentity("LstAavRecNo", keyNumber ?? 1);
        }
    }

}
