using System;
using Sasoma.Microdata.Types;
using Sasoma.Microdata.Properties;

namespace Sasoma.Microdata.Interfaces
{
    public interface IOrganization : IThing
    {
        Address_Core Address { get; set; }
        Properties.AggregateRating_Core AggregateRating { get; set; }
        ContactPoints_Core ContactPoints { get; set; }
        Email_Core Email { get; set; }
        Employees_Core Employees { get; set; }
        Events_Core Events { get; set; }
        FaxNumber_Core FaxNumber { get; set; }
        Founders_Core Founders { get; set; }
        FoundingDate_Core FoundingDate { get; set; }
        InteractionCount_Core InteractionCount { get; set; }
        Location_Core Location { get; set; }
        Members_Core Members { get; set; }
        Reviews_Core Reviews { get; set; }
        Telephone_Core Telephone { get; set; }
    }
}
