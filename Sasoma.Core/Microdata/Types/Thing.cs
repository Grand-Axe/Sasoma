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
	/// The most generic type of item.
	/// </summary>
    public class Thing_Core : MicrodataCore, IThing
	{
		public int TypeId
		{
			get
			{
				return 266;
			}
		}

		public string Id
		{
			get
			{
				return "Thing";
			}
		}

		public string Schema_Org_Url
		{
			get
			{
				return "http://schema.org/Thing";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "Thing", typeof(Thing_Core));
				return label;
			}
		}

		public int[] Ancestors
		{
			get
			{
				return new int[0];
			}
		}

		public int[] SubTypes
		{
			get
			{
				return new int[]{78,98,138,193,201,206,215};
			}
		}

		public int[] SuperTypes
		{
			get
			{
				return new int[0];
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