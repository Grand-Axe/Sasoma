using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Sasoma.Api.Interfaces;

namespace Sasoma.Api
{
    /// <summary>
    /// If we use the type T, we could do away with the delegates
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Edge
    {
        public int EdgeId;
        public int EdgeTypeId;
        public int StartGraphNodeId;
        public int EndGraphNodeId;
        public bool success = false;
        public string ErrorMessage = String.Empty;

        public Edge()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="U"></typeparam>
        /// <param name="work"></param>
        public void Write<U>(U work) where U : IWriter<U>
        {
            work.Write(work);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="U"></typeparam>
        /// <param name="work"></param>
        public void DoJob<U>(U work) where U : IWork
        {
            work.DoJob();
        }

    }
}
