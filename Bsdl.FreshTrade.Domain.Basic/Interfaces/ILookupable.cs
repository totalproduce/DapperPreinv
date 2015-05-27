namespace Bsdl.FreshTrade.Domain.Basic.Interfaces
{
    using System.Collections.Generic;

    /// <summary>
    /// Allows an object to be treated as a key-value pair that can be
    /// be searched for specific keys or values using a generic user interface
    /// </summary>
    public interface ILookupable
    {
        /// <summary>
        /// Gets the title of the search form
        /// </summary>
        /// <returns></returns>
        string GetTitle();

        /// <summary>
        /// Get the name of the field that the key data represents
        /// </summary>
        /// <returns></returns>
        string GetKeyHeader();

        /// <summary>
        /// Get the name of the field that the value data represents
        /// </summary>
        /// <returns></returns>
        string GetValueHeader();

        /// <summary>
        /// Gets the data that can be searched
        /// </summary>
        /// <returns></returns>
        IDictionary<string, string> GetKeyValueData();
    }
}
