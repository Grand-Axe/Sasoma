using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

using Sasoma.Microdata.Interfaces;

namespace Sasoma.Api.Interfaces
{
    public interface IValue
    {
        IDataType Value { get; set; }
    }
}
