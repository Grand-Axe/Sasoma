using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sasoma.Api.Interfaces
{
    public interface IWriter<T> : IWork
    {
        void Write(IWork work);
    }
}
