using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Bsdl.FreshTrade.Domain.Basic.Utilities.DataTypeHandling;
using Bsdl.FreshTrade.Domain.PreInv.Enums;
using Bsdl.FreshTrade.Domain.PreInv.Interfaces;

namespace Bsdl.FreshTrade.Domain.PreInv.Entities
{
    [DataContract]
    public class DTOInvTot : IDTOInvTot, IDeepClonableDTO<DTOInvTot>
    {

        public DTOInvTot()
        {
            VatInfo = new Dictionary<int, DTOInvTotVatInfo>();
        }
        
        
        #region New impementation properties
        public string MemStorageKey { get; set; }
        #endregion

        [DataMember]
        public int ExtractSessionID { get; set; }

        [DataMember]              
        public int? AccGlAnl {get;set;}

    
       [DataMember]              
        public int? AccntSalOffNo {get;set;}

        
       [DataMember]              
        public decimal BaseGdsTotal {get;set;}

    
       [DataMember]              
        public decimal Basehandcommamt {get;set;}

    
       [DataMember]              
        public decimal BaseOffInvOnPay {get;set;}

    
       [DataMember]              
        public decimal BaseOffInvRbt {get;set;}

    
       [DataMember]              
        public decimal BaseOnInvDscnt {get;set;}

    
       [DataMember]              
        public decimal BaseRate {get;set;}
    
       [DataMember]              
        public decimal BaseVat1Total {get;set;}
    
       [DataMember]              
        public decimal BaseVat2Total {get;set;}
    
       [DataMember]              
        public decimal BaseVatOnChgs {get;set;}

    
       [DataMember]              
        public decimal BaseVatTotal {get;set;}

    
       [DataMember]              
        public bool CancelledInv {get;set;}
    
       [DataMember]              
        public string CompanyName {get;set;}

    
       [DataMember]              
        public bool CompoundVatCust {get;set;}

    
       [DataMember]              
        public string CurDesc {get;set;}

    
       [DataMember]              
        public int? CurNo {get;set;}

    
       [DataMember]              
        public int? EIInvoiceId {get;set;}

    
       [DataMember]              
        public decimal EuroGdsTotal {get;set;}

    
       [DataMember]              
        public decimal Eurohandcommamt {get;set;}

    
       [DataMember]              
        public decimal EuroOffInvOnPay {get;set;}

    
       [DataMember]              
        public decimal EuroOffInvRbt {get;set;}

    
       [DataMember]              
        public decimal EuroOnInvDscnt {get;set;}

    
       [DataMember]              
        public decimal EuroRate {get;set;}

     
       [DataMember]              
        public decimal EuroVat1Total {get;set;}

    
       [DataMember]              
        public decimal EuroVat2Total {get;set;}

    
       [DataMember]              
        public decimal EuroVatOnChgs {get;set;}

    
       [DataMember]              
        public decimal EuroVatTotal {get;set;}

    
       [DataMember]              
        public short? Finfiscrep1 {get;set;}

    
       [DataMember]              
        public string Finvatdesc1 {get;set;}

    
       [DataMember]              
        public string Finvatnumber1 {get;set;}

    
       [DataMember]              
        public decimal GoodsTotal {get;set;}

    
       [DataMember]              
        public int? HofClaRecNo {get;set;}

    
       [DataMember]              
        public string HofCstCode {get;set;}

    
       [DataMember]              
        public DateTime? InvDate {get;set;}

    
       [DataMember]              
        public string InvoiceNo {get;set;}

    
       [DataMember]              
        public decimal InvoiceTotal {get;set;}

    
       [DataMember]              
        public int? InvRecNo {get;set;}

    
       [DataMember]              
        public bool IsEdiCst {get;set;}

    
       [DataMember]              
        public bool IsInterDept {get;set;}

    
       [DataMember]
       public bool IsSeqInvNo { get; set; }

    
       [DataMember]              
        public decimal OffInvOnPay {get;set;}

    
       [DataMember]              
        public decimal OffInvRbt {get;set;}

    
       [DataMember]              
        public decimal OnInvDscnt {get;set;}

    
       [DataMember]              
        public int? PrcGlbRecNo {get;set;}

    
       [DataMember]              
        public int QtyTotal {get;set;}

    
       [DataMember]              
        public decimal Rawhandcommamt {get;set;}

    
       [DataMember]              
        public decimal RawVatOnChgs {get;set;}

    
       [DataMember]              
        public string Sort1 {get;set;}

    
       [DataMember]              
        public string Sort2 {get;set;}

    
       [DataMember]              
        public string Sort3 {get;set;}

    
       [DataMember]              
        public string StInvTotal {get;set;}

    
       [DataMember]              
        public bool TriangReq {get;set;}

    
       [DataMember]              
        public bool TwoVatRatesCust {get;set;}

    
       [DataMember]              
        public decimal Vat1Total {get;set;}

        
       [DataMember]              
        public decimal Vat2Total {get;set;}

    
       [DataMember]              
        public decimal VatCodeChgs {get;set;}

    
       [DataMember]              
        public decimal VatRateChgs {get;set;}

    
       [DataMember]              
        public decimal VatTotal {get;set;}


        [DataMember]
        public bool WriteAccReChg {get;set;}

        [DataMember]
        public bool Cancel { get; set; }

        [DataMember]
        public Dictionary<int, DTOInvTotVatInfo> VatInfo { get; set; }

        [DataMember]
        public PreInvInvoiceType InvoiceType { get; set; }

        [DataMember]
        public PreInvBatchType BatchType { get; set; }

        [DataMember]
        public string OriginalInvoiceNo { get; set; }

        #region IDeepClonableDTO implementation
        void IDeepClonableDTO<DTOInvTot>.CloneNestedObjects(DTOInvTot source)
        {
            VatInfo = new Dictionary<int, DTOInvTotVatInfo>(source.VatInfo.Count);
            foreach (var vatItem in source.VatInfo)
            {
                VatInfo.Add(vatItem.Key, ObjectHandling.CloneDTO(vatItem.Value));
            }
        }

        void IDeepClonableDTO<DTOInvTot>.CleanNestedObjects()
        {
            VatInfo = new Dictionary<int, DTOInvTotVatInfo>();
        }
        #endregion
    }


}


