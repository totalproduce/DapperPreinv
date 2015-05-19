using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bsdl.FreshTrade.Domain.Basic.Entities;

namespace Bsdl.FreshTrade.Repositories.Basic.Interfaces
{
    public interface ISystemPreferenceRepository : IRepositoryBase<DTOSysPref>
    {
        Dictionary<string, string> GetSettings(List<string> settingNames, string formName);
        string SettingsKeyFormName { get; }
        string SettingsKeyFormNo { get; }
    }
}
