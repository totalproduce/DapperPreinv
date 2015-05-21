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
    public class AccAllocRepositoryRepository : DapperRepositoryBase<DTOAccAlloc>, IAccAllocRepository
    {
        private const string _sqlQuery = @"SELECT * FROM ACCALLOC";

        public AccAllocRepositoryRepository(IUnitOfWork unitOfWorkCurrent, ICacheManagerFactory cacheManagerFactory)
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
            return AccAlloc.GetPropDefs();
        }

        public override string GetTableName()
        {
            return "ACCALLOC";
        }

        public override IBaseModel ToDbModel(DTOAccAlloc item)
        {
            var result = new AccAlloc();
            result.Acaatrrecnofrom = item.Acaatrrecnofrom;
            result.Acaatrrecnoto = item.Acaatrrecnoto;
            result.Acaaavrecno = item.Acaaavrecno;
            result.Acadrcr = item.Acadrcr;
            return result;
        }

        protected override List<DTOAccAlloc> GetDataInternal(List<ISearchField> searchFields, CachingStrategy allowFromCache, uint? topRows)
        {
            string query = ConstructSimpleQuery(_sqlQuery, searchFields, true, topRows);

            var data = new List<DTOAccAlloc>();

            IEnumerable<AccAlloc> results = null;

            try
            {
                results = UnitOfWorkCurrent.Query<AccAlloc>(query);
            }
            catch (Exception ex)
            {
                throw new DatabaseQueryException("Could not load ACCALLOC" + Environment.NewLine + ex.Message, ex);
            }

            if (results != null)
            {
                foreach (var item in results)
                {
                    data.Add
                        (
                            new DTOAccAlloc
                            {
                                Acaatrrecnofrom = item.Acaatrrecnofrom,
                                Acaatrrecnoto = item.Acaatrrecnoto,
                                Acaaavrecno = item.Acaaavrecno,
                                Acadrcr = item.Acadrcr
                            }
                        );
                }
            }

            return data;
        }

        public List<DTOAccAllVal> GetData(List<ISearchField> searchFields, bool allowFromCache, uint? topRows = null)
        {
            throw new NotImplementedException();
        }

        public DTOAccAllVal Add(DTOAccAllVal entity)
        {
            throw new NotImplementedException();
        }

        public DTOAccAllVal Update(DTOAccAllVal entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(DTOAccAllVal entity)
        {
            throw new NotImplementedException();
        }
    }

}
