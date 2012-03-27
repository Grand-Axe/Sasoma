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
	/// The average rating based on multiple ratings or reviews.
	/// </summary>
	public class AggregateRating_Core : TypeCore, IRating
	{
		public AggregateRating_Core()
		{
			this._TypeId = 13;
			this._Id = "AggregateRating";
			this._Schema_Org_Url = "http://schema.org/AggregateRating";
			string label = "";
			GetLabel(out label, "AggregateRating", typeof(AggregateRating_Core));
			this._Label = label;
			this._Ancestors = new int[]{266,138,222};
			this._SubTypes = new int[0];
			this._SuperTypes = new int[]{222};
			this._Properties = new int[]{67,108,143,229,29,183,239,123,182,195};

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
		/// The item that is being reviewed/rated.
		/// </summary>
		public ItemReviewed_Core ItemReviewed { get; set; }

		/// <summary>
		/// The name of the item.
		/// </summary>
		public Name_Core Name { get; set; }

		/// <summary>
		/// The count of total number of ratings.
		/// </summary>
		public RatingCount_Core RatingCount { get; set; }

		/// <summary>
		/// The rating for the content.
		/// </summary>
		public RatingValue_Core RatingValue { get; set; }

		/// <summary>
		/// The count of total number of reviews.
		/// </summary>
		public ReviewCount_Core ReviewCount { get; set; }

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