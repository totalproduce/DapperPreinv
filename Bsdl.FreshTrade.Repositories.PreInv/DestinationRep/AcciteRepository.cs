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
    public class AcciteRepository : DapperRepositoryBase<DTOAccite>, IAcciteRepository
    {
        private const string _sqlQuery = @"SELECT * FROM ACCITE";

        public AcciteRepository(IUnitOfWork unitOfWorkCurrent, ICacheManagerFactory cacheManagerFactory)
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
            return Accite.GetPropDefs();
        }

        public override string GetTableName()
        {
            return "ACCITE";
        }

        public override IBaseModel ToDbModel(DTOAccite item)
        {
            var result = new Accite();
            result.Aitrecno = item.AitRecNo;
            result.Aitamount = item.AitAmount;
            result.Aitatrrecno = item.AitAtrRecNo;
            result.Aitautlogno = item.Aitautlogno;
            result.Aitbaseamount = item.AitBaseAmount;
            result.Aitdrcr = item.AitDrCr;
            result.Aiteuroamount = item.AitEuroAmount;
            result.Aitganrecno = item.AitGanRecNo;
            result.Aitgltrecno = item.Aitgltrecno;
            result.Aititerecno = item.AitIteRecNo;
            result.Aititerevno = item.Aititerevno;
            result.Aitpstrecno = item.AitPstRecNo;
            result.Aitsaloffno = item.Aitsaloffno;
            result.Bankstmtdetrecno = item.Bankstmtdetrecno;
            return result;
        }

        protected override List<DTOAccite> GetDataInternal(List<ISearchField> searchFields, CachingStrategy allowFromCache, uint? topRows)
        {
            string query = ConstructSimpleQuery(_sqlQuery, searchFields, true, topRows);

            var data = new List<DTOAccite>();

            IEnumerable<Accite> results = null;

            try
            {
                results = UnitOfWorkCurrent.Query<Accite>(query);
            }
            catch (Exception ex)
            {
                throw new DatabaseQueryException("Could not load ACCITE" + Environment.NewLine + ex.Message, ex);
            }

            if (results != null)
            {
                foreach (var item in results)
                {
                    data.Add
                        (
                            new DTOAccite
                            {
                                AitRecNo = item.Aitrecno,
                                AitAmount = item.Aitamount ?? 0,
                                AitAtrRecNo = item.Aitatrrecno,
                                Aitautlogno = item.Aitautlogno,
                                AitBaseAmount = item.Aitbaseamount ?? 0,
                                AitDrCr = item.Aitdrcr,
                                AitEuroAmount = item.Aiteuroamount ?? 0,
                                AitGanRecNo = item.Aitganrecno,
                                Aitgltrecno = item.Aitgltrecno,
                                AitIteRecNo = item.Aititerecno,
                                Aititerevno = item.Aititerevno,
                                AitPstRecNo = item.Aitpstrecno,
                                Aitsaloffno = item.Aitsaloffno,
                                Bankstmtdetrecno = item.Bankstmtdetrecno
                            }
                        );
                }
            }

            return data;
        }

        protected override long ReserveSequenceRangeInternal(int? keyNumber = 1)
        {
            return UnitOfWorkCurrent.GetNextIdentity("LstAitRecNo", keyNumber ?? 1);
        }
    }

}
