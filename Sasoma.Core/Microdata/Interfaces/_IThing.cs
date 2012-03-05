using System;
using Sasoma.Microdata.Properties;

namespace Sasoma.Microdata.Interfaces
{
    public interface IThing : IMicrodata
    {
        Description_Core Description { get; set; }
        Image_Core Image { get; set; }
        Name_Core Name { get; set; }
        Properties.URL_Core URL { get; set; }
    }
}
