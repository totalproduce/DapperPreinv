using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bsdl.FreshTrade.Domain.Basic.Entities;
using Bsdl.FreshTrade.Domain.Basic.Enums;
using Bsdl.FreshTrade.Domain.Basic.Exceptions;
using Bsdl.FreshTrade.Domain.Basic.Interfaces;
using Bsdl.FreshTrade.Repositories.Basic.DBModel;
using Bsdl.FreshTrade.Repositories.Basic.Interfaces;
using Bsdl.FreshTrade.Repositories.Basic.Utilities.Interfaces;

namespace Bsdl.FreshTrade.Repositories.Basic.SysPreferencesRep
{
    public class SystemPreferenceRepository : DapperRepositoryBase<DTOSysPref>, ISystemPreferenceRepository
    {
        private const string _sqlQuery = @"SELECT * FROM WIZSYSPREF";
        private const string _sqlFormQuery = @"SELECT FormNo FROM FRMNAME WHERE FormName = {0}";

        private const string _settingsKeyFormName = "FormName";
        private const string _settingsKeyFormNo = "FormNo";

        public SystemPreferenceRepository(IUnitOfWork unitOfWorkCurrent, ICacheManagerFactory cacheManagerFactory)
            : base
            (
                unitOfWorkCurrent,
                cacheManagerFactory,
                new List<ISearchFieldDef>
                {
                    new SearchFieldDef<DTOSysPref, string>(i => i.Name, WizSysPref.FieldNames.SYSPREFNAME, FieldType.AlphaNumeric)
                }
            )
        {
        }

        protected override List<DTOSysPref> GetDataInternal(List<ISearchField> searchFields, CachingStrategy allowFromCache, uint? topRows)
        {
            string query = ConstructSimpleQuery(_sqlQuery, searchFields, true, topRows);
            var results = UnitOfWorkCurrent.Query<WizSysPref>(query);

            return results
                    .Select(item =>
                        new DTOSysPref
                        {
                            Name = item.Sysprefname,
                            Value = item.Sysprefvalue
                        })
                    .ToList();
        }

        public Dictionary<string, string> GetSettings(List<string> settingNames, string formName)
        {
            var searchParams =
                new List<ISearchField>
                    {
                        new SearchFieldGeneric<DTOSysPref, string>(i => i.Name).Apply(settingNames, FieldType.List)
                    };

            var settings = GetData(searchParams, CachingStrategy.NoCache).ToDictionary(i => i.Name.Trim(), i => string.IsNullOrEmpty(i.Value)?i.Value:i.Value.Trim());
            settings.Add(_settingsKeyFormName, formName);

            string query = string.Format(_sqlFormQuery, GetSearchFieldValueAsString(FieldType.AlphaNumeric, formName));
            var formNo = UnitOfWorkCurrent.Query<int>(query).FirstOrDefault();
            if (formNo == 0)
            {
                throw new FreshTradeException("Form No cannot be found");
            }

            settings.Add(_settingsKeyFormNo, formNo.ToString());

            return settings;
        }

        public string SettingsKeyFormName { get { return _settingsKeyFormName; } }
        public string SettingsKeyFormNo { get { return _settingsKeyFormNo; } }
    }
}
