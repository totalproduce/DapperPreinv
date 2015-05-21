using System;
using System.Collections.Generic;
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

    public class ExpChaRepository : DapperRepositoryBase<DTOExpCha>, IExpChaRepository
    {
        private const string _sqlQuery = @"SELECT * FROM EXPCHA";

        public ExpChaRepository(IUnitOfWork unitOfWorkCurrent, ICacheManagerFactory cacheManagerFactory)
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
            return ExpCha.GetPropDefs();
        }

        public override string GetTableName()
        {
            return "EXPCHA";
        }

        public override IBaseModel ToDbModel(DTOExpCha item)
        {
            var result = new ExpCha();
            result.Exccharec = item.ExcChaRec;
            result.Closedisputecode = item.Closedisputecode;
            result.Disputecode = item.Disputecode;
            result.Disputestatus = item.Disputestatus;
            result.Dlvdtpdxli = item.Dlvdtpdxli;
            result.Excapptype = item.Excapptype;
            result.Excatrrecno = item.ExcAtrRecNo;
            result.Excauthconamm = item.ExcAuthConAmm;
            result.Excautheuroamm = item.ExcAuthEuroAmm;
            result.Excauthrawamm = item.ExcAuthRawAmm;
            result.Excauthtobaserate = item.Excauthtobaserate;
            result.Excauthtoeuroamm = item.Excauthtoeuroamm;
            result.Excchaperrate = item.Excchaperrate;
            result.Excchgcalc = item.ExcChgCalc;
            result.Excclaimonhold = item.Excclaimonhold;
            result.Excclrdate = item.Excclrdate;
            result.Excconamm = item.ExcConAmm;
            result.Excctyno = item.ExcCtyNo;
            result.Exccurrblkpurch = item.Exccurrblkpurch;
            result.Exccurrno = item.ExcCurrNo;
            result.Excdlvordno = item.Excdlvordno;
            result.Excdutyref = item.Excdutyref;
            result.Exceuroamm = item.ExcEuroAmm;
            result.Excfullyauth = item.ExcFullyAuth;
            result.Exclherecno = item.Exclherecno;
            result.Excpackmporrecno = item.Excpackmporrecno;
            result.Excporrecno = item.Excporrecno;
            result.Excratefixed = item.Excratefixed;
            result.Excrawamm = item.ExcRawAmm;
            result.Excrecovfrompl = item.Excrecovfrompl;
            result.Excretno = item.Excretno;
            result.Excrounddif = item.Excrounddif;
            result.Excrthno = item.Excrthno;
            result.Excrthpono = item.Excrthpono;
            result.Excsaloff = item.Excsaloff;
            result.Excsencode = item.ExcSenCode;
            result.Excsenref = item.Excsenref;
            result.Excspeto = item.Excspeto;
            result.Exctobaserate = item.ExcToBaseRate;
            result.Exctoeuroexcrate = item.ExcToEuroExcRate;
            result.Invexchrate = item.Invexchrate;
            result.Openchargeid = item.Openchargeid;
            result.Triangulated = item.Triangulated ? (short)1 : (short)0;
            return result;
        }

        protected override List<DTOExpCha> GetDataInternal(List<ISearchField> searchFields, CachingStrategy allowFromCache, uint? topRows)
        {
            string query = ConstructSimpleQuery(_sqlQuery, searchFields, true, topRows);

            var data = new List<DTOExpCha>();

            IEnumerable<ExpCha> results = null;

            try
            {
                results = UnitOfWorkCurrent.Query<ExpCha>(query);
            }
            catch (Exception ex)
            {
                throw new DatabaseQueryException("Could not load EXPCHA" + Environment.NewLine + ex.Message, ex);
            }

            if (results != null)
            {
                foreach (var item in results)
                {
                    data.Add
                        (
                            new DTOExpCha
                            {
                                ExcChaRec = item.Exccharec,
                                Closedisputecode = item.Closedisputecode,
                                Disputecode = item.Disputecode,
                                Disputestatus = item.Disputestatus,
                                Dlvdtpdxli = item.Dlvdtpdxli,
                                Excapptype = item.Excapptype,
                                ExcAtrRecNo = item.Excatrrecno,
                                ExcAuthConAmm = item.Excauthconamm ?? 0,
                                ExcAuthEuroAmm = item.Excautheuroamm ?? 0,
                                ExcAuthRawAmm = item.Excauthrawamm ?? 0,
                                Excauthtobaserate = item.Excauthtobaserate ?? 0,
                                Excauthtoeuroamm = item.Excauthtoeuroamm ?? 0,
                                Excchaperrate = item.Excchaperrate ?? 0,
                                ExcChgCalc = item.Excchgcalc,
                                Excclaimonhold = item.Excclaimonhold,
                                Excclrdate = item.Excclrdate,
                                ExcConAmm = item.Excconamm ?? 0,
                                ExcCtyNo = item.Excctyno,
                                Exccurrblkpurch = item.Exccurrblkpurch,
                                ExcCurrNo = item.Exccurrno,
                                Excdlvordno = item.Excdlvordno,
                                Excdutyref = item.Excdutyref,
                                ExcEuroAmm = item.Exceuroamm ?? 0,
                                ExcFullyAuth = item.Excfullyauth,
                                Exclherecno = item.Exclherecno,
                                Excpackmporrecno = item.Excpackmporrecno,
                                Excporrecno = item.Excporrecno,
                                Excratefixed = item.Excratefixed,
                                ExcRawAmm = item.Excrawamm ?? 0,
                                Excrecovfrompl = item.Excrecovfrompl,
                                Excretno = item.Excretno,
                                Excrounddif = item.Excrounddif ?? 0,
                                Excrthno = item.Excrthno,
                                Excrthpono = item.Excrthpono,
                                Excsaloff = item.Excsaloff,
                                ExcSenCode = item.Excsencode,
                                Excsenref = item.Excsenref,
                                Excspeto = item.Excspeto,
                                ExcToBaseRate = item.Exctobaserate ?? 0,
                                ExcToEuroExcRate = item.Exctoeuroexcrate,
                                Invexchrate = item.Invexchrate ?? 0,
                                Openchargeid = item.Openchargeid,
                                Triangulated = item.Triangulated > 0
                            }
                        );
                }
            }

            return data;
        }

     protected override long ReserveSequenceRangeInternal(int? keyNumber = 1) {
         return UnitOfWorkCurrent.GetNextIdentity("ContExcChaNo", keyNumber ?? 1);
     }
        
    }

}
