using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bsdl.FreshTrade.Domain.Account.Entities;
using Bsdl.FreshTrade.Domain.Basic.Entities;
using Bsdl.FreshTrade.Domain.Basic.Enums;
using Bsdl.FreshTrade.Domain.Basic.Exceptions.DataAccess;
using Bsdl.FreshTrade.Domain.Basic.Interfaces;
using Bsdl.FreshTrade.Domain.PreInv.Entities;
using Bsdl.FreshTrade.Repositories.Basic;
using Bsdl.FreshTrade.Repositories.Basic.Interfaces;
using Bsdl.FreshTrade.Repositories.Basic.Utilities.Interfaces;
using Bsdl.FreshTrade.Repositories.PreInv.Interfaces;

namespace Bsdl.FreshTrade.Repositories.PreInv.PriceListRep
{
    public class PriceGroupRepository : DapperRepositoryBase<DTOPriceGroupLookupResult>, IPriceGroupRepository
    {
        private const string _sqlQuery = @"SELECT 
  C.PRCCLARECNO,
  G.PRCGRPRECNO, 
  G.GRPSALOFF
FROM PRCNEWCSTS C
  INNER JOIN PRCNEWGRPs G ON G.PRCGRPRECNO = C.CSTPRCGRPRECNO
";
        private const string _alternativePriceGroupsSqlQuery = @"SELECT AGLNKCLARECNO, AGLNKGRPRECNO FROM ALTGRPCSTLNK WHERE AGLNKCLARECNO IN ";

        private const string _PriceGroupDescriptionSqlQuery = @"SELECT PRCDESC FROM PRCNEWGRPS WHERE PRCGRPRECNO = {0}";

        public PriceGroupRepository(IUnitOfWork unitOfWorkCurrent, ICacheManagerFactory cacheManagerFactory)
            : base
            (
                unitOfWorkCurrent, 
                cacheManagerFactory,
                new List<ISearchFieldDef>
                {
                    new SearchFieldDef<DTOAccountClass, int>(i => i.Id, "PRCCLARECNO", FieldType.Integer)
                }
            )
        {
        }

        protected override List<DTOPriceGroupLookupResult> GetDataInternal(List<ISearchField> searchFields, CachingStrategy allowFromCache, uint? topRows)
        {
            string query = ConstructSimpleQuery(_sqlQuery, searchFields, true, topRows);
            IEnumerable<PriceGroupLookupResultLine> results = UnitOfWorkCurrent.Query<PriceGroupLookupResultLine>(query);

            return results
                .Select(item =>
                    new DTOPriceGroupLookupResult
                        {
                            AccountClassId = item.Prcclarecno,
                            PriceGroupNo = item.Prcgrprecno,
                            PriceGroupSalesOfficeNo = item.Grpsaloff
                        })
                .ToList();
        }

        public List<DTOPriceGroupLookupResult> GetPriceGroupsByIDs(List<int> accountClassIds)
        {
            var searchParams =
                new List<ISearchField>
                    {
                        new SearchFieldGeneric<DTOAccountClass, int>(i => i.Id).Apply(accountClassIds, FieldType.List)
                    };

            return GetData(searchParams, CachingStrategy.NoCache);
        }

        public Dictionary<int, int> GetAlternativePriceGroupsByIDs(List<int> accountClassIds)
        {
            if ((accountClassIds == null) || (accountClassIds.Count == 0))
            {
                return new Dictionary<int, int>();
            }
            var results = GetDataInChunksCustom
                (
                    i =>
                    UnitOfWorkCurrent.Query<AlternativePriceGroupLookupResultLine>
                    (
                        _alternativePriceGroupsSqlQuery + GetSearchFieldValueAsString(FieldType.List, i)
                    ).ToList(),
                    accountClassIds
                );
            return results.ToDictionary(i => i.Aglnkclarecno, i => i.Aglnkgrprecno);
        }

        public string GetPriceGroupDescription(int priceGroupId)
        {
            var group = UnitOfWorkCurrent.Query<PriceGroupDescription>(string.Format(_PriceGroupDescriptionSqlQuery, priceGroupId)).FirstOrDefault();

            return group == null ? string.Empty : group.PrcDesc.Trim();
        }

        public class PriceGroupLookupResultLine
        {
            public int Prcclarecno { get; set; }
            public int Prcgrprecno { get; set; }
            public int? Grpsaloff { get; set; }
        }

        public class AlternativePriceGroupLookupResultLine
        {
            public int Aglnkclarecno { get; set; }
            public int Aglnkgrprecno { get; set; }
        }

        public class  PriceGroupDescription
        {
            public string PrcDesc { get; set; } 
        }
    }
}
