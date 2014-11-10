using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bsdl.FreshTrade.Domain.Basic.Exceptions.DataAccess;
using Bsdl.FreshTrade.Domain.Basic.Interfaces;
using Bsdl.FreshTrade.Domain.PreInv.Entities;
using Bsdl.FreshTrade.Repositories.Basic;
using Bsdl.FreshTrade.Repositories.Basic.Interfaces;
using Bsdl.FreshTrade.Repositories.Basic.Persistance;
using Bsdl.FreshTrade.Repositories.Basic.Utilities.Interfaces;
using Bsdl.FreshTrade.Repositories.PreInv.DBModel;
using Bsdl.FreshTrade.Domain.Basic.Enums;
using Bsdl.FreshTrade.Repositories.PreInv.Interfaces;
using Bsdl.FreshTrade.Domain.Basic.Entities;

namespace Bsdl.FreshTrade.Repositories.PreInv.EdiRep
{
    public class EdiCoSuppNoRepository : DapperRepositoryBase<DTOEdiCoSuppNo>, IEdiCoSuppNoRepository
    {
        private const string _sqlQuery = @"SELECT * FROM COSUPPNO";

        public EdiCoSuppNoRepository(IUnitOfWork unitOfWorkCurrent, ICacheManagerFactory cacheManagerFactory)
            : base
            (
                unitOfWorkCurrent,
                cacheManagerFactory,
                new List<ISearchFieldDef>
                {
                    new SearchFieldDef<DTOEdiCoSuppNo, int>(i => i.CompanyNo, EdiCoSuppNo.FieldNames.COGLBNO, FieldType.Integer)
                    /*new SearchFieldDef<DTOEdiCoSuppNo, int>(i => i.HeadOfficeId, EdiCoSuppNo.FieldNames.HOCODE, FieldType.Integer),*/
                }
            )
        {
        }

        protected override List<DTOEdiCoSuppNo> GetDataInternal(List<ISearchField> searchFields, CachingStrategy allowFromCache, uint? topRows)
        {
            const string strYes = "Yes";
            const string strNo = "No";
            string query = ConstructSimpleQuery(_sqlQuery, searchFields, true, topRows);

            var results = UnitOfWorkCurrent.Query<EdiCoSuppNo>(query);

            return results
                .Select(item =>
                    new DTOEdiCoSuppNo
                    {
                        HeadOfficeId = item.Hocode,
                        CompanyNo = item.Coglbno,
                        EdiPrgOrders = item.Ediprgorders == strYes,
                        EdiOrders = item.Ediorders == strYes,
                        EdiInvoices = !string.IsNullOrEmpty(item.Ediinvoices) && (item.Ediinvoices != strNo),
                        EdiDebitCredits = !string.IsNullOrEmpty(item.Edidbtscdts) && (item.Edidbtscdts != strNo),

                    })
                .ToList();
        }

        public List<DTOEdiCoSuppNo> GetByCompanyNo(int companyNo)
        {
            return
                GetData
                    (
                        new List<ISearchField>
                            {
                                new SearchFieldGeneric<DTOEdiCoSuppNo, int>(k => k.CompanyNo).Apply(companyNo, FieldType.Integer)
                            },
                        CachingStrategy.GlobalCache
                    );
        }

        /*public List<DTOEdiCoSuppNo> GetByHofIDs(List<int> hofIds, int companyNo)
        {
            return GetDataInChunksCustom
                (
                    i =>
                    GetData
                        (
                            new List<ISearchField>
                                {
                                    new SearchFieldGeneric<DTOEdiCoSuppNo, int>(k => k.HeadOfficeId).Apply(i, FieldType.List),
                                    new SearchFieldGeneric<DTOEdiCoSuppNo, int>(k => k.CompanyNo).Apply(companyNo, FieldType.Integer)
                                },
                            false
                        ),
                    hofIds
                );
        }*/


    }

}
