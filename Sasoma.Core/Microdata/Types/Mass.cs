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
	/// Properties that take Mass as values are of the form '<Number> <Mass unit of measure>'. E.g., '7 kg'
	/// </summary>
	public class Mass_Core : TypeCore, IQuantity
	{
		public Mass_Core()
		{
			this._TypeId = 159;
			this._Id = "Mass";
			this._Schema_Org_Url = "http://schema.org/Mass";
			string label = "";
			GetLabel(out label, "Mass", typeof(Mass_Core));
			this._Label = label;
			this._Ancestors = new int[]{266,138,219};
			this._SubTypes = new int[0];
			this._SuperTypes = new int[]{219};
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