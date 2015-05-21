using System;
using System.Collections.Generic;
using System.Linq;
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

namespace Bsdl.FreshTrade.Repositories.PreInv.DestinationRep
{

    public class EdiLogInvoiceRepository : DapperRepositoryBase<DTOEdiLogInvoice>, IEdiLogInvoiceRepository
    {
        private const string _sqlQuery = @"SELECT * FROM EDILOGINVOICE";

        public EdiLogInvoiceRepository(IUnitOfWork unitOfWorkCurrent, ICacheManagerFactory cacheManagerFactory)
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


        public override IList<EntityPropDef> GetTableFieldsDefs()
        {
            return EdiLogInvoice.GetPropDefs();
        }

        public override string GetTableName()
        {
            return "EDILOGINVOICE";
        }

        public override IBaseModel ToDbModel(DTOEdiLogInvoice item)
        {
            var result = new EdiLogInvoice();
            result.Eiinvoiceid = item.Eiinvoiceid;
            result.Eiatrrecno = item.Eiatrrecno;
            result.Eiheadid = item.Eiheadid;
            result.Eitotaldiscount = item.Eitotaldiscount;
            result.Eitotalgoods = item.Eitotalgoods;
            result.Eitotalinvoiced = item.Eitotalinvoiced;
            result.Eitotalvat = item.Eitotalvat;
            return result;
        }

        protected override List<DTOEdiLogInvoice> GetDataInternal(List<ISearchField> searchFields, CachingStrategy allowFromCache, uint? topRows)
        {
            string query = ConstructSimpleQuery(_sqlQuery, searchFields, true, topRows);

            var data = new List<DTOEdiLogInvoice>();

            IEnumerable<EdiLogInvoice> results = null;

            try
            {
                results = UnitOfWorkCurrent.Query<EdiLogInvoice>(query);
            }
            catch (Exception ex)
            {
                throw new DatabaseQueryException("Could not load EDILOGINVOICE" + Environment.NewLine + ex.Message, ex);
            }

            if (results != null)
            {
                foreach (var item in results)
                {
                    data.Add
                        (
                            new DTOEdiLogInvoice
                            {
                                Eiinvoiceid = item.Eiinvoiceid,
                                Eiatrrecno = item.Eiatrrecno,
                                Eiheadid = item.Eiheadid,
                                Eitotaldiscount = item.Eitotaldiscount ?? 0,
                                Eitotalgoods = item.Eitotalgoods ?? 0,
                                Eitotalinvoiced = item.Eitotalinvoiced ?? 0,
                                Eitotalvat = item.Eitotalvat ?? 0
                            }
                        );
                }
            }

            return data;
        }

        public IEnumerable<DTOEdiLogHeaderWide> GetEdiLogHeaderWideRecordsByInvoiceIds(List<int> invoiceIDs)
        {
            string sql = "SELECT EdiLogHeader.*, EdiLogInvoice.* FROM EdiLogInvoice, EdiLogHeader "
                         + "WHERE EdiLogHeader.EHHeadID = EdiLogInvoice.EIHeadID AND EdiLogInvoice.EIInvoiceID in ({0})";
            return GetDataInChunksCustom
                          (
                              i =>
                              UnitOfWorkCurrent.Query<DTOEdiLogHeaderWide>
                              (
                                String.Format(sql, string.Join(",", i.Select(k => k.ToString()).ToArray()))
                              ).ToList(),
                              invoiceIDs
                          );
        }
    }

}
