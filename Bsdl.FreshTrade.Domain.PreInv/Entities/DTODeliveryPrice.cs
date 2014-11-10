using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bsdl.FreshTrade.Domain.PreInv.Enums;

namespace Bsdl.FreshTrade.Domain.PreInv.Entities
{
    // DBModel - DelPrice
    public class DTODeliveryPrice
    {
        public int Id { get; set; } //DPRRECNO

        public int? DeliveryDetailId { get; set; } //DprDelRecNo

        public int? Quantity { get; set; } //DelPrcQty

        public decimal WeightInKg { get; set; } //Delprcweight

        public decimal Price { get; set; } //DelPrice

        public decimal PriceWeight { get; set; }//Delprcweight

        public decimal NettValue { get; set; } //Delnettvalue

        public DTODeliveryPriceStatus? DeliveryPriceStatus { get; set; }

        public List<DTODeliveryToItemStock> DeliveryToItemStockRecords { get; set; }

//        public List<DTODeliveryPriceToCreditNote> DeliveryPriceToCreditNoteRecords { get; set; }

        public DTODeliveryPrice CreditNoteOriginalDeliveryPrice { get; set; } // for Credit & Debit Notes

        public List<DTODeliveryToCreditNoteByItemStock> DeliveryToCreditNoteByItemStock { get; set; }

        public List<DTOIteChg> ItemCharges { get; set; }

        public DTOAccVAT AccVAT { get; set; }

        public bool HasRelatedCreditNotes { get; set; } //This is read separately and used for validation only

        public bool FreeOfCharge { get; set; } // Delfreeofchg

        public bool IsPriceAdjustment { get; set; }

        public int? AdjustedBy { get; set; }

        public int? InvoiceId { get; set; }

        public int? VatRecNo { get; set; }
        public decimal VatRate { get; set; }
        public decimal VatRate2 { get; set; }

        public decimal DelToEuroRate {get; set;}
        public decimal DelToBaseRate {get; set;}
        public bool DelTriangulate {get;set;}
        public decimal DelEuroNettVal {get;set;}
        public decimal DelEuroVatValue {get;set;}
        public decimal DelBaseNettVal {get;set;}
        public decimal DelBaseVatValue {get;set;}
        public decimal DelVatValue {get;set;}
        public decimal? DelVatRate {get;set;}
        public int? DelVatRecNo {get;set;}
        public decimal DelVatRate2 {get;set;}
        public int? Delallwkrecno { get; set; }
        public bool Delisguideprice { get; set; }
        public int? Delprccomno { get; set; }
        public decimal Delretailprice { get; set; }
        public DateTime? Dprcreationdate { get; set; }
        public decimal Dprnominalprice { get; set; }
        public short? Dprmanwgtchg { get; set; }
        public bool Dprisprcccdtdbt { get; set; }
        public string Dprpreas { get; set; }
        
        
    }
}
