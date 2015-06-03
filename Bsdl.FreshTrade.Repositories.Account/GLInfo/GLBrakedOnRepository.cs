using System;
using System.Linq;
using Bsdl.FreshTrade.Domain.Account.Entities;
using Bsdl.FreshTrade.Domain.Basic.Exceptions.DataAccess;
using Bsdl.FreshTrade.Domain.Basic.Interfaces;
using Bsdl.FreshTrade.Repositories.Account.DBModel;
using Bsdl.FreshTrade.Repositories.Account.Interfaces;
using Bsdl.FreshTrade.Repositories.Basic;
using Bsdl.FreshTrade.Repositories.Basic.Interfaces;
using Bsdl.FreshTrade.Repositories.Basic.Utilities.Interfaces;
using System.Collections.Generic;

namespace Bsdl.FreshTrade.Repositories.Account.GLInfo
{
    public class GLBrakedOnRepository : DapperRepositoryBase<DTOGLBrakedOn>, IGLInfoRepository
    {
        public GLBrakedOnRepository(IUnitOfWork unitOfWorkCurrent, ICacheManagerFactory cacheManagerFactory,
            IEnumerable<ISearchFieldDef> validSearchFields)
            : base(unitOfWorkCurrent, cacheManagerFactory, validSearchFields)
        {
            _allowQueryWithoutFilter = true;
        }


        private const string GLInfoQuerySql = @"
SELECT
  GL.*
FROM GlBrkOn GL";

        protected override List<DTOGLBrakedOn> GetDataInternal(List<ISearchField> searchFields, CachingStrategy allowFromCache,
            uint? topRows)
        {
            var query = ConstructQuery(GLInfoQuerySql, searchFields, null, true, topRows);

            var data = ConnectionAndQueryHandler(query);

            return data;
        }

        private List<DTOGLBrakedOn> ConnectionAndQueryHandler(string query)
        {
            IEnumerable<GLBrakedOn> results = null;

            try
            {
                results = UnitOfWorkCurrent.Query<GLBrakedOn>(query);
            }
            catch (Exception exception)
            {
                var ex = new DatabaseQueryException("Could not load GL Braked Information" + Environment.NewLine + exception.Message);
                //AppError.SetError(ex, exception.StackTrace, ErrorType.Sql, exception.Message, query);
                throw ex;
            }

            return results.Select
            (
                rl => 
                new DTOGLBrakedOn()
                    {
                        CrossRefCode = rl.Glbglxrcode.TrimEnd(),
                        RecNo = rl.Glbrecno,
                        SalesOfficeNo = rl.Glbsaloffno, 
                        AccountGLType = rl.Glbaccindno, 
                        ProductLinkNo = rl.Glbprdlnkno, 
                        DiscountRebateGLGroup = rl.Glbdisglrecno, 
                        VatRecNo = rl.Glbvatrecno, 
                        VatTypeNo = rl.Glbvattypeno,
                        GlbGanRec = rl.Glbganrec??0
                    }
            ).ToList();
        }
    }


}
