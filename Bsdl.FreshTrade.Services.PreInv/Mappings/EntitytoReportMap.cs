using AutoMapper;
using Bsdl.FreshTrade.Domain.PreInv.Entities;
using Bsdl.FreshTrade.Domain.PreInv.WideObjects;
using Bsdl.FreshTrade.Services.PreInv.Model.Reports;

namespace Bsdl.FreshTrade.Services.PreInv.Mappings
{
    class EntitytoReportMap: Profile
    {

        public override string ProfileName
        {
            get { return GetType().FullName; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<DTOInvExtractHead, PreInvExtractHeader>()
                .ForMember(dest => dest.SalesOfficeId, opt => opt.MapFrom(src => src.SalesOfficeNo));
            Mapper.CreateMap<WideErrorReportItem, PreInvExtractionErrorsItem>()
                .ForMember(dest => dest.Type, opt => opt.MapFrom(src => 
                    new PreInvErrorType
                    {
                        IsCritial = src.ErrIsCritical == 1,
                        Reason = src.ErrReason
                    }))
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.LogRecNo))
                .ForMember(dest => dest.CustomerCode, opt => opt.MapFrom(src => src.OrdCstCode))
                .ForMember(dest => dest.OrderId, opt => opt.MapFrom(src => src.OrdCustOrdNo))
                .ForMember(dest => dest.DeliveryId, opt => opt.MapFrom(src => src.DlvOrdNo == 0 ? (int?)null : src.DlvOrdNo));

            Mapper.CreateMap<WideSummaryReportItem, PreInvTot>();

            Mapper.CreateMap<WideDetailReportItem, PreInvTot>();
            Mapper.CreateMap<WideDetailReportItem, PreInvPrt>();
            Mapper.CreateMap<WideDetailReportItem, PreInvPrt2>()
                .ForMember(dest => dest.DeliveryHead, opt => opt.MapFrom(src => 
                    new DeliveryHead
                    {
                        Id = int.Parse(src.DlvOrdNo)
                    }));
        }

    }
}
