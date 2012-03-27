using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

using Sasoma.Utils;
using Sasoma.Api.Interfaces;
using Sasoma.Microdata.Types;
using Sasoma.Microdata.Interfaces;
using System.ComponentModel.Composition;
using Sasoma.Microdata;

namespace Sasoma.Api
{
    public class MicrodataMethods<T> 
    {
        /// <summary>
        /// Gets the text or error message for this item.
        /// </summary>
        /// <param name="resourceString">Base name of the resx file.</param>
        /// <param name="type">Calling type.</param>
        /// <returns></returns>
        public string GetResourceText(string resourceString, Type type)
        {
            string temp = String.Empty;
            object value = CultureManager.GetResourceString(resourceString, type, "Sasoma.Api.Languages.ErrorMessages");
            if (value != null)
                return value.ToString();
            return temp;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="W"></typeparam>
        /// <param name="work"></param>
        public void DoJob<W>(W work) where W : IWork
        {
            work.DoJob();
        }

        /// <summary>
        /// The layout text for this item.
        /// </summary>
        /// <typeparam name="U"></typeparam>
        /// <param name="work"></param>
        public void Write<W>(W work) where W : IWriter<W>
        {
            work.Write(work);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public virtual string GetProtocolBuffer(PropertyCore property)
        {
            return GetProtocolBuffer(property.PropertyId);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public virtual string GetJson(PropertyCore property)
        {
            return GetJson(property.PropertyId);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public virtual string GetMarkup(PropertyCore property)
        {
            return GetMarkup(property.PropertyId);
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="method"></param>
        /// <returns></returns>
        protected virtual string GetString(Func<int, string> method, TypeCore type)
        {
            int propertyId = 0;
            string s = String.Empty;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < type.Properties.Length; i++)
            {
                propertyId = type.Properties[i];
                s = method(propertyId);
                sb.Append(s);
            }
            return sb.ToString();
        }

    }
}