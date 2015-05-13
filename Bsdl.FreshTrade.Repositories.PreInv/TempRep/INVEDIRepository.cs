using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bsdl.FreshTrade.Domain.Basic.Entities;
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

namespace Bsdl.FreshTrade.Repositories.PreInv.TempRep
{
    public class INVEDIRepository : DapperRepositoryBase<DTOInvEdi>, IINVEDIRepository
    {
        private const string _sqlQuery = @"SELECT * FROM PREINVTEMP_INVEDI";

        public INVEDIRepository(IUnitOfWork unitOfWorkCurrent, ICacheManagerFactory cacheManagerFactory)
            : base
            (
                unitOfWorkCurrent,
                cacheManagerFactory,
                new List<ISearchFieldDef>
                {
                    new SearchFieldDef<DTOInvEdi, int>(i => i.ExtractSessionID, INVEDI.FieldNames.EXTRACTSESSIONID, FieldType.Integer)
                }
            )
        {
        }


        public override IList<EntityPropDef> GetTableFieldsDefs()
        {
            return INVEDI.GetPropDefs();
        }

        public override string GetTableName()
        {
            return "PREINVTEMP_INVEDI";
        }

        public override IBaseModel ToDbModel(DTOInvEdi item)
        {
            var result = new INVEDI();
            result.Extractsessionid = item.ExtractSessionID;
            result.Companyname = item.Companyname;
            result.Edifile = item.Edifile;
            result.Ehheadid = item.Ehheadid;
            result.Fileno = item.Fileno;
            result.Hofclarecno = item.Hofclarecno;
            result.Hofcstcode = item.HofCstCode;
            result.Hofcstname = item.Hofcstname;
            result.Newfile = item.Newfile;
            result.Newtransref = item.Newtransref;
            result.Prcglbrecno = item.PrcGlbRecNo;
            return result;
        }

        protected override List<DTOInvEdi> GetDataInternal(List<ISearchField> searchFields, CachingStrategy allowFromCache, uint? topRows)
        {
            string query = ConstructSimpleQuery(_sqlQuery, searchFields, true, topRows);

            var data = new List<DTOInvEdi>();

            IEnumerable<INVEDI> results = null;

            try
            {
                results = UnitOfWorkCurrent.Query<INVEDI>(query);
            }
            catch (Exception ex)
            {
                throw new DatabaseQueryException("Could not load PREINVTEMP_INVEDI" + Environment.NewLine + ex.Message, ex);
            }

            if (results != null)
            {
                foreach (var item in results)
                {
                    data.Add
                        (
                            new DTOInvEdi
                            {
                                ExtractSessionID = item.Extractsessionid,
                                Companyname = item.Companyname,
                                Edifile = item.Edifile,
                                Ehheadid = item.Ehheadid,
                                Fileno = item.Fileno,
                                Hofclarecno = item.Hofclarecno,
                                HofCstCode = item.Hofcstcode,
                                Hofcstname = item.Hofcstname,
                                Newfile = item.Newfile,
                                Newtransref = item.Newtransref,
                                PrcGlbRecNo = item.Prcglbrecno
                            }
                        );
                }
            }

            return data;
        }

        public List<DTOInvEdi> GetByExtractSessionId(int extractSessionID)
        {
            return GetData(
                    new List<ISearchField> {
                        new SearchFieldGeneric<DTOInvEdi, int>(i => i.ExtractSessionID).Apply(extractSessionID , FieldType.Integer)
                 }, CachingStrategy.NoCache).ToList();
        }
    }
}
