using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bsdl.FreshTrade.Domain.Account.Entities;
using Bsdl.FreshTrade.Domain.Basic.Enums;
using Bsdl.FreshTrade.Domain.Basic.Exceptions.DataAccess;
using Bsdl.FreshTrade.Domain.Basic.Interfaces;
using Bsdl.FreshTrade.Domain.PreInv.Entities;
using Bsdl.FreshTrade.Repositories.Basic;
using Bsdl.FreshTrade.Repositories.Basic.DBModel;
using Bsdl.FreshTrade.Repositories.Basic.Interfaces;
using Bsdl.FreshTrade.Repositories.Basic.Persistance;
using Bsdl.FreshTrade.Repositories.Basic.Utilities.Interfaces;
using Bsdl.FreshTrade.Repositories.PreInv.DBModel;
using Bsdl.FreshTrade.Repositories.PreInv.Interfaces;

namespace Bsdl.FreshTrade.Repositories.PreInv.HeadOfficeRep
{
    public class HeadOfficeRepository : DapperRepositoryBase<DTOHeadOffice>, IHeadOfficeRepository
    {
        private const string _sqlQuery = @"SELECT * FROM HOFCST";

        public HeadOfficeRepository(IUnitOfWork unitOfWorkCurrent, ICacheManagerFactory cacheManagerFactory)
            : base
            (
                unitOfWorkCurrent, 
                cacheManagerFactory,
                new List<ISearchFieldDef>
                {
                    /*new SearchFieldDef<DTOHeadOffice, int>(i => i.Id, HOFCST.FieldNames.HOFRECNO, FieldType.Integer),
                    new SearchFieldDef<DTOHeadOffice, int>(i => i.CurrencyNo, HOFCST.FieldNames.CURRENCYCODE, FieldType.Integer),
                    new SearchFieldDef<DTOHeadOffice, int>(i => i.SalesOfficeNo, HOFCST.FieldNames.SALOFFNO, FieldType.Integer)*/
                }
            )
        {
        }

        public override IList<EntityPropDef> GetTableFieldsDefs()
        {
            return HOFCST.GetPropDefs();
        }

        public override string GetTableName()
        {
            return "HOFCST";
        }

        public override IBaseModel ToDbModel(DTOHeadOffice item)
        {
            var result = new HOFCST();
            result.Hofrecno = item.Id;
            result.Currencycode = item.CurrencyNo;
            result.Saloffno = item.SalesOfficeNo;
            result.Hofinvtocstcode= item.HeadOfficeAccountClassId;
            return result;
        }


        protected override List<DTOHeadOffice> GetDataInternal(List<ISearchField> searchFields, CachingStrategy allowFromCache, uint? topRows)
        {
            string query = ConstructSimpleQuery(_sqlQuery, searchFields, true, topRows);

            IEnumerable<HOFCST> results = null;

            try
            {
                results = UnitOfWorkCurrent.Query<HOFCST>(query);
            }
            catch (Exception ex)
            {
                throw new DatabaseQueryException("Could not load HOFCST" + Environment.NewLine + ex.Message, ex);
            }

            return results
                .Select(item => 
                    new DTOHeadOffice
                        {
                            Id = item.Hofrecno, 
                            CurrencyNo = item.Currencycode, 
                            SalesOfficeNo = item.Saloffno,
                            InvoiceSalesOfficeNo = item.Invsaloffno,
                            HeadOfficeAccountClassId = item.Hofinvtocstcode
                        })
                .ToList();
        }

    }
}
