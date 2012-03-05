using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sasoma.Api
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="U"></typeparam>
    public struct KeyVal<T, U>
    {
        /// <summary>
        /// 
        /// </summary>
        public T Key;

        /// <summary>
        /// 
        /// </summary>
        public U Value;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="t"></param>
        /// <param name="u"></param>
        public KeyVal(T t, U u)
        {
            Key = t;
            Value = u;
        }
    }
}
