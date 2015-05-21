namespace Bsdl.FreshTrade.Core.SalesOffices.Tests
{
    using Bsdl.FreshTrade.Base.Core.Entities;
    using Bsdl.FreshTrade.Base.Core.Enums;
    using Bsdl.FreshTrade.Core.SalesOffices.Interfaces;
    using Bsdl.FreshTrade.Core.SalesOffices.DataAccess.Interfaces;          
    using Bsdl.FreshTrade.Core.SalesOffices.DataAccess.Oracle;    

    using NUnit.Framework;

    [TestFixture]
    public class SalesOfficeRepositoryTests
    {
        private ISalesOfficeService service = new DapperSalesOfficeService(); 

        [Test]
        public void SalesOfficeGetDataTestReturnAll()
        {
            ISalesOfficeList salesOfficeList = this.service.GetData();

            Assert.IsTrue(salesOfficeList.SalesOffices.Count > 0);
        }

        

 [Test]
        public void SalesOfficeGetDataForFreshTradeUser()
        {
            ISearchField searchField = new SearchFieldGeneric("LogOn Name", "LOGTOSALOFF.LOGONNO");

            searchField.Apply(-1, SearchType.intSearchType);
            this.service.AddSearchField(searchField);

            ISalesOfficeList salesOfficeList = this.service.GetDataForFreshTradeUser();
            
            Assert.IsTrue(salesOfficeList.SalesOffices.Count == 0);

            

            // should test that this will return an error when we put in proper error handling
            //service.ClearSearchFields();
            // salesOfficeList = service.GetDataForFreshTradeUser();
            //Assert.IsTrue(salesOfficeList.SalesOffices.Count == 0);



            searchField.Apply(-32000, SearchType.intSearchType);
            this.service.AddSearchField(searchField);

            salesOfficeList = this.service.GetDataForFreshTradeUser();
            Assert.IsTrue(salesOfficeList.SalesOffices.Count > 0);

        }

    }
}
