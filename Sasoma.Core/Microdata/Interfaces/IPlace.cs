using System;
using Sasoma.Microdata.Types;
using Sasoma.Microdata.Properties;

namespace Sasoma.Microdata.Interfaces
{
    public interface IPlace : IThing
    {
        Address_Core Address { get; set; }
        Properties.AggregateRating_Core AggregateRating { get; set; }
        ContainedIn_Core ContainedIn { get; set; }
        Events_Core Events { get; set; }
        Properties.FaxNumber_Core FaxNumber { get; set; }
        Geo_Core Geo { get; set; }
        InteractionCount_Core InteractionCount { get; set; }
        Maps_Core Maps { get; set; }
        Photos_Core Photos { get; set; }
        Reviews_Core Reviews { get; set; }
        Telephone_Core Telephone { get; set; }
    }
}
