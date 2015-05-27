using System.Linq;
using Bsdl.FreshTrade.Domain.Account.Entities;
using Bsdl.FreshTrade.Domain.Account.Interfaces;
using Bsdl.FreshTrade.Domain.Basic.Entities;
using Bsdl.FreshTrade.Domain.Basic.Enums;
using Bsdl.FreshTrade.Domain.Basic.Interfaces;
using Bsdl.FreshTrade.Repositories.Account.Interfaces;
using Bsdl.FreshTrade.Repositories.Basic.Interfaces;
using Bsdl.FreshTrade.Server.Basic.Interfaces;
using Bsdl.FreshTrade.Services.Account.Interfaces;
using Bsdl.FreshTrade.Services.Basic;
using System;
using System.Collections.Generic;

namespace Bsdl.FreshTrade.Services.Account.SalesOffices
{
    public class SalesOfficesService : FreshTradeServiceBase, ISalesOfficesService
    {
        private ISalesOfficeRepository _salesOfficeRepository;
        protected ISalesOfficeRepository SalesOfficeRepository
        {
            get
            {
                if (_salesOfficeRepository == null)
                {
                    _salesOfficeRepository = UnitOfWorkCurrent.GetRepository<ISalesOfficeRepository>();
                }
                return _salesOfficeRepository;
            }
        }

        private IUserToSalesOfficeRepository _userToSalesOfficeRepository;
        protected IUserToSalesOfficeRepository UserToSalesOfficeRepository
        {
            get
            {
                if (_userToSalesOfficeRepository == null)
                {
                    _userToSalesOfficeRepository = UnitOfWorkCurrent.GetRepository<IUserToSalesOfficeRepository>();
                }
                return _userToSalesOfficeRepository;
            }
        }

        /// <summary>
        /// Get a list of the sales offices
        /// </summary>
        
        public SalesOfficesService (IRepositoryFactory repositoryFactory)
            : base(repositoryFactory)
        {
        }

        public List<DTOSalesOffice> GetSalesOffices()
        {
            var salesOfficeList = SalesOfficeRepository.GetData(new List<ISearchField>(), CachingStrategy.GlobalCache);
            var userToSalesOffice = UserToSalesOfficeRepository.GetUserSalesOffices(UserSessionContext.FreshTradeUser.Id, null, true, null);
            if (!userToSalesOffice.Contains(DTOSalesOffice.IncludeAllSalesOfficesNo))
            {
                salesOfficeList = salesOfficeList.Where(i => userToSalesOffice.Contains(i.SalesOfficeNumber)).ToList();;
            }
            return salesOfficeList.OrderBy(i => i.SalesOfficeNumber).ToList();
        }

        /*public ISalesOfficeList GetSalesOfficesByUser(IFreshTradeUser freshTradeUser)
        {
            if (freshTradeUser == null)
            {
                var ex = new Exception("Passed FreshTrade User Object is Null in GetSalesOfficesByUser");
                //AppError.SetError(ex, ex.StackTrace, ErrorType.Fatal);
                throw ex;
            }

            if (freshTradeUser.Id < 1)
            {
                var ex = new Exception("Passed FreshTrade User has an invalid UserId Null in GetSalesOfficesByUser");
                //AppError.SetError(ex, ex.StackTrace, ErrorType.Fatal);
                throw ex;
            }

            ISalesOfficeList salesOfficeList = null;

            if (freshTradeUser.AllSalesOffices == true)
            {
                salesOfficeList = SalesOfficeRepository.GetData(null, false, null);
            }
            else
            {
                ISearchField searchField = new SearchFieldGeneric("LogOn Name", "LOGTOSALOFF.LOGONNO");
                searchField.Apply(freshTradeUser.Id, FieldType.Integer);
                salesOfficeList = SalesOfficeRepository.GetData(new List<ISearchField> { searchField }, true, null);
            }

            if (salesOfficeList == null)
            {
                var ex = new Exception("Retured Sales Office Object is Null in GetSalesOfficesByUser");
                //AppError.SetError(ex, ex.StackTrace, ErrorType.Fatal);
                throw ex;
            }

            if (salesOfficeList.SalesOffices.Count < 1)
            {
                var ex = new Exception("Retured Sales Office Object has no results in GetSalesOfficesByUser");
                //AppError.SetError(ex, ex.StackTrace, ErrorType.Fatal);
                throw ex;
            }

            return salesOfficeList;
        }
        */
    }
}
