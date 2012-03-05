using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

using Sasoma.Microdata.Interfaces;

namespace Sasoma.Api
{
    /// <summary>
    /// Microdata Property class that is exposed for instantiation.
    /// </summary>
    /// <typeparam name="T">The microdata property class.</typeparam>
    /// <typeparam name="U">Type for input.</typeparam>
    public class MicrodataProperty<T> : MicrodataBase<T> where T : IProperty
    {
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
        public MicrodataProperty()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="t"></param>
        /// <param name="u"></param>
        public MicrodataProperty(T t)
        {
            entity = t;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public virtual string GetProtocolBuffer()
        {
            return GetProtocolBuffer(Entity.PropertyId);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public virtual string GetJson()
        {
            return GetJson(Entity.PropertyId);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public virtual string GetMarkup()
        {
            return GetMarkup(Entity.PropertyId);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public virtual string GetProtocolBuffer(int id)
        {
            throw new NotImplementedException();
            return String.Empty;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public virtual string GetJson(int id)
        {
            throw new NotImplementedException();
            return String.Empty;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public virtual string GetMarkup(int id)
        {
            throw new NotImplementedException();
            return String.Empty;
        }

    }
}
