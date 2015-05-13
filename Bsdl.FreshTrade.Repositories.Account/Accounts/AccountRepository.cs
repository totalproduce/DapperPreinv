using System.Linq;
using System.Text;
using Bsdl.FreshTrade.Domain.Account.Entities;
using Bsdl.FreshTrade.Domain.Account.Enums;
using Bsdl.FreshTrade.Domain.Basic.Entities;
using Bsdl.FreshTrade.Domain.Basic.Enums;
using Bsdl.FreshTrade.Domain.Basic.Exceptions;
using Bsdl.FreshTrade.Domain.Basic.Exceptions.DataAccess;
using Bsdl.FreshTrade.Domain.Basic.Interfaces;
using Bsdl.FreshTrade.Domain.Basic.Utilities.DataTypeHandling;
using Bsdl.FreshTrade.Domain.PreInv.Enums;
using Bsdl.FreshTrade.Repositories.Account.DBModel;
using Bsdl.FreshTrade.Repositories.Account.Interfaces;
using Bsdl.FreshTrade.Repositories.Basic;
using Bsdl.FreshTrade.Repositories.Basic.Interfaces;
using Bsdl.FreshTrade.Repositories.Basic.Utilities.Interfaces;
using System;
using System.Collections.Generic;

namespace Bsdl.FreshTrade.Repositories.Account.Accounts
{
    public class AccountRepository : DapperRepositoryBase<DTOAccount>, IAccountRepository
    {    

        private const string _sqlQuery = 
@"SELECT 
  A.*,
  C.CLARECNO,
  C.CLAACCCSTSUP
FROM ACCOUNTS A
  INNER JOIN ACCCLASS C ON A.ACCRECNO = C.CLAACCNO
";
        private const string _sqlAccountToSakesOfficeFilter = @"INNER JOIN ACCTOSALOFF S on C.CLARECNO = S.ACSCLARECNO
";

        private const string _sqlFuncName_LocalAccount = @"BSDL_PKAGE_ACCOUNTS.GETACCCODE";

        private const string _sqlLocalAccountBySalOffAccountType =
@"SELECT 
  C.CLARECNO,
  BSDL_PKAGE_ACCOUNTS.GETACCCODE(C.CLARECNO, S.ACSSALOFFNO) CLAACCCODE
FROM ACCOUNTS A
  INNER JOIN ACCCLASS C ON A.ACCRECNO = C.CLAACCNO
  INNER JOIN ACCTOSALOFF S on C.CLARECNO = S.ACSCLARECNO
";

        public AccountRepository(IUnitOfWork unitOfWorkCurrent, ICacheManagerFactory cacheManagerFactory)
            : base
            (
                unitOfWorkCurrent,
                cacheManagerFactory, 
                new List<ISearchFieldDef>
                {
                    new SearchFieldDef<DTOAccount, int>(i => i.AccountId, DBModel.Account.FieldNames.ACCRECNO, FieldType.Integer),
                    new SearchFieldDef<DTOAccount, DTOAccountType>(i => i.Type, DBModel.AccClass.FieldNames.CLAACCCSTSUP, FieldType.Integer),
                    new SearchFieldDef<DTOAccount, int>(i => i.Id, DBModel.AccClass.FieldNames.CLARECNO, FieldType.Integer),
                    new SearchFieldDef<DTOAccount, int>(i => i.AcsSalOffNo, AccountToSalesOffice.FieldNames.ACSSALOFFNO, FieldType.Integer)
                }
            )
        {
        }

        protected override List<DTOAccount> GetDataInternal(List<ISearchField> searchFields, CachingStrategy allowFromCache, uint? topRows)
        {
            string rawQuery = _sqlQuery;
            if (CheckSearchFieldExistsInSearchCriteria<DTOAccount, int>(searchFields, i => i.AcsSalOffNo))
            {
                rawQuery = rawQuery + _sqlAccountToSakesOfficeFilter;
            }
            string query = ConstructQuery(rawQuery, searchFields, null, true, topRows);

            return LoadAccountList(UnitOfWorkCurrent, query);
        }

        public static List<DTOAccount> LoadAccountList(IUnitOfWork unitOfWorkCurrent, string query)
        {
            var data = new List<DTOAccount>();
            IEnumerable<AccountDataLine> results;
            try
            {
                results = unitOfWorkCurrent.Query<AccountDataLine>(query);
            }
            catch (Exception ex)
            {
                throw new DatabaseQueryException("Could not load Accounts" + Environment.NewLine + ex.Message, ex);
            }

            foreach (var account in results)
            {
                if (!account.Accrecno.HasValue)
                {
                    throw new FreshTradeException("ACCRECNO cannot be null");
                }
                data.Add
                    (
                        new DTOAccount
                        {
                            Id = account.Clarecno,
                            AccountId = account.Accrecno.Value,
                            Code = account.Acccode.TrimEnd(), //Trim to avoid empty spaces at the end of account code 
                            Name = account.Accname.TrimEnd(),
                            Address1 = account.Accaddress1,
                            Address2 = account.Accaddress2,
                            Address3 = account.Accaddress3,
                            Address4 = account.Accaddress4,
                            PostCode = account.Accpostcode,
                            Telephone = account.Acctelno,
                            Fax = account.Accfaxno,
                            Vat = account.Accvatno,
                            Type = Enums<DTOAccountType>.GetValue(account.Claacccstsup),
                            StockHoldLocation = account.Accpalwizstcloc,
                            InvoicePeriod = account.Accarinvoiceperiod,
                            InvoiceType = Enums<DTOInvoiceType>.GetValue(account.Accarinvoicetype),
                            AccountBelongsToCompanyNo = account.Acccomprecno,
                            UseDeliveryDateAsInvoiceDate = account.Setdlvdateasinvdate == 1,
                            HeadOfficeId = account.Acchofrecno,
                            PartPricedInvoicesAllowed = account.Accallpartprcinv == 1,
                            GLType = account.Accglanl,
                            PODRequired = account.Accarpodreq == 1,
                            CountryNo = account.Acccountryno,
                            CustomerVatType = account.Cstvattype,
                            AccArAutoAllocCdts = account.Accarautoalloccdts,
                            IsTwoVatRatesCustomer = (account.Accapply2vatssales ?? 0) > 0,
                            ANANumber = account.Accananumber,
                            IsApplyCompaundVatSale =
                                account.Accapplycompvatsale.HasValue && account.Accapplycompvatsale.Value == 1,
                            AccLanguage = account.Acclanguage
                        }
                    );
            }

            return data;
        }

