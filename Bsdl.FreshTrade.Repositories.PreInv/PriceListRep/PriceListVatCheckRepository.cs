using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bsdl.FreshTrade.Domain.Basic.Entities;
using Bsdl.FreshTrade.Domain.Basic.Enums;
using Bsdl.FreshTrade.Domain.Basic.Interfaces;
using Bsdl.FreshTrade.Domain.Basic.Utilities.DataTypeHandling;
using Bsdl.FreshTrade.Domain.PreInv.Entities;
using Bsdl.FreshTrade.Repositories.Basic;
using Bsdl.FreshTrade.Repositories.Basic.Interfaces;
using Bsdl.FreshTrade.Repositories.Basic.Utilities.Interfaces;
using Bsdl.FreshTrade.Repositories.PreInv.Interfaces;

namespace Bsdl.FreshTrade.Repositories.PreInv.PriceListRep
{
    public class PriceListVatCheckRepository : DapperRepositoryBase<DTOPriceListVatCheckResult>, IPriceListVatCheckRepository
    {
        private const string _sqlQuery = @"SELECT PR.PrcProdMinNo, PR.VatRecNo
FROM PrcNewListKey PL
  INNER JOIN PrcNewList Pr on PR.PrlLinkRecNo = CapPrcLinkRecNo
WHERE CapGrpRecNo = {0} AND ({1} >= PL.CapDateFrom) AND ({1} <= PL.CapDateTo)
";
        private const string _alternativePriceGroupsSqlQuery = @"SELECT AGLNKCLARECNO, AGLNKGRPRECNO FROM ALTGRPCSTLNK WHERE AGLNKCLARECNO IN ";

        public PriceListVatCheckRepository(IUnitOfWork unitOfWorkCurrent, ICacheManagerFactory cacheManagerFactory)
            : base
            (
                unitOfWorkCurrent, 
                cacheManagerFactory,
                new List<ISearchFieldDef>
                {
                    new SearchFieldDef<int, int>(AllowedParams.ParamName_CAPGRPRECNO, AllowedParams.ParamName_CAPGRPRECNO, FieldType.Integer),
                    new SearchFieldDef<int, int>(AllowedParams.ParamName_CAPDATE, AllowedParams.ParamName_CAPDATE, FieldType.Date)
                }
            )
        {
        }

        protected override List<DTOPriceListVatCheckResult> GetDataInternal(List<ISearchField> searchFields, CachingStrategy allowFromCache, uint? topRows)
        {
            var capGrpRecNoField = searchFields.First(i => i.FieldName == AllowedParams.ParamName_CAPGRPRECNO);
            var capDateField = searchFields.First(i => i.FieldName == AllowedParams.ParamName_CAPDATE);

            string query = string.Format(_sqlQuery, capGrpRecNoField.Value.ToString(), AlphaHandling.DateToSqlStr((DateTime)capDateField.Value));
            IEnumerable<PriceListVatCheckResultLine> results = UnitOfWorkCurrent.Query<PriceListVatCheckResultLine>(query);

            return results
                .Select(item =>
                    new DTOPriceListVatCheckResult
                        {
                            ProductId = item.PrcProdMinNo,
                            VatId = item.VatRecNo
                        })
                .ToList();
        }

        public List<DTOPriceListVatCheckResult> GetProductsVatByPriceGroupNoAndDate(int requiredPriceGroupNo, DateTime date)
        {
            var searchParams =
                new List<ISearchField>
                    {
                        new SearchFieldGeneric(AllowedParams.ParamName_CAPGRPRECNO).Apply(requiredPriceGroupNo, FieldType.Integer),
                        new SearchFieldGeneric(AllowedParams.ParamName_CAPDATE).Apply(date, FieldType.Date)
                    };

            return GetData(searchParams, CachingStrategy.PerRequest);
        }

        public static class AllowedParams
        {
            public const string ParamName_CAPGRPRECNO = "CAPGRPRECNO";
            public const string ParamName_CAPDATE = "CAPDATE";
        }
        public class PriceListVatCheckResultLine
        {
            public int PrcProdMinNo { get; set; }
            public int? VatRecNo { get; set; }
        }
    }
}
