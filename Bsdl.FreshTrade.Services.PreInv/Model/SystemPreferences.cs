using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using Bsdl.FreshTrade.Domain.Basic.Utilities.DataTypeHandling;

namespace Bsdl.FreshTrade.Services.PreInv.Model
{
    [AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
    public class SysPrefAttribute: Attribute
    {
        public string Name { get; set; }
    }

    public class SystemPreferences
    {

        private const string LockSalesOffParamName = "PreInvLockSalesOffice";
        private const string LogUpdateResultsParamName = "LogUpdateResults";

        [SysPref(Name = "ALTERNATEGROUPS")]
        public bool UseAlternativeProductGroups { get; set; } //StringToLogical(dynSysPrefs["ALTERNATEGROUPS"]) ; doug 29/01/09

        [SysPref(Name = "TRANSAUTHFLAG")]
        public int TransShipmentAuthFlag { get; set; } //SmallInt(dynSysPrefs["TRANSAUTHFLAG"])

        [SysPref(Name = "USESHIPDATE")]
        public bool UseShipDate { get; set; } //StringToLogical(dynSysPrefs["UseShipDate"]) ; karena 03/06/08

        [SysPref(Name = "USEDELIVDATE")]
        public bool UseDelivDate { get; set; } //StringToLogical(dynSysPrefs["UseDelivDate"])

        [SysPref(Name = "USERHASVAT")]
        public bool UserHasVat { get; set; } //StringToLogical(dynSysPrefs["UserHasVat"])

        [SysPref(Name = "PRICELISTVATCHECK")]
        public bool NeedsPriceListVatCheck { get; set; } //StringToLogical(dynSysPrefs["PRICELISTVATCHECK"])

        [SysPref(Name = "ADDYEARTOINVNO")]
        public bool AddYearToInvNo { get; set; } //stringToLogical(dynSysPrefs["ADDYEARTOINVNO"])

        [SysPref(Name = "ADDSOTOINVNO")]
        public bool AddSoToInvNo { get; set; } //stringToLogical(dynSysPrefs["ADDSOTOINVNO"])

        [SysPref(Name = "LCECONVFACTOR")]
        public bool IsSandardUnitsRequered { get; set; } //StringToLogical(dynSysPrefs["LCEConvFactor"])

        [SysPref(Name = "PRDGROUPFLD")]
        public int ProductAnalysisLevNo { get; set; } //smallint(dynSysPrefs["PRDGROUPFLD"])

        [SysPref(Name = "DEBITSGREATERINPREINV")]
        public bool DebitsGreaterInPreinv { get; set; }//StringToLogical(dynSysPrefs["DEBITSGREATERINPREINV"])

        [SysPref(Name = "LCECONVFACTOR")]
        public bool StandardUnitsRequired { get; set; }//StringToLogical(dynSysPrefs["LCEConvFactor"])

        [SysPref(Name = "LCEPRCREF")]
        public int? StandardUnitsLevel { get; set; } //dynSysPrefs["LCEPRCREF"]

        [SysPref(Name = "STKRETAUTORELINV")]
        public bool CheckForNonReleasedCredits { get; set; } //not StringToLogical(dynSysPrefs["StkRetAutoRelInv"]) ; ie if not auto release stk credit notes then check for flagged as not released

        [SysPref(Name = "PREINVSORTKEY1")]
        public string PreInvSortKey1 { get; set; } // dynSysPrefs["PreinvSortKey1"].upper()

        [SysPref(Name = "PREINVSORTKEY2")]
        public string PreInvSortKey2 { get; set; } // dynSysPrefs["PreinvSortKey2"].upper()

        [SysPref(Name = "INVPRTSORTKEY1")]
        public string InvPrtSortKey1 { get; set; } // dynSysPrefs["InvprtSortKey1"].upper()

        [SysPref(Name = "USEAUTOCOSTING")]
        public bool UseAutoCosting { get; set; } // Logical(GetSysPref("USEAUTOCOSTING", True, False))

        /*Other properties*/
        public string FormName { get; set; }
        public int FormNo { get; set; }

        public bool SalesOfficeNeedLock { get; set; }
        public bool LogUpdateResults { get; set; }

        public static List<string> GetSettingNames()
        {
            var result = new List<string>();
            PropertyInfo[] props = typeof(SystemPreferences).GetProperties();
            foreach (PropertyInfo prop in props)
            {
                object[] attrs = prop.GetCustomAttributes(true);
                result.AddRange(attrs.OfType<SysPrefAttribute>().Select(attr => attr.Name));
            }
            return result;
        }

        private static string GetSettingValue<R>(Expression<Func<SystemPreferences, R>> propRef, Dictionary<string, string> settingList)
        {
            var attr = (SysPrefAttribute)DelegateHelpers.GetPropertyAttributeFromExpression(propRef, typeof(SysPrefAttribute));
            return settingList[attr.Name];
        }

        private static bool GetBooleanValue<R>(Expression<Func<SystemPreferences, R>> propRef, Dictionary<string, string> settingList)
        {
            return AlphaHandling.StringToBoolean(GetSettingValue<R>(propRef, settingList));
        }

        private static int GetIntegerValue<R>(Expression<Func<SystemPreferences, R>> propRef, Dictionary<string, string> settingList)
        {
            var valStr = GetSettingValue(i => i.ProductAnalysisLevNo, settingList);
            if (string.IsNullOrEmpty(valStr))
            {
                return 0;
            }

            int intVal = 0;
            if (int.TryParse(valStr, out intVal))
            {
                return intVal;
            }
            return 0;
        }

        public static SystemPreferences ReadFromSettingList(Dictionary<string, string> settingList, string settingsKeyFormName, string settingsKeyFormNo)
        {
            bool salOffLock;
            if (!bool.TryParse(ConfigurationManager.AppSettings[LockSalesOffParamName], out salOffLock))
                salOffLock = true;

            bool logUpdateResults;
            if (!bool.TryParse(ConfigurationManager.AppSettings[LogUpdateResultsParamName], out logUpdateResults))
                logUpdateResults = false;

            return new SystemPreferences
                       {
                           UseAlternativeProductGroups = GetBooleanValue(i => i.UseAlternativeProductGroups, settingList),
                                //StringToLogical(dynSysPrefs["ALTERNATEGROUPS"]) ; doug 29/01/09

                           TransShipmentAuthFlag = GetIntegerValue(i => i.TransShipmentAuthFlag, settingList),
                                //SmallInt(dynSysPrefs["TRANSAUTHFLAG"])

                           UseShipDate = GetBooleanValue(i => i.UseShipDate, settingList),
                                //StringToLogical(dynSysPrefs["UseShipDate"]) ; karena 03/06/08

                           UseDelivDate = GetBooleanValue(i => i.UseDelivDate, settingList),
                                //StringToLogical(dynSysPrefs["UseDelivDate"])

                           UserHasVat = GetBooleanValue(i => i.UserHasVat, settingList),
                                //StringToLogical(dynSysPrefs["UserHasVat"])

                           NeedsPriceListVatCheck = GetBooleanValue(i => i.NeedsPriceListVatCheck, settingList),
                                //StringToLogical(dynSysPrefs["PRICELISTVATCHECK"])

                           AddYearToInvNo = GetBooleanValue(i => i.AddYearToInvNo, settingList),
                                //stringToLogical(dynSysPrefs["ADDYEARTOINVNO"])

                           AddSoToInvNo = GetBooleanValue(i => i.AddSoToInvNo, settingList),
                                //stringToLogical(dynSysPrefs["ADDSOTOINVNO"])

                           IsSandardUnitsRequered = GetBooleanValue(i => i.IsSandardUnitsRequered, settingList),
                                //StringToLogical(dynSysPrefs["LCEConvFactor"])

                           ProductAnalysisLevNo  = GetIntegerValue(i => i.ProductAnalysisLevNo, settingList),
                                //smallint(dynSysPrefs["PRDGROUPFLD"])

                           DebitsGreaterInPreinv = GetBooleanValue(i => i.DebitsGreaterInPreinv, settingList),
                                //StringToLogical(dynSysPrefs["DEBITSGREATERINPREINV"])

                           StandardUnitsRequired  = GetBooleanValue(i => i.StandardUnitsRequired, settingList),
                                //StringToLogical(dynSysPrefs["LCEConvFactor"])

                           StandardUnitsLevel = GetIntegerValue(i => i.StandardUnitsLevel, settingList),
                                //dynSysPrefs["LCEPRCREF"]

                           CheckForNonReleasedCredits = !GetBooleanValue(i => i.CheckForNonReleasedCredits, settingList),
                                //not StringToLogical(dynSysPrefs["StkRetAutoRelInv"]) ; ie if not auto release stk credit notes then check for flagged as not released

                           PreInvSortKey1 = GetSettingValue(i => i.PreInvSortKey1, settingList).ToUpper(),
                                // dynSysPrefs["PreinvSortKey1"].upper()

                           PreInvSortKey2 = GetSettingValue(i => i.PreInvSortKey2, settingList).ToUpper(),
                                // dynSysPrefs["PreinvSortKey2"].upper()

                           InvPrtSortKey1 = GetSettingValue(i => i.InvPrtSortKey1, settingList).ToUpper(),
                                // dynSysPrefs["InvprtSortKey1"].upper()        

                           UseAutoCosting = GetBooleanValue(i => i.UseAutoCosting, settingList),

                          /*Other settings*/
                           FormName = settingList[settingsKeyFormName],
                           FormNo = int.Parse(settingList[settingsKeyFormNo]),
                           SalesOfficeNeedLock = salOffLock
                       };
        }
    }
}
