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
	/// An ice cream shop
	/// </summary>
	public class IceCreamShop_Core : TypeCore, IFoodEstablishment
	{
		public int TypeId
		{
			get
			{
				return 134;
			}
		}

		public string Id
		{
			get
			{
				return "IceCreamShop";
			}
		}

		public string Schema_Org_Url
		{
			get
			{
				return "http://schema.org/IceCreamShop";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "IceCreamShop", typeof(IceCreamShop_Core));
				return label;
			}
		}

		public int[] Ancestors
		{
			get
			{
				return new int[]{266,193,155,106};
			}
		}

		public int[] SubTypes
		{
			get
			{
				return new int[0];
			}
		}

		public int[] SuperTypes
		{
			get
			{
				return new int[]{106};
			}
		}

		public int[] Properties
		{
			get
			{
				return new int[]{67,108,143,229,5,10,49,85,91,98,115,135,159,199,196,47,75,77,94,95,130,137,36,60,152,156,167,1,139,205};
			}
		}


		/// <summary>
		/// Either <code>Yes/No</code>, or a URL at which reservations can be made.
		/// </summary>
		public AcceptsReservations_Core AcceptsReservations { get; set; }

		/// <summary>
		/// Physical address of the item.
		/// </summary>
		public Address_Core Address { get; set; }

		/// <summary>
		/// The overall rating, based on a collection of reviews or ratings, of the item.
		/// </summary>
		public Properties.AggregateRating_Core AggregateRating { get; set; }

		/// <summary>
		/// The larger organization that this local business is a branch of, if any.
		/// </summary>
		public BranchOf_Core BranchOf { get; set; }

		/// <summary>
		/// A contact point for a person or organization.
		/// </summary>
		public ContactPoints_Core ContactPoints { get; set; }

		/// <summary>
		/// The basic containment relation between places.
		/// </summary>
		public ContainedIn_Core ContainedIn { get; set; }

		/// <summary>
		/// The currency accepted (in <a href=\http://en.wikipedia.org/wiki/ISO_4217\ target=\new\>ISO 4217 currency format</a>).
		/// </summary>
		public CurrenciesAccepted_Core CurrenciesAccepted { get; set; }

		/// <summary>
		/// A short description of the item.
		/// </summary>
		public Description_Core Description { get; set; }

		/// <summary>
		/// Email address.
		/// </summary>
		public Email_Core Email { get; set; }

		/// <summary>
		/// People working for this organization.
		/// </summary>
		public Employees_Core Employees { get; set; }

		/// <summary>
		/// Upcoming or past events associated with this place or organization.
		/// </summary>
		public Events_Core Events { get; set; }

		/// <summary>
		/// The fax number.
		/// </summary>
		public FaxNumber_Core FaxNumber { get; set; }

		/// <summary>
		/// A person who founded this organization.
		/// </summary>
		public Founders_Core Founders { get; set; }

		/// <summary>
		/// The date that this organization was founded.
		/// </summary>
		public FoundingDate_Core FoundingDate { get; set; }

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
		/// The location of the event or organization.
		/// </summary>
		public Location_Core Location { get; set; }

		/// <summary>
		/// A URL to a map of the place.
		/// </summary>
		public Maps_Core Maps { get; set; }

		/// <summary>
		/// A member of this organization.
		/// </summary>
		public Members_Core Members { get; set; }

		/// <summary>
		/// Either the actual menu or a URL of the menu.
		/// </summary>
		public Menu_Core Menu { get; set; }

		/// <summary>
		/// The name of the item.
		/// </summary>
		public Name_Core Name { get; set; }

		/// <summary>
		/// The opening hours for a business. Opening hours can be specified as a weekly time range, starting with days, then times per day. Multiple days can be listed with commas ',' separating each day. Day or time ranges are specified using a hyphen '-'.<br/>- Days are specified using the following two-letter combinations: <code>Mo</code>, <code>Tu</code>, <code>We</code>, <code>Th</code>, <code>Fr</code>, <code>Sa</code>, <code>Su</code>.<br/>- Times are specified using 24:00 time. For example, 3pm is specified as <code>15:00</code>. <br/>- Here is an example: <code>&lt;time itemprop=\openingHours\ datetime=\Tu,Th 16:00-20:00\&gt;Tuesdays and Thursdays 4-8pm&lt;/time&gt;</code>. <br/>- If a business is open 7 days a week, then it can be specified as <code>&lt;time itemprop=\openingHours\ datetime=\Mo-Su\&gt;Monday through Sunday, all day&lt;/time&gt;</code>.
		/// </summary>
		public OpeningHours_Core OpeningHours { get; set; }

		/// <summary>
		/// Cash, credit card, etc.
		/// </summary>
		public PaymentAccepted_Core PaymentAccepted { get; set; }

		/// <summary>
		/// Photographs of this place.
		/// </summary>
		public Photos_Core Photos { get; set; }

		/// <summary>
		/// The price range of the business, for example <code>$$$</code>.
		/// </summary>
		public PriceRange_Core PriceRange { get; set; }

		/// <summary>
		/// Review of the item.
		/// </summary>
		public Reviews_Core Reviews { get; set; }

		/// <summary>
		/// The cuisine of the restaurant.
		/// </summary>
		public ServesCuisine_Core ServesCuisine { get; set; }

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