using System;
using Sasoma.Microdata.Types;
using Sasoma.Microdata.Properties;

namespace Sasoma.Microdata.Interfaces
{
    public interface IEvent : IThing
    {
        Attendees_Core Attendees { get; set; }
        Properties.Duration_Core Duration { get; set; }
        EndDate_Core EndDate { get; set; }
        Location_Core Location { get; set; }
        Offers_Core Offers { get; set; }
        Performers_Core Performers { get; set; }
        StartDate_Core StartDate { get; set; }
        SubEvents_Core SubEvents { get; set; }
        SuperEvent_Core SuperEvent { get; set; }
    }
}
