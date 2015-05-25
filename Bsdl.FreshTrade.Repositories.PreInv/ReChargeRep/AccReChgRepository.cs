using System;
using System.Collections.Generic;
using System.Linq;
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

namespace Bsdl.FreshTrade.Repositories.PreInv.ReChargeRep
{
    public class AccReChgRepository : DapperRepositoryBase<DTOAccReChg>, IAccReChgRepository
    {
        private const string _sqlQuery = @"SELECT * FROM ACCRECHG";

        public AccReChgRepository(IUnitOfWork unitOfWorkCurrent, ICacheManagerFactory cacheManagerFactory)
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
            return AccReChg.GetPropDefs();
        }

        public override string GetTableName()
        {
            return "ACCRECHG";
        }

        public override IBaseModel ToDbModel(DTOAccReChg item)
        {
            var result = new AccReChg();
            result.Rechgrecno = item.ReChgRecNo;
            result.Batrecno = item.BatRecNo;
            result.Fromsaloffno = item.FromSalOffNo;
            result.Origatrrecno = item.OrigAtrRecNo;
            result.Repackatrrecno = item.Repackatrrecno;
            result.Tosaloffno = item.ToSalOffNo;
            result.Trnshpatrrecno = item.Trnshpatrrecno; 
            return result;
        }


        protected override List<DTOAccReChg> GetDataInternal(List<ISearchField> searchFields, CachingStrategy allowFromCache, uint? topRows)
        {
            string query = ConstructSimpleQuery(_sqlQuery, searchFields, true, topRows);

            IEnumerable<AccReChg> results = null;

            try
            {
                results = UnitOfWorkCurrent.Query<AccReChg>(query);
            }
            catch (Exception ex)
            {
                throw new DatabaseQueryException("Could not load AccReChg" + Environment.NewLine + ex.Message, ex);
            }

            return results
                .Select(item =>
                    new DTOAccReChg
                        {
                            ReChgRecNo = item.Rechgrecno,
                            BatRecNo = item.Batrecno,
                            FromSalOffNo = item.Fromsaloffno,
                            OrigAtrRecNo = item.Origatrrecno,
                            Repackatrrecno = item.Repackatrrecno,
                            ToSalOffNo = item.Tosaloffno,
                            Trnshpatrrecno = item.Trnshpatrrecno,
                        })
                .ToList();
        }

        protected override long ReserveSequenceRangeInternal(int? keyNumber = 1)
        {
            return UnitOfWorkCurrent.GetNextIdentity("LstReChgRecNo", keyNumber ?? 1);
        }

    }
}

