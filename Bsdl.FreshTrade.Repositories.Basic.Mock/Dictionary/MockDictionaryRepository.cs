using System.Collections.Generic;
using Bsdl.FreshTrade.Domain.Basic.Entities;
using Bsdl.FreshTrade.Domain.Basic.Interfaces;
using Bsdl.FreshTrade.Repositories.Basic.Interfaces;

namespace Bsdl.FreshTrade.Repositories.Basic.Mock.Dictionary
{
    public class MockCurrencyDictionaryRepository : ICurrencyDictionaryRepository
    {
        public long ReserveSequenceRangeInternal(int? keyNumber = 1)
        {
            throw new System.NotImplementedException();
        }

        public List<DTOCurrency> GetData(List<ISearchField> searchFields, CachingStrategy allowFromCache, bool forceRefresh = false, uint? topRows = null)

        {
            var data = new List<DTOCurrency>();
            data.Add(new DTOCurrency { No = 1, Description = "Pounds" });
            data.Add(new DTOCurrency{No = 2, Description = "EURO"});
            data.Add(new DTOCurrency{No = 3, Description = "US Dollars"});
            return data;
        }

        public DTOCurrency Add(DTOCurrency entity)
        {
            throw new System.NotImplementedException();
        }

        public void Add(ICollection<DTOCurrency> entities)
        {
            throw new System.NotImplementedException();
        }

        public int Update(DTOCurrency entity)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(DTOCurrency entity)
        {
            throw new System.NotImplementedException();
        }

        public void Debug(string hint)
        {
            throw new System.NotImplementedException();
        }

        public List<DTOCurrencyRate> GetCurrencyRates()
        {
            throw new System.NotImplementedException();
        }

        public int Update(DTOCurrency oldItem, DTOCurrency newItem, ICollection<IFieldNameRef> nonKeyFieldsForWhereClause = null)
        {
            throw new System.NotImplementedException();
        }

        public long GetNextSequence()
        {
            throw new System.NotImplementedException();
        }

        public void ReserveSequenceRange(int? keyNumber = 1)
        {
            throw new System.NotImplementedException();
        }


        public void Update(ICollection<IFieldNameRef> updateFields, ICollection<IRowUpdateInfo> updateRows)
        {
            throw new System.NotImplementedException();
        }


        public void Update(ICollection<Domain.Basic.Utilities.UpdatePair<DTOCurrency>> items)
        {
            throw new System.NotImplementedException();
        }


        public void Delete(ICollection<DTOCurrency> items)
        {
            throw new System.NotImplementedException();
        }
    }

    public class MockCompanyDictionaryRepository : ICompanyDictionaryRepository
    {
        public long ReserveSequenceRangeInternal(int? keyNumber = 1)
        {
            throw new System.NotImplementedException();
        }

        public List<DTOCompany> GetData(List<ISearchField> searchFields, CachingStrategy allowFromCache, bool forceRefresh = false, uint? topRows = null)
        {
            var data = new List<DTOCompany>();
            data.Add(new DTOCompany(1, "Total Produce Ireland"));
            data.Add(new DTOCompany(90, "Grooms"));
            return data;
        }

        public DTOCompany Add(DTOCompany entity)
        {
            throw new System.NotImplementedException();
        }

        public void Add(ICollection<DTOCompany> entities)
        {
            throw new System.NotImplementedException();
        }

        public int Update(DTOCompany entity)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(DTOCompany entity)
        {
            throw new System.NotImplementedException();
        }

        public void Debug(string hint)
        {
            throw new System.NotImplementedException();
        }

        public int Update(DTOCompany oldItem, DTOCompany newItem, ICollection<IFieldNameRef> nonKeyFieldsForWhereClause = null)
        {
            throw new System.NotImplementedException();
        }

        public long GetNextSequence()
        {
            throw new System.NotImplementedException();
        }

        public void ReserveSequenceRange(int? keyNumber = 1)
        {
            throw new System.NotImplementedException();
        }


        public void Update(ICollection<IFieldNameRef> updateFields, ICollection<IRowUpdateInfo> updateRows)
        {
            throw new System.NotImplementedException();
        }


        public void Update(ICollection<Domain.Basic.Utilities.UpdatePair<DTOCompany>> items)
        {
            throw new System.NotImplementedException();
        }


        public void Delete(ICollection<DTOCompany> items)
        {
            throw new System.NotImplementedException();
        }
    }

}

