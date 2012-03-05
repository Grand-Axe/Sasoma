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
	/// A utility class that serves as the umbrella for a number of 'intangible' things such as quantities, structured values, etc.
	/// </summary>
	public class Intangible_Core : TypeCore, IThing
	{
		public int TypeId
		{
			get
			{
				return 138;
			}
		}

		public string Id
		{
			get
			{
				return "Intangible";
			}
		}

		public string Schema_Org_Url
		{
			get
			{
				return "http://schema.org/Intangible";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "Intangible", typeof(Intangible_Core));
				return label;
			}
		}

		public int[] Ancestors
		{
			get
			{
				return new int[]{266};
			}
		}

		public int[] SubTypes
		{
			get
			{
				return new int[]{97,144,148,189,219,222,253};
			}
		}

		public int[] SuperTypes
		{
			get
			{
				return new int[]{266};
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