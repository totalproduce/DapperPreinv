using System;
using System.Collections.Generic;
using System.Linq;
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

namespace Bsdl.FreshTrade.Repositories.PreInv.PostTypeRep
{
    public class PostTypeRepository : DapperRepositoryBase<DTOPostType>, IPostTypeRepository
    {
        private const string _sqlQuery = @"SELECT * FROM POSTTYPE";

        public PostTypeRepository(IUnitOfWork unitOfWorkCurrent, ICacheManagerFactory cacheManagerFactory)
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
            return PostType.GetPropDefs();
        }

        public override string GetTableName()
        {
            return "POSTTYPE";
        }

        public override IBaseModel ToDbModel(DTOPostType item)
        {
            var result = new PostType();
            result.Pstrecno = item.Pstrecno;
            result.Dbtcdtno = item.Dbtcdtno;
            result.Instatementtypes = item.Instatementtypes;
            result.Pstdesc = item.Pstdesc;
            result.Pstledger = item.Pstledger;
            result.Psttype = item.Psttype;
            result.Purpayind = item.Purpayind;
            result.Restrictind = item.Restrictind;
            result.Turnoverind = item.Turnoverind;
            return result;
        }

        public Dictionary<int, int> GetPstDrCrMapping()
        {
            var items = GetDataInternal(null, CachingStrategy.GlobalCache, null);
            var result = items.Where(z => z.Pstledger.TrimEnd().ToLowerInvariant().Equals("sales")).ToDictionary(z => z.Pstrecno, z => (z.Psttype??string.Empty).TrimEnd().ToLowerInvariant().Equals("dbt") ? 1 : -1);
            return result;
        }

        protected override List<DTOPostType> GetDataInternal(List<ISearchField> searchFields, CachingStrategy allowFromCache, uint? topRows)
        {
            string query = ConstructSimpleQuery(_sqlQuery, searchFields, true, topRows);

            var data = new List<DTOPostType>();

            IEnumerable<PostType> results = null;

            try
            {
                results = UnitOfWorkCurrent.Query<PostType>(query);
            }
            catch (Exception ex)
            {
                throw new DatabaseQueryException("Could not load POSTTYPE" + Environment.NewLine + ex.Message, ex);
            }

            if (results != null)
            {
                foreach (var item in results)
                {
                    data.Add
                        (
                            new DTOPostType
                            {
                                Pstrecno = item.Pstrecno,
                                Dbtcdtno = item.Dbtcdtno,
                                Instatementtypes = item.Instatementtypes,
                                Pstdesc = item.Pstdesc,
                                Pstledger = item.Pstledger,
                                Psttype = item.Psttype,
                                Purpayind = item.Purpayind,
                                Restrictind = item.Restrictind,
                                Turnoverind = item.Turnoverind,
                            }
                        );
                }
            }

            return data;
        }
    }
}
