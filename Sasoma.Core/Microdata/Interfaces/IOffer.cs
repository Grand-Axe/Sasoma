using System;
using Sasoma.Microdata.Types;
using Sasoma.Microdata.Properties;

namespace Sasoma.Microdata.Interfaces
{
    public interface IOffer : IIntangible
    {
        Properties.AggregateRating_Core AggregateRating { get; set; }
        Availability_Core Availability { get; set; }
        ItemCondition_Core ItemCondition { get; set; }
        ItemOffered_Core ItemOffered { get; set; }
        Price_Core Price { get; set; }
        PriceCurrency_Core PriceCurrency { get; set; }
        PriceValidUntil_Core PriceValidUntil { get; set; }
        Reviews_Core Reviews { get; set; }
        Seller_Core Seller { get; set; }
    }
}
