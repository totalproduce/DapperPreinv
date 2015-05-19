using System;
using System.Collections.Generic;
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

namespace Bsdl.FreshTrade.Repositories.PreInv.DestinationRep
{
    public class AccTrnFilRepository : DapperRepositoryBase<DTOAccTrnFil>, IAccTrnFilRepository
    {
        private const string _sqlQuery = @"SELECT * FROM ACCTRNFIL";

        public AccTrnFilRepository(IUnitOfWork unitOfWorkCurrent, ICacheManagerFactory cacheManagerFactory)
            : base
            (
                unitOfWorkCurrent,
                cacheManagerFactory,
                new List<ISearchFieldDef>
                {
                        new SearchFieldDef<DTOAccTrnFil, int>(i => i.AtrRecNo, AccTrnFil.FieldNames.ATRRECNO, FieldType.Integer)
                }
            )
        {
        }


        public override IList<EntityPropDef> GetTableFieldsDefs()
        {
            return AccTrnFil.GetPropDefs();
        }

        public override string GetTableName()
        {
            return "ACCTRNFIL";
        }

        public override IBaseModel ToDbModel(DTOAccTrnFil item)
        {
            var result = new AccTrnFil();
            result.Atrrecno = item.AtrRecNo;
            result.Atr1099type = item.Atr1099type;
            result.Atractpstdate = item.Atractpstdate;
            result.Atractpstlogon = item.Atractpstlogon;
            result.Atramount = item.AtrAmount;
            result.Atramountwhval = item.Atramountwhval;
            result.Atrauthbyno = item.Atrauthbyno;
            result.Atrbalance = item.AtrBalance;
            result.Atrbalatlststmt = item.Atrbalatlststmt;
            result.Atrbaseamount = item.AtrBaseAmount;
            result.Atrbaserate = item.AtrBaseRate;
            result.Atrclarecno = item.Atrclarecno;
            result.Atrclass = item.Atrclass;
            result.Atrcoglbrecno = item.AtrCoGlbRecNo;
            result.Atrcurrecno = item.AtrCurRecNo;
            result.Atrdbno = item.AtrDbNo;
            result.Atrdbtype = item.AtrDbType;
            result.Atrdelclarecno = item.AtrDelClaRecNo;
            result.Atrdispute = item.Atrdispute;
            result.Atreuroamount = item.AtrEuroAmount;
            result.Atreurorate = item.AtrEuroRate;
            result.Atrexclfromexport = item.Atrexclfromexport;
            result.Atrfactorclarec = item.Atrfactorclarec;
            result.Atronpayplan = item.Atronpayplan;
            result.Atrourrefno = item.Atrourrefno;
            result.Atrperiodno = item.Atrperiodno;
            result.Atrprdorpan = item.Atrprdorpan;
            result.Atrpstdate = item.AtrPstDate;
            result.Atrpstdatedchq = item.Atrpstdatedchq;
            result.Atrpstdchqentdate = item.Atrpstdchqentdate;
            result.Atrpsttyp = item.AtrPstTyp;
            result.Atrpurauthbatrec = item.Atrpurauthbatrec;
            result.Atrref = item.Atrref;
            result.Atrref2 = item.AtrRef2;
            result.Atrsaloffno = item.AtrSalOffNo;
            result.Atrstatind = item.AtrStatInd;
            result.Atrtoauthno = item.Atrtoauthno;
            result.Atrtopayamt = item.Atrtopayamt;
            result.Atrtopaydate = item.Atrtopaydate;
            result.Atrtriangulate = item.AtrTriangulate;
            result.Atrwhtaxamount = item.Atrwhtaxamount;
            result.Atrwithholdtax = item.Atrwithholdtax;
            result.Atrwithholdtaxrate = item.Atrwithholdtaxrate;
            result.Atryearno = item.Atryearno;
            result.Clrddate = item.Clrddate;
            result.Intcomptrn = item.Intcomptrn;
            result.Invexchrate = item.Invexchrate;
            result.Onholdby = item.Onholdby;
            result.Onholddate = item.Onholddate;
            result.Paymentagentprinted = item.Paymentagentprinted;
            return result;
        }

