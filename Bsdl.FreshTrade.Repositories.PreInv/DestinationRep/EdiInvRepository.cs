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
 
    public class EdiInvRepository : DapperRepositoryBase<DTOEdiInv>, IEdiInvRepository
    {
        private const string _sqlQuery = @"SELECT * FROM EDIINV";

        public EdiInvRepository(IUnitOfWork unitOfWorkCurrent, ICacheManagerFactory cacheManagerFactory)
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
            return EdiInv.GetPropDefs();
        }

        public override string GetTableName()
        {
            return "EDIINV";
        }

        public override IBaseModel ToDbModel(DTOEdiInv item)
        {
            var result = new EdiInv();
            result.Coglbno = item.Coglbno;
            result.Hofcstcode = item.Hofcstcode;
            result.Hofclarecno = item.Hofclarecno;
            result.Invoiceno = item.Invoiceno;
            result.Dlvordno = item.Dlvordno;
            result.Atrrecno = item.Atrrecno;
            result.Clarecno = item.Clarecno;
            result.Cleared = item.Cleared;
            result.Dlvdeldate = item.Dlvdeldate;
            result.Dlvpodno = item.Dlvpodno;
            result.Dlvshpdate = item.Dlvshpdate;
            result.Ediinvrecno = item.Ediinvrecno;
            result.Filetype = item.Filetype;
            result.Ftdlvordno = item.Ftdlvordno;
            result.Invamt = item.Invamt;
            result.Invdate = item.Invdate;
            result.Invvatamt = item.Invvatamt;
            result.Ordcstcode = item.Ordcstcode;
            result.Orddate = item.Orddate;
            result.Ordno = item.Ordno;
            result.Ordref = item.Ordref;
            result.Porrecno = item.Porrecno;
            result.Saloffno = item.Saloffno;
            result.Supplieracccode = item.Supplieracccode;
            result.Supplierclarecno = item.Supplierclarecno;
            result.Uplrecnoin = item.Uplrecnoin;
            result.Uplrecnoout = item.Uplrecnoout;
            return result;
        }

        protected override List<DTOEdiInv> GetDataInternal(List<ISearchField> searchFields, CachingStrategy allowFromCache, uint? topRows)
        {
            string query = ConstructSimpleQuery(_sqlQuery, searchFields, true, topRows);

            var data = new List<DTOEdiInv>();

            IEnumerable<EdiInv> results = null;

            try
            {
                results = UnitOfWorkCurrent.Query<EdiInv>(query);
            }
            catch (Exception ex)
            {
                throw new DatabaseQueryException("Could not load AccVAT" + Environment.NewLine + ex.Message, ex);
            }

            if (results != null)
            {
                foreach (var item in results)
                {
                    data.Add
                        (
                            new DTOEdiInv
                            {
                                Coglbno = item.Coglbno,
                                Hofcstcode = item.Hofcstcode,
                                Hofclarecno = item.Hofclarecno,
                                Invoiceno = item.Invoiceno,
                                Dlvordno = item.Dlvordno,
                                Atrrecno = item.Atrrecno,
                                Clarecno = item.Clarecno,
                                Cleared = item.Cleared,
                                Dlvdeldate = item.Dlvdeldate,
                                Dlvpodno = item.Dlvpodno,
                                Dlvshpdate = item.Dlvshpdate,
                                Ediinvrecno = item.Ediinvrecno,
                                Filetype = item.Filetype,
                                Ftdlvordno = item.Ftdlvordno,
                                Invamt = item.Invamt ?? 0,
                                Invdate = item.Invdate,
                                Invvatamt = item.Invvatamt ?? 0,
                                Ordcstcode = item.Ordcstcode,
                                Orddate = item.Orddate,
                                Ordno = item.Ordno,
                                Ordref = item.Ordref,
                                Porrecno = item.Porrecno,
                                Saloffno = item.Saloffno,
                                Supplieracccode = item.Supplieracccode,
                                Supplierclarecno = item.Supplierclarecno,
                                Uplrecnoin = item.Uplrecnoin,
                                Uplrecnoout = item.Uplrecnoout
                            }
                        );
                }
            }

            return data;
        }
    }

}
