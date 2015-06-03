using System.Collections.Generic;
using Bsdl.FreshTrade.Domain.Basic.Entities;

namespace Bsdl.FreshTrade.Domain.Basic.Interfaces
{
    public interface IDTOCurrency
    {
        int No { get; set; }

        string Description { get; set; }
    }
}
