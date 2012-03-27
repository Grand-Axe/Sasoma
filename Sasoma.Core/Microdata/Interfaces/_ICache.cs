using System;
namespace Sasoma.Microdata.Interfaces
{
    /// <summary>
    /// This interface governs the contracts for managing cache objects.
    /// </summary>
    public interface ICache : IIdentified
    {
        object GetFromCache(string name);
        void SetCache(string name, object value);
    }
}
