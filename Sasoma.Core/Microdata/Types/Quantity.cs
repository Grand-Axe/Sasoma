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
	/// Quantities such as distance, time, mass, weight, etc. Particular instances of say Mass are entities like '3 Kg' or '4 milligrams'.
	/// </summary>
	public class Quantity_Core : TypeCore, IIntangible
	{
		public Quantity_Core()
		{
			this._TypeId = 219;
			this._Id = "Quantity";
			this._Schema_Org_Url = "http://schema.org/Quantity";
			string label = "";
			GetLabel(out label, "Quantity", typeof(Quantity_Core));
			this._Label = label;
			this._Ancestors = new int[]{266,138};
			this._SubTypes = new int[]{76,86,95,159};
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