using System;
using System.Collections.Generic;
using System.Diagnostics;
using Bsdl.FreshTrade.Domain.Basic.Entities;
using Bsdl.FreshTrade.Domain.Basic.Enums;
using Bsdl.FreshTrade.Domain.Basic.Exceptions.DataAccess;
using Bsdl.FreshTrade.Domain.Basic.Interfaces;
using Bsdl.FreshTrade.Domain.Basic.Utilities.DataTypeHandling;
using Bsdl.FreshTrade.Domain.PreInv.Entities;
using Bsdl.FreshTrade.Domain.PreInv.Enums;
using Bsdl.FreshTrade.Repositories.Basic;
using Bsdl.FreshTrade.Repositories.Basic.DBModel;
using Bsdl.FreshTrade.Repositories.Basic.Interfaces;
using Bsdl.FreshTrade.Repositories.Basic.Persistance;
using Bsdl.FreshTrade.Repositories.Basic.Utilities.Interfaces;
using Bsdl.FreshTrade.Repositories.PreInv.DBModel;
using Bsdl.FreshTrade.Repositories.PreInv.Interfaces;

namespace Bsdl.FreshTrade.Repositories.PreInv.DestinationRep
{
    public class IteChgRepository : DapperRepositoryBase<DTOIteChg>, IIteChgRepository
    {
        private const string _sqlQuery = @"SELECT * FROM ITECHG";

        public IteChgRepository(IUnitOfWork unitOfWorkCurrent, ICacheManagerFactory cacheManagerFactory)
            : base
            (
                unitOfWorkCurrent,
                cacheManagerFactory,
                new List<ISearchFieldDef>
                {
                    new SearchFieldDef<DTOIteChg, int?>(i => i.DprRecNo, IteChg.FieldNames.DPRRECNO, FieldType.Integer),
                    new SearchFieldDef<DTOIteChg, int?>(i => i.CtyNo, IteChg.FieldNames.CTYNO, FieldType.Integer)
                }
            )
        {
        }


        public override IList<EntityPropDef> GetTableFieldsDefs()
        {
            return IteChg.GetPropDefs();
        }

        public override string GetTableName()
        {
            return "ITECHG";
        }

        public override IBaseModel ToDbModel(DTOIteChg item)
        {
            var result = new IteChg();
            result.Ichrecno = item.IchRecNo;
            result.Acsale = item.Acsale;
            result.Ctyno = item.CtyNo;
            result.Delrecno = item.Delrecno;
            result.Dprrecno = item.DprRecNo;
            result.Excrecno = item.ExcRecNo;
            result.Ichacrrecno = item.IchAcrRecNo;
            result.Ichappamt = item.IchAppAmt;
            result.Ichappfac = item.IchAppFac;
            result.Ichappmult = item.Ichappmult;
            result.Ichauthamm = item.IchAuthAmm;
            result.Ichchacalc = item.IchChaCalc;
            result.Ichchgfor = item.Ichchgfor;
            result.Ichchngdbyuser = item.Ichchngdbyuser;
            result.Ichcostamt = item.Ichcostamt;
            result.Ichdistype = item.IchDisType;
            result.Ichisanauto = item.Ichisanauto;
            result.Ichistrecno = item.Ichistrecno;
            result.Ichonpayment = item.IchOnPayment?(short)1:(short)0;
            result.Ichorgappamt = item.Ichorgappamt;
            result.Ichpackmistrecno = item.Ichpackmistrecno;
            result.Ichpcntorrate = item.IchPcntOrRate;
            result.Ichrawappamt = item.Ichrawappamt;
            result.Ichrawauthamm = item.Ichrawauthamm;
            result.Ichrealdistype = (int)item.IchRealDisType;
            result.Ichretno = item.Ichretno;
            result.Ichspeto = item.Ichspeto;
            result.Litrecno = item.Litrecno;
            result.Pmorddetrecno = item.Pmorddetrecno;
            result.Rebdislitrecno = item.Rebdislitrecno;
            result.Tbcpostrecno = item.Tbcpostrecno;
            return result;
        }

        protected override List<DTOIteChg> GetDataInternal(List<ISearchField> searchFields, CachingStrategy allowFromCache, uint? topRows)
        {
            string query = ConstructSimpleQuery(_sqlQuery, searchFields, true, topRows);

            var data = new List<DTOIteChg>();

            IEnumerable<IteChg> results = null;

            try
            {
                results = UnitOfWorkCurrent.Query<IteChg>(query);
            }
            catch (Exception ex)
            {
                throw new DatabaseQueryException("Could not load IteChg" + Environment.NewLine + ex.Message, ex);
            }

            if (results != null)
            {
                foreach (var item in results)
                {
                    //Debug.Assert(item.Ichrealdistype != null, "item.Ichrealdistype != null");
                    data.Add
                        (
                            new DTOIteChg
                            {
                                IchRecNo = item.Ichrecno,
                                Acsale = item.Acsale,
                                CtyNo = item.Ctyno,
                                Delrecno = item.Delrecno,
                                DprRecNo = item.Dprrecno,
                                ExcRecNo = item.Excrecno,
                                IchAcrRecNo = item.Ichacrrecno,
                                IchAppAmt = item.Ichappamt ?? 0,
                                IchAppFac = item.Ichappfac,
                                Ichappmult = item.Ichappmult,
                                IchAuthAmm = item.Ichauthamm ?? 0,
                                IchChaCalc = item.Ichchacalc,
                                Ichchgfor = item.Ichchgfor,
                                Ichchngdbyuser = item.Ichchngdbyuser,
                                Ichcostamt = item.Ichcostamt ?? 0,
                                IchDisType = item.Ichdistype,
                                Ichisanauto = item.Ichisanauto,
                                Ichistrecno = item.Ichistrecno,
                                IchOnPayment = (item.Ichonpayment??0) > 0,
                                Ichorgappamt = item.Ichorgappamt ?? 0,
                                Ichpackmistrecno = item.Ichpackmistrecno,
                                IchPcntOrRate = item.Ichpcntorrate ?? 0,
                                Ichrawappamt = item.Ichrawappamt ?? 0,
                                Ichrawauthamm = item.Ichrawauthamm ?? 0,
                                IchRealDisType = item.Ichrealdistype.HasValue?Enums<EnumDiscTypes>.GetValue(item.Ichrealdistype.Value):(EnumDiscTypes?)null,
                                Ichretno = item.Ichretno,
                                Ichspeto = item.Ichspeto,
                                Litrecno = item.Litrecno,
                                Pmorddetrecno = item.Pmorddetrecno,
                                Rebdislitrecno = item.Rebdislitrecno,
                                Tbcpostrecno = item.Tbcpostrecno
                            }
                        );
                }
            }

            return data;
        }

        protected override long ReserveSequenceRangeInternal(int? keyNumber = 1)
        {
            return UnitOfWorkCurrent.GetNextIdentity("ContIchNo", keyNumber ?? 1);
        }

        public List<DTOIteChg> GetItemChargeByDeliveryPriceIds(List<int> deliveryPriceIds)
        {
            return GetDataInChunks(i => i.DprRecNo, deliveryPriceIds);
        }

        
    }
}
