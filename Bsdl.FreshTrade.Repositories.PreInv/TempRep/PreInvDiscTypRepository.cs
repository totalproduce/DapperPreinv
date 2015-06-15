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
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bsdl.FreshTrade.Repositories.PreInv.TempRep
{

    public class PreInvDiscTypRepository : DapperRepositoryBase<DTOInvDiscTyp>, IPreInvDiscTypRepository
    {
        private const string EntityTableName = @"PREINVTEMP_PREINVDISCTYP";

        private const string SqlQuery = @"SELECT * FROM " + EntityTableName;

        private const string SqlDeleteQuery = @"DELETE FROM " + EntityTableName + " WHERE EXTRACTSESSIONID = {0}";

        public PreInvDiscTypRepository(IUnitOfWork unitOfWorkCurrent, ICacheManagerFactory cacheManagerFactory)
            : base
            (
                unitOfWorkCurrent,
                cacheManagerFactory,
                new List<ISearchFieldDef>
                {
                   new SearchFieldDef<DTOInvDiscTyp, int>(i => i.ExtractSessionID, INVDISCTYP.FieldNames.EXTRACTSESSIONID, FieldType.Integer),
                   new SearchFieldDef<DTOInvDiscTyp, string>(i => i.DlvInvoiceNo, INVDISCTYP.FieldNames.DLVINVOICENO, FieldType.AlphaNumeric),
                   new SearchFieldDef<DTOInvDiscTyp, int?>(i => i.RecNo, INVDISCTYP.FieldNames.RECNO, FieldType.Integer)
                }
            )
        {
        }


        public override IList<EntityPropDef> GetTableFieldsDefs()
        {
            return INVDISCTYP.GetPropDefs();
        }

        public override string GetTableName()
        {
            return EntityTableName;
        }

        public override IBaseModel ToDbModel(DTOInvDiscTyp item)
        {
            var result = new INVDISCTYP();
            result.Extractsessionid = item.ExtractSessionID;
            result.Discbaseamt = item.DiscBaseAmt;
            result.Discdetrstr = item.DiscDetrStr;
            result.Disceuroamt = item.DiscEuroAmt;
            result.Discglrecno = item.DiscGlRecNo;
            result.Discloclamt = item.DiscLoclAmt;
            result.Discrate = item.DiscRate;
            result.Discseqno = item.DiscSeqNo;
            result.Disctyp = (int)item.DiscTyp;
            result.Dlvinvoiceno = item.DlvInvoiceNo;
            result.Ichrecno = item.Ichrecno;
            result.Recno = item.RecNo;
            return result;
        }

        protected override List<DTOInvDiscTyp> GetDataInternal(List<ISearchField> searchFields, CachingStrategy allowFromCache, uint? topRows)
        {
            string query = ConstructSimpleQuery(SqlQuery, searchFields, true, topRows);

            var data = new List<DTOInvDiscTyp>();

            IEnumerable<INVDISCTYP> results = null;

            try
            {
                results = UnitOfWorkCurrent.Query<INVDISCTYP>(query);
            }
            catch (Exception ex)
            {
                throw new DatabaseQueryException("Could not load " + EntityTableName + Environment.NewLine + ex.Message, ex);
            }

            if (results != null)
            {
                foreach (var item in results)
                {
                    //Debug.Assert(item.Disctyp != null, "item.Disctyp != null");
                    data.Add
                        (
                            new DTOInvDiscTyp
                            {
                                ExtractSessionID = item.Extractsessionid,
                                DiscBaseAmt = item.Discbaseamt ?? 0,
                                DiscDetrStr = item.Discdetrstr,
                                DiscEuroAmt = item.Disceuroamt ?? 0,
                                DiscGlRecNo = item.Discglrecno,
                                DiscLoclAmt = item.Discloclamt ?? 0,
                                DiscRate = item.Discrate ?? 0,
                                DiscSeqNo = item.Discseqno,
                                DiscTyp = item.Disctyp.HasValue?Enums<EnumDiscTypes>.GetValue(item.Disctyp.Value):(EnumDiscTypes?)null,
                                DlvInvoiceNo = item.Dlvinvoiceno,
                                Ichrecno = item.Ichrecno,
                                RecNo = item.Recno
                            }
                        );
                }
            }

            return data;
        }

        public List<DTOInvDiscTyp> GetByExtractSessionID(int extractSessionID)
        {
            return GetData(
                    new List<ISearchField> {
                        new SearchFieldGeneric<DTOInvDiscTyp, int>(i => i.ExtractSessionID).Apply(extractSessionID , FieldType.Integer)
                 }, CachingStrategy.NoCache).ToList();
        }

        public void DeleteByExtractSessionID(int extractSessionID)
        {
            string sqlQuery = string.Format(SqlDeleteQuery, extractSessionID);
            UnitOfWorkCurrent.Execute(sqlQuery);
        }
    }

}
