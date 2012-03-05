using System;
using Sasoma.Microdata.Types;
using Sasoma.Microdata.Properties;

namespace Sasoma.Microdata.Interfaces
{
    public interface IFoodEstablishment : ILocalBusiness
    {
        AcceptsReservations_Core AcceptsReservations { get; set; }
        Menu_Core Menu { get; set; }
        ServesCuisine_Core ServesCuisine { get; set; }
    }
}
