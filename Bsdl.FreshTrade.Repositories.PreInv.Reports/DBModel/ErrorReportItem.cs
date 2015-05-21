using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bsdl.FreshTrade.Repositories.PreInv.Reports.DBModel
{
    public class ErrorReportItem
    {
        public int LogRecNo { get; set; }
        public string ErrReason { get; set; }
        public string OrdCstCode { get; set; }
        public string OrdCustOrdNo { get; set; }
        public int DlvOrdNo { get; set; }
        public int ErrIsCritical { get; set; }
        public int ExtractSessionID { get; set; }

        public static class FieldNames
        {
            // ReSharper disable InconsistentNaming
            public const string LOGRECNO = "LOGRECNO";
            public const string ERRREASON = "ERRREASON";
            public const string ORDCSTCODE = "ORDCSTCODE";
            public const string ORDCUSTORDNO = "ORDCUSTORDNO";
            public const string DLVORDNO = "DLVORDNO";
            public const string ERRISCRITICAL = "ERRISCRITICAL";
            public const string EXTRACTSESSIONID = "EXTRACTSESSIONID";
            // ReSharper restore InconsistentNaming
        }

    }
}
