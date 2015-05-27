using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bsdl.FreshTrade.Domain.Basic.Entities;
using Bsdl.FreshTrade.Domain.Basic.Interfaces;
using Bsdl.FreshTrade.Repositories.Basic.DBModel;
using Bsdl.FreshTrade.Repositories.Basic.Interfaces;
using Bsdl.FreshTrade.Repositories.Basic.Utilities.Interfaces;
using Bsdl.FreshTrade.Domain.Basic.Enums;

namespace Bsdl.FreshTrade.Repositories.Basic.UserRepository
{
    public class UserToSalesOfficeRepository : DapperRepositoryBase<DTOUserToSalesOffice>, IUserToSalesOfficeRepository
    {
        private const string _sqlQuery = @"SELECT * FROM LOGTOSALOFF";

        public UserToSalesOfficeRepository(IUnitOfWork unitOfWorkCurrent, ICacheManagerFactory cacheManagerFactory)
            : base
            (
                unitOfWorkCurrent,
                cacheManagerFactory,
                new List<ISearchFieldDef>
                {
                    new SearchFieldDef<DTOUserToSalesOffice, int>(i => i.UserId, LogToSalOff.FieldNames.LOGONNO, FieldType.Integer),
                    new SearchFieldDef<DTOUserToSalesOffice, bool>(i => i.CanSell, LogToSalOff.FieldNames.LOGCANSELL, FieldType.Bool),
                    new SearchFieldDef<DTOUserToSalesOffice, bool>(i => i.CanAccount, LogToSalOff.FieldNames.LOGCANACCTS, FieldType.Bool),
                    new SearchFieldDef<DTOUserToSalesOffice, bool>(i => i.CanChangeStock, LogToSalOff.FieldNames.LOGCANCHNGSTC, FieldType.Bool)
                }
            )
        {
        }

        protected override List<DTOUserToSalesOffice> GetDataInternal(List<ISearchField> searchFields, CachingStrategy allowFromCache, uint? topRows)
        {
            string query = ConstructSimpleQuery(_sqlQuery, searchFields, true, topRows);
            var results = UnitOfWorkCurrent.Query<LogToSalOff>(query);

            return results
                    .Select(item =>
                        new DTOUserToSalesOffice
                        {
                            UserId = item.Logonno,
                            SalesOfficeNo = item.Saloffno,
                            CanSell = item.Logcansell > 0,
                            CanAccount = item.Logcanaccts > 0,
                            CanChangeStock = item.Logcanchngstc > 0
                        })
                    .ToList();
        }

        public List<int> GetUserSalesOffices(int userId, bool? canSell, bool? canAccount, bool? canChangeStock)
        {
            var searchFields = 
                new List<ISearchField>
                    {
                        new SearchFieldGeneric<DTOUserToSalesOffice, int>(u => u.UserId).Apply(userId, FieldType.Integer)
                    };
            if (canSell.HasValue)
            {
                searchFields.Add(new SearchFieldGeneric<DTOUserToSalesOffice, bool>(u => u.CanSell).Apply(canSell.Value, FieldType.Bool));
            }
            if (canAccount.HasValue)
            {
                searchFields.Add(new SearchFieldGeneric<DTOUserToSalesOffice, bool>(u => u.CanAccount).Apply(canAccount.Value, FieldType.Bool));
            }
            if (canChangeStock.HasValue)
            {
                searchFields.Add(new SearchFieldGeneric<DTOUserToSalesOffice, bool>(u => u.CanChangeStock).Apply(canChangeStock.Value, FieldType.Bool));
            }
            
            return GetData
                (
                    searchFields,
                    CachingStrategy.PerRequest
                ).Select(i => i.SalesOfficeNo).ToList();
        }

    }
}
