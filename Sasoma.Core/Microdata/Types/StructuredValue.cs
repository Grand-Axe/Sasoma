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
	/// Structured values are strings\u2014for example, addresses\u2014that have certain constraints on their structure.
	/// </summary>
	public class StructuredValue_Core : TypeCore, IIntangible
	{
		public int TypeId
		{
			get
			{
				return 253;
			}
		}

		public string Id
		{
			get
			{
				return "StructuredValue";
			}
		}

		public string Schema_Org_Url
		{
			get
			{
				return "http://schema.org/StructuredValue";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "StructuredValue", typeof(StructuredValue_Core));
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
				return new int[]{70,113,114,187};
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