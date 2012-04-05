using System;
using System.Globalization;
using System.Collections.Generic;

using Sasoma.Utils;
using Sasoma.Microdata.Interfaces;
using Sasoma.Languages.Core;
using Sasoma.Microdata.Properties;

namespace Sasoma.Microdata.Types
{
	/// <summary>
	/// Quantity: Duration (use  <a href=\http://en.wikipedia.org/wiki/ISO_8601\ target=\new\>ISO 8601 duration format</a>).
	/// </summary>
	public class Duration_Core : TypeCore, IQuantity
	{
		public Duration_Core()
		{
			this._TypeId = 86;
			this._Id = "Duration";
			this._Schema_Org_Url = "http://schema.org/Duration";
			string label = "";
			GetLabel(out label, "Duration", typeof(Duration_Core));
			this._Label = label;
			this._Ancestors = new int[]{266,138,219};
			this._SubTypes = new int[0];
			this._SuperTypes = new int[]{219};
			this._Properties = new int[0];

		}

        /// <summary>
        /// A short description of the item.
        /// </summary>
        private Description_Core description;
        public Description_Core Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
                SetPropertyInstance(description);
            }
        }

        /// <summary>
        /// URL of an image of the item.
        /// </summary>
        private Image_Core image;
        public Image_Core Image
        {
            get
            {
                return image;
            }
            set
            {
                image = value;
                SetPropertyInstance(image);
            }
        }

        /// <summary>
        /// The name of the item.
        /// </summary>
        private Name_Core name;
        public Name_Core Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                SetPropertyInstance(name);
            }
        }

        /// <summary>
        /// URL of the item.
        /// </summary>
        private Properties.URL_Core uRL;
        public Properties.URL_Core URL
        {
            get
            {
                return uRL;
            }
            set
            {
                uRL = value;
                SetPropertyInstance(uRL);
            }
        }

	}
}