        public List<DTOAccount> GetAccountByAccClassIDs(List<int> ids)
        {
            return GetDataInChunks(i => i.Id, ids);
        }

        private string BuildGetLocalAccountsQuery(int salesOfficeNo, List<int> accountClassIds)
        {
            var sb = new StringBuilder();
            sb.AppendLine(string.Format("SELECT T.A as CLARECNO, {0}(T.A, {1}) CLAACCCODE", _sqlFuncName_LocalAccount, salesOfficeNo));
            sb.AppendLine("FROM (");
            bool first = true;
            foreach (var accountClassId in accountClassIds)
            {
                if (!first)
                {
                    sb.Append("UNION ALL ");
                }
                sb.Append("SELECT ");
                sb.Append(accountClassId.ToString());
                sb.AppendLine(" as A FROM DUAL");
                first = false;
            }
            sb.Append(") T");
            return sb.ToString();
        }

        public Dictionary<int, string> GetLocalAccounts(int salesOfficeNo, DTOAccountType? accountType, CachingStrategy strategy)
        {
            var searchFields =
                new List<ISearchField>
                    {
                        new SearchFieldGeneric<DTOAccount, int>(i => i.AcsSalOffNo).Apply(salesOfficeNo, FieldType.Integer)
                    };
            if (accountType.HasValue)
            {
                searchFields.Add(new SearchFieldGeneric<DTOAccount, DTOAccountType>(i => i.Type).Apply(accountType, FieldType.Integer));
            }

            string cacheKey = null;
            List<LocalAccountsResultLine> result = null;
            if (strategy != CachingStrategy.NoCache)
            {
                result = GetFromCacheInternal<LocalAccountsResultLine>(searchFields, strategy, out cacheKey);
            }
            if (result == null)
            {
                var sqlQuery = ConstructSimpleQuery(_sqlLocalAccountBySalOffAccountType, searchFields, true, null);
                result = UnitOfWorkCurrent.Query<LocalAccountsResultLine>(sqlQuery).ToList();
                if (strategy != CachingStrategy.NoCache)
                {
                    PutInCacheInternal(cacheKey, strategy, result);
                }
            }

            return result.ToDictionary(i => i.Clarecno, i => i.Claacccode);
        }

        public Dictionary<int, string> GetLocalAccounts(int salesOfficeNo, List<int> accountClassIds)
        {
            var results = GetDataInChunksCustom
                (
                    i =>
                    UnitOfWorkCurrent.Query<LocalAccountsResultLine>
                    (
                        BuildGetLocalAccountsQuery(salesOfficeNo, i)
                    ).ToList(),
                    accountClassIds
                );

            return results.ToDictionary(i => i.Clarecno, i => i.Claacccode);
        }

        public class LocalAccountsResultLine
        {
            public int Clarecno { get; set; }
            public string Claacccode { get; set; }
        }

        public class AccountDataLine : DBModel.Account
        {
            public int Clarecno { get; set; }
            public int Claacccstsup { get; set; }
        }



        /*
        private AccountCategoryType ConvertAccountCategoryTypeEnum(decimal accountCategory)
        {
            AccountCategoryType accountCategoryType;

            int accountCategoryInt = Convert.ToInt32(accountCategory);

            switch (accountCategoryInt)
            {
                case 1:
                    accountCategoryType = AccountCategoryType.Expense;
                    break;

                case 2:
                    accountCategoryType = AccountCategoryType.Charges;
                    break;

                case 3:
                    accountCategoryType = AccountCategoryType.HaulierCharges;
                    break;

                case 4:
                    accountCategoryType = AccountCategoryType.HaulierOnly;
                    break;

                case 5:
                    accountCategoryType = AccountCategoryType.GoodsInvoice;
                    break;

                case 6:
                    accountCategoryType = AccountCategoryType.GoodsAgreedAfter;
                    break;

                case 7:
                    accountCategoryType = AccountCategoryType.NettReturn;
                    break;

                case 8:
                    accountCategoryType = AccountCategoryType.AccountSale;
                    break;

                case 9:
                    accountCategoryType = AccountCategoryType.ThirdParty;
                    break;

                case 10:
                    accountCategoryType = AccountCategoryType.AdvancePayment;
                    break;

                case 11:
                    accountCategoryType = AccountCategoryType.SelfInvoice;
                    break;

                default:
                    accountCategoryType = AccountCategoryType.NotApplicableCustomer;
                    break;
            }

            return accountCategoryType;
        }


*/
    }
}
