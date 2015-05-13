using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bsdl.FreshTrade.Domain.Basic.Exceptions;
using Bsdl.FreshTrade.Domain.Basic.Interfaces;
using Bsdl.FreshTrade.Domain.PreInv.Entities;
using Bsdl.FreshTrade.Repositories.Basic;
using Bsdl.FreshTrade.Repositories.Basic.Interfaces;
using Bsdl.FreshTrade.Repositories.PreInv.DBModel;
using Bsdl.FreshTrade.Repositories.PreInv.Interfaces;
using Bsdl.FreshTrade.Repositories.Basic.Utilities.Interfaces;
using Bsdl.FreshTrade.Domain.Basic.Enums;

namespace Bsdl.FreshTrade.Repositories.PreInv.ProductRep
{
    public class ProductRepository: DapperRepositoryBase<DTOProduct>, IProductRepository
    {
        private const string _sqlQuery = @"SELECT * FROM PRDREC";

        private const string _sqlProdAnalysisGroupDetectSQL = "SELECT A.AllPRefNo, B.PrdGlAnlRecNo \r\n" +
                                                              "FROM PRDALLDESCS A  \r\n" +
                                                              "  LEFT JOIN PRDGNANLTODESC B ON A.ALLPREFNO = B.ALLPREFNO \r\n" +
                                                              "WHERE A.ALLPLEVNO =";

        private const string _sqlProdStandardUnitsSQL = "SELECT Distinct AllPRefNo, AllPMiscPrds, AllPStndUnit \r\n" +
                                                              "FROM PRDALLDESCS \r\n" +
                                                              "  LEFT JOIN PRDGNANLTODESC B ON A.ALLPREFNO = B.ALLPREFNO \r\n" +
                                                              "WHERE A.ALLPLEVNO =";

        public ProductRepository(IUnitOfWork unitOfWorkCurrent, ICacheManagerFactory cacheManagerFactory)
            : base
            (
                unitOfWorkCurrent, 
                cacheManagerFactory,
                new List<ISearchFieldDef>
                {
                    new SearchFieldDef<DTOProduct, int>(i => i.Id, Prdrec.FieldNames.PRCPRDNO, FieldType.Integer)
                }
            )
        {
        }

        protected override List<DTOProduct> GetDataInternal(List<ISearchField> searchFields, CachingStrategy allowFromCache, uint? topRows)
        {
            string query = ConstructSimpleQuery(_sqlQuery, searchFields, true, topRows);
            var results = UnitOfWorkCurrent.Query<Prdrec>(query);

            return results
                    .Select(item =>
                        new DTOProduct
                            {
                                Id = item.Prcprdno,
                                Level1Ref = item.Prcref1,
                                Level2Ref = item.Prcref2,
                                Level3Ref = item.Prcref3,
                                Level4Ref = item.Prcref4,
                                Level5Ref = item.Prcref5,
                                Level6Ref = item.Prcref6,
                                Description = item.Prcdescription,
                                ProductRef = item.Prcprdref,
                                StandardBoxWeightInKg = item.Prcweight
                            })
                    .ToList();
        }

        public Dictionary<int, int?> GetProductAnalysisGroups(int productAnalysisLevNo)
        {
            string query = _sqlProdAnalysisGroupDetectSQL + productAnalysisLevNo.ToString();
            var results = UnitOfWorkCurrent.Query<ProdAnalysisGroupResultLine>(query);

            return results.ToDictionary(i => i.AllPRefNo, i => i.PrdGlAnlRecNo);
        }

        public Dictionary<int, DTOProductStandardUnitRecord> GetProductStandardUnits(int standardUnitLevNo)
        {
            string query = _sqlProdStandardUnitsSQL + standardUnitLevNo.ToString();
            var results = UnitOfWorkCurrent.Query<ProdProdStandardUnitsResultLine>(query);

            return results.ToDictionary(
                i => i.AllPRefNo,
                i =>
                    {
                        bool isMisc = (i.AllPMiscPrds ?? 0) > 0;
                        var result =
                            new DTOProductStandardUnitRecord
                                {
                                    IsMiscProduct = isMisc,
                                    StandardUnit = isMisc ? -1 : (((i.AllPStndUnit??0M) >= 0.05M) ? i.AllPStndUnit??0 : 0)
                                };
                        if (result.StandardUnit == 0)
                        {
                            throw new FreshTradeException("Not all products has standard unit set");
                        }
                        return result;
                    }
                );
        }

        public class ProdAnalysisGroupResultLine
        {
            public int AllPRefNo { get; set; }
            public int? PrdGlAnlRecNo { get; set; }
        }

        public class ProdProdStandardUnitsResultLine
        {
            public int AllPRefNo { get; set; }
            public short? AllPMiscPrds { get; set; }
            public decimal? AllPStndUnit { get; set; }
        }

    }
}
