using System;
namespace Sasoma.Microdata.Interfaces
{
    /// <summary>
    /// This interface governs the contracts for managing cache objects.
    /// </summary>
    public interface ICache
    {
        object GetFromCache(string name);
        void SetCache(string name, object value);
    }
}
