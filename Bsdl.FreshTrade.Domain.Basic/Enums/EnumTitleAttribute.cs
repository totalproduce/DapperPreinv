using System;

namespace Bsdl.FreshTrade.Domain.Basic.Enums
{
    /// <summary>
    /// Attribute used to define a title for enumeration items.
    /// </summary>
    [AttributeUsage(AttributeTargets.Field)]
    public class EnumTitleAttribute : Attribute
    {
        public string Code { get; set; }
        public string Title { get; set; }
    }
}
