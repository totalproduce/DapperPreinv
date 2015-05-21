using System;
using System.Collections.Generic;
using Bsdl.FreshTrade.Domain.Account.Entities;
using Bsdl.FreshTrade.Domain.Account.Enums;
using Bsdl.FreshTrade.Domain.Account.Interfaces;
using Bsdl.FreshTrade.Domain.Basic.Interfaces;
using Bsdl.FreshTrade.Domain.PreInv.Enums;
using Bsdl.FreshTrade.Repositories.Account.Interfaces;
using Bsdl.FreshTrade.Repositories.Basic.Interfaces;

namespace Bsdl.FreshTrade.Repositories.Account.Mock.Accounts
{
    public class MockAccountRepository : IAccountRepository
    {
        public long ReserveSequenceRangeInternal(int? keyNumber = 1)
        {
            throw new NotImplementedException();
        }

        public List<DTOAccount> GetData(List<ISearchField> searchFields, CachingStrategy allowFromCache, bool forceRefresh = false, uint? topRows = null)
        {
            var accountList = new List<Domain.Account.Entities.DTOAccount>();
            for (int i = 0; i < (topRows??1000); i++)
            {
                accountList.Add(new Domain.Account.Entities.DTOAccount
                {
                    Id = 9000+i,
                    AccountId = i,
                    Code = "TO" + i,
                    Name = "Test Office " + i,
                    Address1 = i + " JB Street",
                    Address2 = string.Empty,
                    Address3 = string.Empty,
                    Address4 = string.Empty,
                    PostCode = "IM4 56" + i%10,
                    Telephone = "010 3" + i%10 + "5 2918",
                    Fax  = "010 3" + i%10 + "5 2919",
                    Vat = null,
                    Type = DTOAccountType.Customer,
                    InvoicePeriod = 1,
                    InvoiceType = DTOInvoiceType.PerDeliveryGrossAllowSplit,
                    StockHoldLocation = 0
                }
            );
            }
            //AccountList.Accounts.Add(new Bsdl.FreshTrade.Domain.Account.Entities.Account(2, "2nd Sample Premesis", "SO1", 1, 010, 020, 030, 040, "Bob Cherunkle",
            //    "123 Alphabet Lane", string.Empty, string.Empty, string.Empty, "010 345 2918", "0101 1010 0101", "0202 2020 0202", "0303 3030 0303",
            //    true, true, true));

            //AccountList.Accounts.Add(new Bsdl.FreshTrade.Domain.Account.Entities.Account(3, "3rd place of work", "SO1", 1, 010, 020, 030, 040, "Bob Cherunkle",
            //    "123 Alphabet Lane", string.Empty, string.Empty, string.Empty, "010 345 2918", "0101 1010 0101", "0202 2020 0202", "0303 3030 0303",
            //    false, false, true));

            return accountList;
        }

        public DTOAccount Add(DTOAccount entity)
        {
            throw new NotImplementedException();
        }

        public void Add(ICollection<DTOAccount> entities)
        {
            throw new NotImplementedException();
        }

        public int Update(DTOAccount entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(DTOAccount entity)
        {
            throw new NotImplementedException();
        }

        public void Debug(string hint)
        {
            throw new NotImplementedException();
        }


        public List<Domain.Account.Entities.DTOAccount> GetDataForSalesOffice(int userDbID, System.Collections.Generic.List<Domain.Basic.Interfaces.ISearchField> searchField)
        {
            throw new NotImplementedException();
        }


        public List<Domain.Account.Entities.DTOAccount> GetAccountByAccClassIDs(List<int> ids)
        {
            return null;
        }


        public Dictionary<int, string> GetLocalAccounts(int salesOfficeNo, List<int> accountClassIds)
        {
            throw new NotImplementedException();
        }


        public int Update(DTOAccount oldItem, DTOAccount newItem, ICollection<IFieldNameRef> nonKeyFieldsForWhereClause = null)
        {
            throw new NotImplementedException();
        }

        public long GetNextSequence()
        {
            throw new NotImplementedException();
        }

        public void ReserveSequenceRange(int? keyNumber = 1)
        {
            throw new NotImplementedException();
        }


        public void Update(ICollection<IFieldNameRef> updateFields, ICollection<IRowUpdateInfo> updateRows)
        {
            throw new NotImplementedException();
        }


        public void Update(ICollection<Domain.Basic.Utilities.UpdatePair<DTOAccount>> items)
        {
            throw new NotImplementedException();
        }


        public void Delete(ICollection<DTOAccount> items)
        {
            throw new NotImplementedException();
        }


        public Dictionary<int, string> GetLocalAccounts(int salesOfficeNo, DTOAccountType? accountType, CachingStrategy strategy)
        {
            throw new NotImplementedException();
        }
    }
}
