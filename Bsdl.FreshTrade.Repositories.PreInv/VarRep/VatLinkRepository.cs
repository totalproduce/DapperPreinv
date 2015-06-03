using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bsdl.FreshTrade.Domain.Account.Enums;
using Bsdl.FreshTrade.Domain.Basic.Enums;
using Bsdl.FreshTrade.Domain.Basic.Interfaces;
using Bsdl.FreshTrade.Domain.Basic.Utilities.DataTypeHandling;
using Bsdl.FreshTrade.Domain.PreInv.Entities;
using Bsdl.FreshTrade.Repositories.Basic;
using Bsdl.FreshTrade.Repositories.Basic.Utilities.Interfaces;
using Bsdl.FreshTrade.Repositories.PreInv.DBModel;
using Bsdl.FreshTrade.Repositories.PreInv.Interfaces;

namespace Bsdl.FreshTrade.Repositories.PreInv.VarRep
{
    public class VatLinkRepository : DapperRepositoryBase<DTOVatLink>, IVatLinkRepository
    {
        private const string _sqlQuery = @"SELECT * FROM VATLINKS";

        public VatLinkRepository(IUnitOfWork unitOfWorkCurrent, ICacheManager cacheManager)
            : base
            (
                unitOfWorkCurrent,
                cacheManager,
                new List<ISearchFieldDef>
                {
                    new SearchFieldDef<DTOVatLink, int>(i => i.Id, VatLinks.FieldNames.VATLNKRECNO, FieldType.Integer)
                }
            )
        {
        }

        protected override List<DTOVatLink> GetDataInternal(List<ISearchField> searchFields, bool allowFromCache, uint? topRows)
        {
            string query = ConstructSimpleQuery(_sqlQuery, searchFields, true, topRows);
            var results = UnitOfWorkCurrent.Query<VatLinks>(query);

            return results
                    .Select(item =>
                        new DTOVatLink
                        {
                            Id = item.Vatlnkrecno,
                            VatRateId = item.Vatrecno,
                            VatVeaId = item.Vatvearecno,
                            AccountType = Enums<DTOAccountType>.GetValueNullable(item.Vatacccstsup),
                            FromCountryNo = item.Vatfromcountryno,
                            DeliveryTypeId = item.Vatdlvtype,
                            DeliveryCountryNo = item.Vatdlvcountryno,
                            SalesOfficeNo = item.Vatsalesoffice,
                            ProductLevel1Ref = item.Vatprcref1,
                            ProductLevel2Ref = item.Vatprcref2,
                            ProductLevel3Ref = item.Vatprcref3,
                            ProductLevel4Ref = item.Vatprcref4,
                            ProductLevel5Ref = item.Vatprcref5,
                            ProductLevel6Ref = item.Vatprcref6,
                            VatGroupNo = item.Chgvatgrpno,
                            ChargeType = item.Vatctyno,
                            VatType = item.Cstvattype
                        })
                    .ToList();
        }
    }
}
