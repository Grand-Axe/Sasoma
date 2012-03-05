using System;
using Sasoma.Microdata.Types;
using Sasoma.Microdata.Properties;

namespace Sasoma.Microdata.Interfaces
{
    public interface ICivicStructure : IPlace
    {
        OpeningHours_Core OpeningHours { get; set; }
    }
}
