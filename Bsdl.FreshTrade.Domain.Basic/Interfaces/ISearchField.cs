using Bsdl.FreshTrade.Domain.Basic.Enums;

namespace Bsdl.FreshTrade.Domain.Basic.Interfaces
{
    public interface ISearchField
    {
        string DisplayName { get; }

        string FieldName { get; }

        object Value { get; }

        ISearchField Apply(object data, FieldType fieldType);

        bool IncludeLike { get; }

        bool FreeFormatSpecial { get; }
    }
}
