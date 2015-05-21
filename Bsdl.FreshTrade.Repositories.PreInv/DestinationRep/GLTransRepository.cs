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

    public class GLTransRepository : DapperRepositoryBase<DTOGLTrans>, IGLTransRepository
    {
        private const string _sqlQuery = @"SELECT * FROM GLTRANS";

        public GLTransRepository(IUnitOfWork unitOfWorkCurrent, ICacheManagerFactory cacheManagerFactory)
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
            return GLTrans.GetPropDefs();
        }

        public override string GetTableName()
        {
            return "GLTRANS";
        }

        public override IBaseModel ToDbModel(DTOGLTrans item)
        {
            var result = new GLTrans();
            result.Gltrecno = item.Gltrecno;
            result.Glextractbatchid = item.Glextractbatchid;
            result.Gltcat = item.Gltcat;
            result.Gltcomno = item.Gltcomno;
            result.Gltcramount = item.Gltcramount;
            result.Gltdbamount = item.Gltdbamount;
            result.Gltdbno = item.Gltdbno;
            result.Gltdbtyp = item.Gltdbtyp;
            result.Gltganrecno = item.Gltganrecno;
            result.Gltorgdbno = item.Gltorgdbno;
            result.Gltperno = item.Gltperno;
            result.Gltsaloffno = item.Gltsaloffno;
            result.Gltyrno = item.Gltyrno;
            return result;
        }

        protected override List<DTOGLTrans> GetDataInternal(List<ISearchField> searchFields, CachingStrategy allowFromCache, uint? topRows)
        {
            string query = ConstructSimpleQuery(_sqlQuery, searchFields, true, topRows);

            var data = new List<DTOGLTrans>();

            IEnumerable<GLTrans> results = null;

            try
            {
                results = UnitOfWorkCurrent.Query<GLTrans>(query);
            }
            catch (Exception ex)
            {
                throw new DatabaseQueryException("Could not load GLTRANS" + Environment.NewLine + ex.Message, ex);
            }

            if (results != null)
            {
                foreach (var item in results)
                {
                    data.Add
                        (
                            new DTOGLTrans
                            {
                                Gltrecno = item.Gltrecno,
                                Glextractbatchid = item.Glextractbatchid,
                                Gltcat = item.Gltcat,
                                Gltcomno = item.Gltcomno,
                                Gltcramount = item.Gltcramount ?? 0,
                                Gltdbamount = item.Gltdbamount ?? 0,
                                Gltdbno = item.Gltdbno,
                                Gltdbtyp = item.Gltdbtyp,
                                Gltganrecno = item.Gltganrecno,
                                Gltorgdbno = item.Gltorgdbno,
                                Gltperno = item.Gltperno,
                                Gltsaloffno = item.Gltsaloffno,
                                Gltyrno = item.Gltyrno
                            }
                        );
                }
            }

            return data;
        }
    }
}
