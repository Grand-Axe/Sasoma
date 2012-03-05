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
	/// Lists or enumerations\u2014for example, a list of cuisines or music genres, etc.
	/// </summary>
	public class Enumeration_Core : TypeCore, IIntangible
	{
		public int TypeId
		{
			get
			{
				return 97;
			}
		}

		public string Id
		{
			get
			{
				return "Enumeration";
			}
		}

		public string Schema_Org_Url
		{
			get
			{
				return "http://schema.org/Enumeration";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "Enumeration", typeof(Enumeration_Core));
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
				return new int[]{42,140,190};
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