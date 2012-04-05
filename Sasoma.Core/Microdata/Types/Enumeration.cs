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
	/// Lists or enumerations\u2014for example, a list of cuisines or music genres, etc.
	/// </summary>
	public class Enumeration_Core : TypeCore, IIntangible
	{
		public Enumeration_Core()
		{
			this._TypeId = 97;
			this._Id = "Enumeration";
			this._Schema_Org_Url = "http://schema.org/Enumeration";
			string label = "";
			GetLabel(out label, "Enumeration", typeof(Enumeration_Core));
			this._Label = label;
			this._Ancestors = new int[]{266,138};
			this._SubTypes = new int[]{42,140,190};
			this._SuperTypes = new int[]{138};
			this._Properties = new int[]{67,108,143,229};

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