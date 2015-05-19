using System;
using Bsdl.FreshTrade.Domain.Account.Entities;
using Bsdl.FreshTrade.Domain.Basic.Enums;
using Bsdl.FreshTrade.Domain.Basic.Exceptions.DataAccess;
using Bsdl.FreshTrade.Domain.Basic.Interfaces;
using Bsdl.FreshTrade.Repositories.Account.Interfaces;
using Bsdl.FreshTrade.Repositories.Basic;
using Bsdl.FreshTrade.Repositories.Basic.Interfaces;
using Bsdl.FreshTrade.Repositories.Basic.Utilities.Interfaces;
using System.Collections.Generic;

namespace Bsdl.FreshTrade.Repositories.Account.Customer
{
    public class CustomerGroupRepository : DapperRepositoryBase<DTOCustomerGroup>, ICustomerGroupRepository
    {
        private const string SqlQuery =
@"SELECT 
  G.*,
  NVL(A.AccCount, 0) as AccCount
FROM CSTANGRP G 
  LEFT JOIN
  (
    SELECT
      CSDCSGRECNO,
      COUNT(*) as AccCount
    FROM CSTANREC
    GROUP BY CSDCSGRECNO
  ) A on A.CSDCSGRECNO = G.CSGRECNO";

        public CustomerGroupRepository(IUnitOfWork unitOfWorkCurrent, ICacheManagerFactory cacheManagerFactory)
            : base
            (
            unitOfWorkCurrent,
            cacheManagerFactory,
            new List<ISearchFieldDef>
                {
                    new SearchFieldDef<DTOCustomerGroup, int>(i => i.Type, DBModel.CustomerGroup.FieldNames.CSGTYPE, FieldType.Integer)
                }

            )
        {
        }

        protected override List<DTOCustomerGroup> GetDataInternal(List<ISearchField> searchFields, CachingStrategy allowFromCache, uint? topRows)
        {
            string query = ConstructQuery(SqlQuery, searchFields, null, true, topRows);

            var data = new List<DTOCustomerGroup>();

            IEnumerable<CustomerGroupEx> results;

            try
            {
                results = UnitOfWorkCurrent.Query<CustomerGroupEx>(query);
            }
            catch (Exception ex)
            {
                throw new DatabaseQueryException("Could not load Customer Groups" + Environment.NewLine + ex.Message, ex);
            }

            foreach (var dbData in results)
            {
                data.Add
                    (
                        new DTOCustomerGroup
                        {
                            Id = dbData.Csgrecno,
                            Description = dbData.Csgdesc,
                            ContainerNo = dbData.Csgcontainergroup.HasValue ? dbData.Csgcontainergroup.Value : (short)0,
                            CustomerCount = dbData.Csgnoofcst.HasValue ? dbData.Csgnoofcst.Value : 0 ,
                            Type = dbData.Csgtype.HasValue ? dbData.Csgtype.Value : 1,
                            AccountCount = dbData.AccCount
                        }

                    );
            }

            return data;
        }

        public class CustomerGroupEx : DBModel.CustomerGroup
        {
            public int AccCount { get; set; }
        }
    }
}
