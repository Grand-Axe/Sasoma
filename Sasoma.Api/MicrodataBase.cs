using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

using Sasoma.Utils;
using Sasoma.Api.Interfaces;
using Sasoma.Microdata.Types;
using Sasoma.Microdata.Interfaces;
using Sasoma.Extensions.Interfaces;

namespace Sasoma.Api
{
    public class MicrodataBase<T> : IValue
    {
        /// <summary>
        /// 
        /// </summary>
        public IDataType Value { get; set; }

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

    }
}
