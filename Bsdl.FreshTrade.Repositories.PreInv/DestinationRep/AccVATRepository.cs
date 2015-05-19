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
using Bsdl.FreshTrade.Domain.Basic.Enums;

namespace Bsdl.FreshTrade.Repositories.PreInv.DestinationRep
{
    public class AccVATRepository : DapperRepositoryBase<DTOAccVAT>, IAccVATRepository
    {
        private const string _sqlQuery = @"SELECT * FROM ACCVAT";

        public AccVATRepository(IUnitOfWork unitOfWorkCurrent, ICacheManagerFactory cacheManagerFactory)
            : base
            (
                unitOfWorkCurrent,
                cacheManagerFactory,
                new List<ISearchFieldDef>
                {
                    new SearchFieldDef<DTOAccVAT, int>(i => i.AvaAtrRecNo, AccVAT.FieldNames.AVAATRRECNO, FieldType.Integer),
                }
            )
        {
        }


        public override IList<EntityPropDef> GetTableFieldsDefs()
        {
            return AccVAT.GetPropDefs();
        }

        public override string GetTableName()
        {
            return "ACCVAT";
        }

        public override IBaseModel ToDbModel(DTOAccVAT item)
        {
            var result = new AccVAT();
            result.Avaatrrecno = item.AvaAtrRecNo;
            result.Avavatcde = item.Avavatcde;
            result.Avaaddkey = item.Avaaddkey;
            result.Avavattypno = item.Avavattypno;
            result.Avabasegoods = item.Avabasegoods;
            result.Avabasevat = item.Avabasevat;
            result.Avaeurogoods = item.Avaeurogoods;
            result.Avaeurovat = item.Avaeurovat;
            result.Avagoods = item.Avagoods;
            result.Avaisrevcrdr = item.Avaisrevcrdr;
            result.Avarptdate = item.Avarptdate;
            result.Avarptno = item.Avarptno;
            result.Avavat = item.Avavat;
            result.Avavatrate = item.Avavatrate;
            result.Avaveano = item.Avaveano;
            result.Exclgoods = item.Exclgoods;
            result.Vatlnkrecno = item.VatLnkRecNo;
            return result;
        }

        protected override List<DTOAccVAT> GetDataInternal(List<ISearchField> searchFields, CachingStrategy allowFromCache, uint? topRows)
        {
            string query = ConstructSimpleQuery(_sqlQuery, searchFields, true, topRows);

            var data = new List<DTOAccVAT>();

            IEnumerable<AccVAT> results = null;

            try
            {
                results = UnitOfWorkCurrent.Query<AccVAT>(query);
            }
            catch (Exception ex)
            {
                throw new DatabaseQueryException("Could not load AccVAT" + Environment.NewLine + ex.Message, ex);
            }

            if (results != null)
            {
                foreach (var item in results)
                {
                    data.Add
                        (
                            new DTOAccVAT
                            {
                                AvaAtrRecNo = item.Avaatrrecno,
                                Avavatcde = item.Avavatcde,
                                Avaaddkey = item.Avaaddkey,
                                Avavattypno = item.Avavattypno,
                                Avabasegoods = item.Avabasegoods ?? 0,
                                Avabasevat = item.Avabasevat ?? 0,
                                Avaeurogoods = item.Avaeurogoods ?? 0,
                                Avaeurovat = item.Avaeurovat ?? 0,
                                Avagoods = item.Avagoods ?? 0,
                                Avaisrevcrdr = item.Avaisrevcrdr,
                                Avarptdate = item.Avarptdate,
                                Avarptno = item.Avarptno,
                                Avavat = item.Avavat ?? 0,
                                Avavatrate = item.Avavatrate ?? 0,
                                Avaveano = item.Avaveano,
                                Exclgoods = item.Exclgoods,
                                VatLnkRecNo = item.Vatlnkrecno
                            }
                        );
                }
            }

            return data;
        }

        public List<DTOAccVAT> GetByAtrRecNos(List<int> atrRecNos)
        {
            return GetDataInChunks(i => i.AvaAtrRecNo, atrRecNos);
        }

    }
}
