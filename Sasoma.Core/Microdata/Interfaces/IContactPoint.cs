using System;
using Sasoma.Microdata.Types;
using Sasoma.Microdata.Properties;

namespace Sasoma.Microdata.Interfaces
{
    public interface IContactPoint : IStructuredValue
    {
        ContactType_Core ContactType { get; set; }
        Email_Core Email { get; set; }
        FaxNumber_Core FaxNumber { get; set; }
        Telephone_Core Telephone { get; set; }
    }
}
