using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bsdl.FreshTrade.Domain.Basic.Utilities
{
    public class UpdatePair<T>
    {
        public T Old { get; set; }
        public T New { get; set; }

        public UpdatePair(T oldItem, T newItem)
        {
            Old = oldItem;
            New = newItem;
        }
    }
}
