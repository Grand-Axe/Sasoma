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
	/// The rating of the video.
	/// </summary>
	public class Rating_Core : TypeCore, IIntangible
	{
		public int TypeId
		{
			get
			{
				return 222;
			}
		}

		public string Id
		{
			get
			{
				return "Rating";
			}
		}

		public string Schema_Org_Url
		{
			get
			{
				return "http://schema.org/Rating";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "Rating", typeof(Rating_Core));
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
				return new int[]{13};
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
				return new int[]{67,108,143,229,29,183,239};
			}
		}


		/// <summary>
		/// The highest value allowed in this rating system. If bestRating is omitted, 5 is assumed.
		/// </summary>
		public BestRating_Core BestRating { get; set; }

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
		/// The rating for the content.
		/// </summary>
		public RatingValue_Core RatingValue { get; set; }

		/// <summary>
		/// URL of the item.
		/// </summary>
		public Properties.URL_Core URL { get; set; }

		/// <summary>
		/// The lowest value allowed in this rating system. If worstRating is omitted, 1 is assumed.
		/// </summary>
		public WorstRating_Core WorstRating { get; set; }

	}
}