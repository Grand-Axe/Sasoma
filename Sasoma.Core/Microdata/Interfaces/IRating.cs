using System;
using Sasoma.Microdata.Types;
using Sasoma.Microdata.Properties;

namespace Sasoma.Microdata.Interfaces
{
    public interface IRating : IIntangible
    {
        BestRating_Core BestRating { get; set; }
        RatingValue_Core RatingValue { get; set; }
        WorstRating_Core WorstRating { get; set; }
    }
}
