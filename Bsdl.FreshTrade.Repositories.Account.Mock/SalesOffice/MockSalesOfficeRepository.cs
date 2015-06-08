using System;
using System.Collections.Generic;
using System.Linq;
using Bsdl.FreshTrade.Domain.Account.Entities;
using Bsdl.FreshTrade.Domain.Account.Interfaces;
using Bsdl.FreshTrade.Domain.Basic.Interfaces;
using Bsdl.FreshTrade.Repositories.Account.Interfaces;
using Bsdl.FreshTrade.Repositories.Basic.Interfaces;

namespace Bsdl.FreshTrade.Repositories.Account.Mock.SalesOffice
{
    public class MockSalesOfficeRepository : ISalesOfficeRepository
    {
        public long ReserveSequenceRangeInternal(int? keyNumber = 1)
        {
            throw new NotImplementedException();
        }

        public List<DTOSalesOffice> GetData(List<ISearchField> searchFields, CachingStrategy allowFromCache, bool forceRefresh = false, uint? topRows = null)
        {
            var salesOfficeList = new List<DTOSalesOffice>();

            salesOfficeList.Add(
              new Bsdl.FreshTrade.Domain.Account.Entities.DTOSalesOffice()
            {
                SalesOfficeNumber = 1,
                SalesOfficeCode = "TO1", 
                SalesOfficeDescription = "Test Office 1",
                LastPreInvUpdateOK = true
                
                //, 1, 001, 002, 003, 004, "Jo Bloggs Trading", 
                //"52 JB Street", string.Empty, string.Empty, string.Empty, "010 345 2918", "0101 1010 0101", "0202 2020 0202", "0303 3030 0303", 0,
                //false, false, false, false
            });

            salesOfficeList.Add(
              new Bsdl.FreshTrade.Domain.Account.Entities.DTOSalesOffice()
              {
                  SalesOfficeNumber = 1,
                  SalesOfficeCode = "TR1",
                  SalesOfficeDescription = "3rd place of work",
                  LastPreInvUpdateOK = true

/*            salesOfficeList.SalesOffices.Add(new Bsdl.FreshTrade.Domain.Account.Entities.SalesOffice(3, "3rd place of work", "SO1", 1, 010, 020, 030, 040, "Bob Cherunkle",
                "123 Alphabet Lane", string.Empty, string.Empty, string.Empty, "010 345 2918", "0101 1010 0101", "0202 2020 0202", "0303 3030 0303", 0,
                false, false, true, false)); */
              });
            salesOfficeList.Add(
              new Bsdl.FreshTrade.Domain.Account.Entities.DTOSalesOffice()
              {
                  SalesOfficeNumber = 2,
                  SalesOfficeCode = "SO1",
                  SalesOfficeDescription = "2nd Sample Premesis",
                  LastPreInvUpdateOK = true

            /*salesOfficeList.SalesOffices.Add(new Bsdl.FreshTrade.Domain.Account.Entities.SalesOffice(2, "2nd Sample Premesis", "SO1", 1, 010, 020, 030, 040, "Bob Cherunkle",
                "123 Alphabet Lane", string.Empty, string.Empty, string.Empty, "010 345 2918", "0101 1010 0101", "0202 2020 0202", "0303 3030 0303", 0,
                true, true, true, false));*/
              });

            return salesOfficeList;
        }

        public DTOSalesOffice Add(DTOSalesOffice entity)
        {
            throw new NotImplementedException();
        }

        public void Add(ICollection<DTOSalesOffice> entities)
        {
            throw new NotImplementedException();
        }

        public int Update(DTOSalesOffice entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(DTOSalesOffice entity)
        {
            throw new NotImplementedException();
        }

        public void Debug(string hint)
        {
            throw new NotImplementedException();
        }


        public List<DTOSalesOffice> GetDataForFreshTradeUser(int userDbID, System.Collections.Generic.List<Domain.Basic.Interfaces.ISearchField> searchFields)
        {
            throw new NotImplementedException();
        }

        public DTOSalesOffice GetSalesOfficeByNo(int salOffNo)
        {
            return GetData(null, CachingStrategy.GlobalCache, false, null).FirstOrDefault();
        }

        public DTOSalesOffice GetSalesOfficeByNo(int salOffNo, bool forceRefresh = false)
        {
            throw new NotImplementedException();
        }


        public int Update(DTOSalesOffice oldItem, DTOSalesOffice newItem, ICollection<IFieldNameRef> nonKeyFieldsForWhereClause = null)
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


        public void Update(ICollection<Domain.Basic.Utilities.UpdatePair<DTOSalesOffice>> items)
        {
            throw new NotImplementedException();
        }


        public void Delete(ICollection<DTOSalesOffice> items)
        {
            throw new NotImplementedException();
        }
    }
}
