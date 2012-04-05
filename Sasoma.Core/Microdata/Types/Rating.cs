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
	/// The rating of the video.
	/// </summary>
	public class Rating_Core : TypeCore, IIntangible
	{
		public Rating_Core()
		{
			this._TypeId = 222;
			this._Id = "Rating";
			this._Schema_Org_Url = "http://schema.org/Rating";
			string label = "";
			GetLabel(out label, "Rating", typeof(Rating_Core));
			this._Label = label;
			this._Ancestors = new int[]{266,138};
			this._SubTypes = new int[]{13};
			this._SuperTypes = new int[]{138};
			this._Properties = new int[]{67,108,143,229,29,183,239};

		}

		/// <summary>
		/// The highest value allowed in this rating system. If bestRating is omitted, 5 is assumed.
		/// </summary>
		private BestRating_Core bestRating;
		public BestRating_Core BestRating
		{
			get
			{
				return bestRating;
			}
			set
			{
				bestRating = value;
				SetPropertyInstance(bestRating);
			}
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
		/// The rating for the content.
		/// </summary>
		private RatingValue_Core ratingValue;
		public RatingValue_Core RatingValue
		{
			get
			{
				return ratingValue;
			}
			set
			{
				ratingValue = value;
				SetPropertyInstance(ratingValue);
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

		/// <summary>
		/// The lowest value allowed in this rating system. If worstRating is omitted, 1 is assumed.
		/// </summary>
		private WorstRating_Core worstRating;
		public WorstRating_Core WorstRating
		{
			get
			{
				return worstRating;
			}
			set
			{
				worstRating = value;
				SetPropertyInstance(worstRating);
			}
		}

	}
}