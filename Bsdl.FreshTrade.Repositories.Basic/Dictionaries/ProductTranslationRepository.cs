using Bsdl.FreshTrade.Domain.Basic.Entities;
using Bsdl.FreshTrade.Domain.Basic.Enums;
using Bsdl.FreshTrade.Domain.Basic.Interfaces;
using Bsdl.FreshTrade.Repositories.Basic.Interfaces;
using Bsdl.FreshTrade.Repositories.Basic.Utilities.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Bsdl.FreshTrade.Repositories.Basic.Dictionaries
{
    public class ProductTranslationRepository : DapperRepositoryBase<DTOProductTranslation>, IProductTranslationRepository
    {
        const int PreInvTransType = 2;

        public ProductTranslationRepository(IUnitOfWork unitOfWorkCurrent, ICacheManagerFactory cacheManagerFactory) : base(
            unitOfWorkCurrent, 
            cacheManagerFactory,
                new List<ISearchFieldDef>
                {
                    new SearchFieldDef<DTOProductTranslation, int>(i => i.Language, FieldNames.FLDLANGNO, FieldType.Integer),
                    new SearchFieldDef<DTOProductTranslation, int>(i => i.ProductNo, FieldNames.FLDRECNO, FieldType.Integer),
                }

            )
        {
        }

        protected override List<DTOProductTranslation> GetDataInternal(List<ISearchField> searchFields, CachingStrategy allowFromCache, uint? topRows)
        {
            string currencyQuery = @"SELECT Lt.TransDesciption, Ft.FLDLANGNO, Ft.FLDRECNO
FROM FLDLANGTRANS Ft
INNER JOIN LANGTRANS Lt on Ft.FLDTRNSRECNO = Lt.TRNSRECNO
WHERE Ft.FLDTYPNO =" + PreInvTransType;

            string query = ConstructSimpleQuery(currencyQuery, searchFields, false, topRows);
            var results = UnitOfWorkCurrent.Query<ProductTranslationLine>(query);

            return
                results.Select
                (
                    item =>
                    new DTOProductTranslation
                    {
                        ProductNo = item.FldRecNo,
                        Language = item.FldLangNo,
                        Description = item.TransDesciption
                    }
                ).ToList();
        }
    }

    public class ProductTranslationLine
    {
        public int FldRecNo { get; set; }
        public int FldLangNo { get; set; }
        public string TransDesciption { get; set; }

    }

    public static class FieldNames
    {
// ReSharper disable InconsistentNaming
        public const string FLDLANGNO = "FLDLANGNO";
        public const string FLDRECNO = "FLDRECNO";
// ReSharper restore InconsistentNaming
    }
}
