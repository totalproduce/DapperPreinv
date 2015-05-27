using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bsdl.FreshTrade.Domain.Basic.Interfaces;
using Bsdl.FreshTrade.Domain.PreInv.Entities;
using Bsdl.FreshTrade.Repositories.Basic;
using Bsdl.FreshTrade.Repositories.Basic.Interfaces;
using Bsdl.FreshTrade.Repositories.Basic.Utilities.Interfaces;
using Bsdl.FreshTrade.Repositories.PreInv.DBModel;
using Bsdl.FreshTrade.Repositories.PreInv.Interfaces;

namespace Bsdl.FreshTrade.Repositories.PreInv.ErrorRep
{
    public class ErrorDescriptionRepository : DapperRepositoryBase<DTOErrorDescription>, IErrorDescriptionRepository
    {
        private const string _sqlQuery = @"SELECT * FROM PREINVERRORS";

        public ErrorDescriptionRepository(IUnitOfWork unitOfWorkCurrent, ICacheManagerFactory cacheManagerFactory)
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

        protected override List<DTOErrorDescription> GetDataInternal(List<ISearchField> searchFields, CachingStrategy allowFromCache, uint? topRows)
        {
            string query = ConstructSimpleQuery(_sqlQuery, searchFields, true, topRows);
            var results = UnitOfWorkCurrent.Query<PreInvError>(query);

            return results
                    .Select(item =>
                        new DTOErrorDescription
                        {
                            No = item.Errno,
                            Reason = item.Errreason,
                            IsCritial = (item.Erriscritical??0) > 0
                        })
                    .ToList();
        }
    }
}
