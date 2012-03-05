using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

using Sasoma.Microdata.Interfaces;

namespace Sasoma.Api
{
    /// <summary>
    /// Microdata Type class that is exposed for instantiation.
    /// </summary>
    /// <typeparam name="T">The microdata property class.</typeparam>
    /// <typeparam name="U">Type for input.</typeparam>
    public class MicrodataType<T> : MicrodataBase<T> where T : IMicrodata
    {
        private MicrodataProperty<IProperty> prop = new MicrodataProperty<IProperty>();
        private T entity;

        /// <summary>
        /// 
        /// </summary>
        public T Entity
        {
            get
            {
                return entity;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="t"></param>
        /// <param name="u"></param>
        public MicrodataType(T t)
        {
            entity = t;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public virtual string GetProtocolBuffer()
        {
            throw new NotImplementedException();
            string s = GetString(prop.GetProtocolBuffer);
            return s;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public virtual string GetJson()
        {
            throw new NotImplementedException();
            string s = GetString(prop.GetJson);
            return s;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public virtual string GetMarkup()
        {
            throw new NotImplementedException();
            string s = GetString(prop.GetMarkup);
            return s;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="method"></param>
        /// <returns></returns>
        protected virtual string GetString(Func<int, string> method)
        {
            int propertyId = 0;
            string s = String.Empty;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < Entity.Properties.Length; i++)
            {
                propertyId = Entity.Properties[i];
                s = method(propertyId);
                sb.Append(s);
            }
            return sb.ToString();
        }
    
    }
}
