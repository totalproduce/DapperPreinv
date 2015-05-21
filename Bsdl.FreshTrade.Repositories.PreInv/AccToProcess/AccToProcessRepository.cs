using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bsdl.FreshTrade.Domain.Account.Entities;
using Bsdl.FreshTrade.Domain.Basic.Entities;
using Bsdl.FreshTrade.Domain.Basic.Enums;
using Bsdl.FreshTrade.Domain.Basic.Exceptions.DataAccess;
using Bsdl.FreshTrade.Domain.Basic.Interfaces;
using Bsdl.FreshTrade.Repositories.Account.DBModel;
using Bsdl.FreshTrade.Repositories.Basic;
using Bsdl.FreshTrade.Repositories.Basic.DBModel;
using Bsdl.FreshTrade.Repositories.Basic.Interfaces;
using Bsdl.FreshTrade.Repositories.Basic.Utilities.Interfaces;
using Bsdl.FreshTrade.Repositories.PreInv.DBModel;
using Bsdl.FreshTrade.Repositories.PreInv.Interfaces;

namespace Bsdl.FreshTrade.Repositories.PreInv.AccToProcess
{
    public class AccToProcessRepository : DapperRepositoryBase<int>, IAccToProcessRepository
    {
        private const string _sqlQuery = @"
        SELECT DISTINCT AC.CLARECNO
        FROM DELHED DH
          INNER JOIN ORDERS O on DH.DLVORDRECNO = O.ORDRECNO AND O.ORDSALTYP = 'S'
          INNER JOIN ACCCLASS AC on O.ORDCSTCODE = AC.CLARECNO AND AC.CLAACCCSTSUP = 1
        WHERE DH.DLVRELINV = 'Rel' ";

        public AccToProcessRepository(IUnitOfWork unitOfWorkCurrent, ICacheManagerFactory cacheManagerFactory)
            : base
            (
                unitOfWorkCurrent,
                cacheManagerFactory,
                new List<ISearchFieldDef>
                {
                    new SearchFieldDef<int, int>(DELHED.FieldNames.DLVCURRECNO, DELHED.FieldNames.DLVCURRECNO, FieldType.Integer),
                    new SearchFieldDef<int, int>(DELHED.FieldNames.DLVSALOFFNO, DELHED.FieldNames.DLVSALOFFNO, FieldType.Integer),
                    new SearchFieldDef<int, int>(AccClass.FieldNames.CLARECNO, AccClass.FieldNames.CLARECNO, FieldType.Integer),
                }
            )
        {
            _allowToCacheData = false;
        }

        protected override List<int> GetDataInternal(List<ISearchField> searchFields, CachingStrategy allowFromCache, uint? topRows)
        {
            string query = ConstructSimpleQuery(_sqlQuery, searchFields, false, topRows);
            IEnumerable<AccClassResultLine> results;
            try
            {
                results = UnitOfWorkCurrent.Query<AccClassResultLine>(query);
            }
            catch (Exception ex)
            {
                throw new DatabaseQueryException("Cannot load Account Class to Process" + Environment.NewLine + ex.Message, ex);
            }

            return results.Select(i => i.ClaRecNo).ToList();
        }

        public List<int> GetAccToProcess(int currencyNo, int salesOfficeNo, List<int> preFilteredAccClassIDs = null)
        {
            return GetDataInChunksCustom
                (
                    i =>
                        {   
                            var searchParams = 
                                new List<ISearchField>
                                    {
                                        new SearchFieldGeneric(DELHED.FieldNames.DLVCURRECNO).Apply(currencyNo, FieldType.Integer)
                                    };
                            if (salesOfficeNo != DTOSalesOffice.IncludeAllSalesOfficesNo)
                            {
                                searchParams.Add(new SearchFieldGeneric(DELHED.FieldNames.DLVSALOFFNO).Apply(salesOfficeNo, FieldType.Integer));
                            }
                                        
                            if (i != null)
                            {
                                searchParams.Add(new SearchFieldGeneric(AccClass.FieldNames.CLARECNO).Apply(i, FieldType.List));
                            }

                            return GetData
                                (
                                    searchParams,
                                    CachingStrategy.NoCache
                                );
                        },
                    preFilteredAccClassIDs,
                    true
                );
        }
        
        public class AccClassResultLine
        {
            public int ClaRecNo { get; set; }
        }
    }
}