        protected override List<DTOAccTrnFil> GetDataInternal(List<ISearchField> searchFields, CachingStrategy allowFromCache, uint? topRows)
        {
            string query = ConstructSimpleQuery(_sqlQuery, searchFields, true, topRows);

            var data = new List<DTOAccTrnFil>();

            IEnumerable<AccTrnFil> results = null;

            try
            {
                results = UnitOfWorkCurrent.Query<AccTrnFil>(query);
            }
            catch (Exception ex)
            {
                throw new DatabaseQueryException("Could not load AccTrnFil" + Environment.NewLine + ex.Message, ex);
            }

            if (results != null)
            {
                foreach (var item in results)
                {
                    data.Add
                        (
                            new DTOAccTrnFil
                            {
                                AtrRecNo = item.Atrrecno,
                                Atr1099type = item.Atr1099type,
                                Atractpstdate = item.Atractpstdate,
                                Atractpstlogon = item.Atractpstlogon,
                                AtrAmount = item.Atramount ?? 0,
                                Atramountwhval = item.Atramountwhval ?? 0,
                                Atrauthbyno = item.Atrauthbyno,
                                AtrBalance = item.Atrbalance ?? 0,
                                Atrbalatlststmt = item.Atrbalatlststmt ?? 0,
                                AtrBaseAmount = item.Atrbaseamount ?? 0,
                                AtrBaseRate = item.Atrbaserate ?? 0,
                                Atrclarecno = item.Atrclarecno,
                                Atrclass = item.Atrclass,
                                AtrCoGlbRecNo = item.Atrcoglbrecno,
                                AtrCurRecNo = item.Atrcurrecno,
                                AtrDbNo = item.Atrdbno,
                                AtrDbType = item.Atrdbtype,
                                AtrDelClaRecNo = item.Atrdelclarecno,
                                Atrdispute = item.Atrdispute,
                                AtrEuroAmount = item.Atreuroamount ?? 0,
                                AtrEuroRate = item.Atreurorate ?? 0,
                                Atrexclfromexport = item.Atrexclfromexport,
                                Atrfactorclarec = item.Atrfactorclarec,
                                Atronpayplan = item.Atronpayplan,
                                Atrourrefno = item.Atrourrefno,
                                Atrperiodno = item.Atrperiodno,
                                Atrprdorpan = item.Atrprdorpan,
                                AtrPstDate = item.Atrpstdate,
                                Atrpstdatedchq = item.Atrpstdatedchq,
                                Atrpstdchqentdate = item.Atrpstdchqentdate,
                                AtrPstTyp = item.Atrpsttyp,
                                Atrpurauthbatrec = item.Atrpurauthbatrec,
                                Atrref = item.Atrref,
                                AtrRef2 = item.Atrref2,
                                AtrSalOffNo = item.Atrsaloffno,
                                AtrStatInd = item.Atrstatind,
                                Atrtoauthno = item.Atrtoauthno,
                                Atrtopayamt = item.Atrtopayamt ?? 0,
                                Atrtopaydate = item.Atrtopaydate,
                                AtrTriangulate = item.Atrtriangulate,
                                Atrwhtaxamount = item.Atrwhtaxamount ?? 0,
                                Atrwithholdtax = item.Atrwithholdtax,
                                Atrwithholdtaxrate = item.Atrwithholdtaxrate ?? 0,
                                Atryearno = item.Atryearno,
                                Clrddate = item.Clrddate,
                                Intcomptrn = item.Intcomptrn,
                                Invexchrate = item.Invexchrate ?? 0,
                                Onholdby = item.Onholdby,
                                Onholddate = item.Onholddate,
                                Paymentagentprinted = item.Paymentagentprinted,
                            }
                        );
                }
            }

            return data;
        }

        protected override long ReserveSequenceRangeInternal(int? keyNumber = 1)
        {
            return UnitOfWorkCurrent.GetNextIdentity("LstAtrRecNo", keyNumber ?? 1);
        }

        public List<DTOAccTrnFil> GetByAtrRecNos(List<int> atrRecNos)
        {
            return GetDataInChunks(i => i.AtrRecNo, atrRecNos);
        }

    }
}
