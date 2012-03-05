using System;
using Sasoma.Microdata.Types;
using Sasoma.Microdata.Properties;

namespace Sasoma.Microdata.Interfaces
{
    public interface ILocalBusiness : IOrganization
    {
        BranchOf_Core BranchOf { get; set; }
        CurrenciesAccepted_Core CurrenciesAccepted { get; set; }
        OpeningHours_Core OpeningHours { get; set; }
        PaymentAccepted_Core PaymentAccepted { get; set; }
        PriceRange_Core PriceRange { get; set; }
    }
}
