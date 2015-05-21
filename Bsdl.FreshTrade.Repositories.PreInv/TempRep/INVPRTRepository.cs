using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bsdl.FreshTrade.Domain.Account.Enums;
using Bsdl.FreshTrade.Domain.Basic.Entities;
using Bsdl.FreshTrade.Domain.Basic.Enums;
using Bsdl.FreshTrade.Domain.Basic.Exceptions;
using Bsdl.FreshTrade.Domain.Basic.Exceptions.DataAccess;
using Bsdl.FreshTrade.Domain.Basic.Interfaces;
using Bsdl.FreshTrade.Domain.Basic.Utilities.DataTypeHandling;
using Bsdl.FreshTrade.Domain.PreInv.Entities;
using Bsdl.FreshTrade.Repositories.Basic;
using Bsdl.FreshTrade.Repositories.Basic.DBModel;
using Bsdl.FreshTrade.Repositories.Basic.Interfaces;
using Bsdl.FreshTrade.Repositories.Basic.Persistance;
using Bsdl.FreshTrade.Repositories.Basic.Utilities.Interfaces;
using Bsdl.FreshTrade.Repositories.PreInv.DBModel;
using Bsdl.FreshTrade.Repositories.PreInv.Interfaces;

namespace Bsdl.FreshTrade.Repositories.PreInv.TempRep
{
    public class INVPRTRepository : DapperRepositoryBase<DTOInvPrt>, IINVPRTRepository
    {
        private const string _sqlQuery = @"SELECT * FROM PREINVTEMP_INVPRT";

        private const string _sqlDeleteQuery = @"DELETE FROM PREINVTEMP_INVPRT WHERE EXTRACTSESSIONID = {0}";

        public INVPRTRepository(IUnitOfWork unitOfWorkCurrent, ICacheManagerFactory cacheManagerFactory)
            : base
            (
                unitOfWorkCurrent,
                cacheManagerFactory,
                new List<ISearchFieldDef>
                {
                   new SearchFieldDef<DTOInvPrt, int>(i => i.ExtractSessionID, INVPRT.FieldNames.EXTRACTSESSIONID, FieldType.Integer),
                   new SearchFieldDef<DTOInvPrt, int?>(i => i.OrdRecNo, INVPRT.FieldNames.ORDRECNO, FieldType.Integer),
                   new SearchFieldDef<DTOInvPrt, string>(i => i.DlvInvoiceNo, INVPRT.FieldNames.DLVINVOICENO, FieldType.AlphaNumeric)                   
                }
            )
        {
        }


        public override IList<EntityPropDef> GetTableFieldsDefs()
        {
            return INVPRT.GetPropDefs();
        }

        public override string GetTableName()
        {
            return "PREINVTEMP_INVPRT";
        }

        public override IBaseModel ToDbModel(DTOInvPrt item)
        {
            var result = new INVPRT();
            result.Extractsessionid = item.ExtractSessionID;
            result.Cancelleddlv = (short)(item.CancelledDlv?1:0);
            result.Curdesc = item.CurDesc;
            result.Delclarecno = item.DelClaRecNo;
            result.Dltrecno = item.DltRecNo;
            result.Dlvdeldate = item.DlvDelDate;
            result.Dlvinvoiceno = item.DlvInvoiceNo;
            result.Dlvordno = item.DlvOrdNo;
            result.Dlvpodno = item.DlvPODNo;
            result.Dlvprghedno = item.DlvPrgHedNo;
            result.Dlvsaloffno = item.DlvSalOffNo;
            result.Dlvshpdate = item.DlvShpDate;
            result.Hofclarecno = item.HofClaRecNo;
            result.Hofcstcode = item.HofCstCode;
            result.Invdate = item.InvDate;
            result.Invoicetype = (int)item.InvoiceType;
            result.Isediprg = (short)(item.IsEdiPrg?1:0);
            result.Ordcstcode = item.OrdCstCode;
            result.Ordcustordno = item.OrdCustOrdNo;
            result.Orddate = item.OrdDate;
            result.Ordrecno = item.OrdRecNo;
            result.Ordsmnno = item.OrdSmnNo;
            result.Prcglbrecno = item.PrcGlbRecNo;
            result.Saloffdesc = item.SalOffDesc;
            result.Sort1 = item.Sort1;
            result.Sort2 = item.Sort2;
            result.Vatable = item.Vatable; return result;
        }

        protected override List<DTOInvPrt> GetDataInternal(List<ISearchField> searchFields, CachingStrategy allowFromCache, uint? topRows)
        {
            string query = ConstructSimpleQuery(_sqlQuery, searchFields, true, topRows);

            var data = new List<DTOInvPrt>();

            IEnumerable<INVPRT> results = null;

            try
            {
                results = UnitOfWorkCurrent.Query<INVPRT>(query);
            }
            catch (Exception ex)
            {
                throw new DatabaseQueryException("Could not load PREINVTEMP_INVPRT" + Environment.NewLine + ex.Message, ex);
            }

            if (results != null)
            {
                foreach (var item in results)
                {
                    if (item.Invoicetype == null)
                    {
                        throw new FreshTradeException("DTOInvPrt.Invoicetype cannot be null");
                    }
                    data.Add
                        (
                            new DTOInvPrt
                            {
                                ExtractSessionID = item.Extractsessionid,
                                CancelledDlv = item.Cancelleddlv>0,
                                CurDesc = item.Curdesc,
                                DelClaRecNo = item.Delclarecno,
                                DltRecNo = item.Dltrecno,
                                DlvDelDate = item.Dlvdeldate,
                                DlvInvoiceNo = item.Dlvinvoiceno,
                                DlvOrdNo = item.Dlvordno,
                                DlvPODNo = item.Dlvpodno,
                                DlvPrgHedNo = item.Dlvprghedno,
                                DlvSalOffNo = item.Dlvsaloffno,
                                DlvShpDate = item.Dlvshpdate,
                                HofClaRecNo = item.Hofclarecno,
                                HofCstCode = item.Hofcstcode,
                                InvDate = item.Invdate,
                                InvoiceType = Enums<DTOInvoiceType>.GetValue(item.Invoicetype.Value),
                                IsEdiPrg = item.Isediprg > 0,
                                OrdCstCode = item.Ordcstcode,
                                OrdCustOrdNo = item.Ordcustordno,
                                OrdDate = item.Orddate,
                                OrdRecNo = item.Ordrecno,
                                OrdSmnNo = item.Ordsmnno,
                                PrcGlbRecNo = item.Prcglbrecno,
                                SalOffDesc = item.Saloffdesc,
                                Sort1 = item.Sort1,
                                Sort2 = item.Sort2,
                                Vatable = item.Vatable
                            }
                        );
                }
            }

            return data;
        }

        public List<DTOInvPrt> GetByExtractSessionID(int extractSessionID)
        {
            return GetData(
                    new List<ISearchField> {
                        new SearchFieldGeneric<DTOInvPrt, int>(i => i.ExtractSessionID).Apply(extractSessionID , FieldType.Integer)
                 }, CachingStrategy.NoCache).ToList();
        }

        public void DeleteByExtractSessionID(int extractSessionID)
        {
            string sqlQuery = string.Format(_sqlDeleteQuery, extractSessionID);
            UnitOfWorkCurrent.Execute(sqlQuery);
        }

    }
}
