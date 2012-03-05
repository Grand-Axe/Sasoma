using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

using Sasoma.Microdata.Interfaces;
using Sasoma.Microdata.Types;

namespace Sasoma.Api
{
    public struct GraphNode
    {
        public bool IsInitialized;
        public int ParentId;
        public int GraphNodeId;
        public int TypeId;
        public int PropertyId;
        public List<Edge> Edges;
        public IDataType Value;
    }
}
