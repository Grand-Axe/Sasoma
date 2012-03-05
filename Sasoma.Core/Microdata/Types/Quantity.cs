using System;
using System.Globalization;
using System.Collections.Generic;

using Sasoma.Utils;
using Sasoma.Languages.Core;
using Sasoma.Microdata.Interfaces;
using Sasoma.Microdata.Properties;

namespace Sasoma.Microdata.Types
{
	/// <summary>
	/// Quantities such as distance, time, mass, weight, etc. Particular instances of say Mass are entities like '3 Kg' or '4 milligrams'.
	/// </summary>
	public class Quantity_Core : TypeCore, IIntangible
	{
		public int TypeId
		{
			get
			{
				return 219;
			}
		}

		public string Id
		{
			get
			{
				return "Quantity";
			}
		}

		public string Schema_Org_Url
		{
			get
			{
				return "http://schema.org/Quantity";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "Quantity", typeof(Quantity_Core));
				return label;
			}
		}

		public int[] Ancestors
		{
			get
			{
				return new int[]{266,138};
			}
		}

		public int[] SubTypes
		{
			get
			{
				return new int[]{76,86,95,159};
			}
		}

		public int[] SuperTypes
		{
			get
			{
				return new int[]{138};
			}
		}

		public int[] Properties
		{
			get
			{
				return new int[]{67,108,143,229};
			}
		}


		/// <summary>
		/// A short description of the item.
		/// </summary>
		public Description_Core Description { get; set; }

		/// <summary>
		/// URL of an image of the item.
		/// </summary>
		public Image_Core Image { get; set; }

		/// <summary>
		/// The name of the item.
		/// </summary>
		public Name_Core Name { get; set; }

		/// <summary>
		/// URL of the item.
		/// </summary>
		public Properties.URL_Core URL { get; set; }

	}
}