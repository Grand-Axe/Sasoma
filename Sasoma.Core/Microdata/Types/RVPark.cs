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
	/// An RV park.
	/// </summary>
	public class RVPark_Core : TypeCore, ICivicStructure
	{
		public RVPark_Core()
		{
			this._TypeId = 220;
			this._Id = "RVPark";
			this._Schema_Org_Url = "http://schema.org/RVPark";
			string label = "";
			GetLabel(out label, "RVPark", typeof(RVPark_Core));
			this._Label = label;
			this._Ancestors = new int[]{266,206,62};
			this._SubTypes = new int[0];
			this._SuperTypes = new int[]{62};
			this._Properties = new int[]{67,108,143,229,5,10,49,85,91,98,115,135,159,199,196,152};

		}

		/// <summary>
		/// Physical address of the item.
		/// </summary>
		public Address_Core Address { get; set; }

		/// <summary>
		/// The overall rating, based on a collection of reviews or ratings, of the item.
		/// </summary>
		public Properties.AggregateRating_Core AggregateRating { get; set; }

		/// <summary>
		/// The basic containment relation between places.
		/// </summary>
		public ContainedIn_Core ContainedIn { get; set; }

		/// <summary>
		/// A short description of the item.
		/// </summary>
		public Description_Core Description { get; set; }

		/// <summary>
		/// Upcoming or past events associated with this place or organization.
		/// </summary>
		public Events_Core Events { get; set; }

		/// <summary>
		/// The fax number.
		/// </summary>
		public FaxNumber_Core FaxNumber { get; set; }

		/// <summary>
		/// The geo coordinates of the place.
		/// </summary>
		public Geo_Core Geo { get; set; }

		/// <summary>
		/// URL of an image of the item.
		/// </summary>
		public Image_Core Image { get; set; }

		/// <summary>
		/// A count of a specific user interactions with this item\u2014for example, <code>20 UserLikes</code>, <code>5 UserComments</code>, or <code>300 UserDownloads</code>. The user interaction type should be one of the sub types of <a href=\http://schema.org/UserInteraction\>UserInteraction</a>.
		/// </summary>
		public InteractionCount_Core InteractionCount { get; set; }

		/// <summary>
		/// A URL to a map of the place.
		/// </summary>
		public Maps_Core Maps { get; set; }

		/// <summary>
		/// The name of the item.
		/// </summary>
		public Name_Core Name { get; set; }

		/// <summary>
		/// The opening hours for a business. Opening hours can be specified as a weekly time range, starting with days, then times per day. Multiple days can be listed with commas ',' separating each day. Day or time ranges are specified using a hyphen '-'.<br/>- Days are specified using the following two-letter combinations: <code>Mo</code>, <code>Tu</code>, <code>We</code>, <code>Th</code>, <code>Fr</code>, <code>Sa</code>, <code>Su</code>.<br/>- Times are specified using 24:00 time. For example, 3pm is specified as <code>15:00</code>. <br/>- Here is an example: <code>&lt;time itemprop=\openingHours\ datetime=\Tu,Th 16:00-20:00\&gt;Tuesdays and Thursdays 4-8pm&lt;/time&gt;</code>. <br/>- If a business is open 7 days a week, then it can be specified as <code>&lt;time itemprop=\openingHours\ datetime=\Mo-Su\&gt;Monday through Sunday, all day&lt;/time&gt;</code>.
		/// </summary>
		public OpeningHours_Core OpeningHours { get; set; }

		/// <summary>
		/// Photographs of this place.
		/// </summary>
		public Photos_Core Photos { get; set; }

		/// <summary>
		/// Review of the item.
		/// </summary>
		public Reviews_Core Reviews { get; set; }

		/// <summary>
		/// The telephone number.
		/// </summary>
		public Telephone_Core Telephone { get; set; }

		/// <summary>
		/// URL of the item.
		/// </summary>
		public Properties.URL_Core URL { get; set; }

	}
}