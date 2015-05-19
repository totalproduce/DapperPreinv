using Bsdl.FreshTrade.Domain.Basic.Interfaces;

namespace Bsdl.FreshTrade.UI.Basic.Utilities
{
    public static class Globals
    {
        public static int DbID { get; set; }
        public static IDTOUser FreshTradeUser { get; set; }
        public static IDTOFreshTradeDisplayID FreshTradeDisplayID { get; set; }
        public static string UserSession { get; set; }

        public static string AppVersion
        {
            get
            {
                return string.Format("{0}.{1}.{2}({3})",
                    System.Reflection.Assembly.GetEntryAssembly().GetName().Version.Major,
                    System.Reflection.Assembly.GetEntryAssembly().GetName().Version.Minor,
                    System.Reflection.Assembly.GetEntryAssembly().GetName().Version.Build,
                    System.Reflection.Assembly.GetEntryAssembly().GetName().Version.Revision);
            }
        }
    }
}
