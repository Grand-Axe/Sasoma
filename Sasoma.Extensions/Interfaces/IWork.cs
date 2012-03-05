using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sasoma.Extensions.Interfaces
{
    public interface IWork
    {
        bool success { get; set; }
        string ErrorMessage { get; set; }
        void DoJob();
    }
}
