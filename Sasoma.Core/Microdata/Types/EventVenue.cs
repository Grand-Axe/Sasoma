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
	/// An event venue.
	/// </summary>
	public class EventVenue_Core : TypeCore, ICivicStructure
	{
		public EventVenue_Core()
		{
			this._TypeId = 99;
			this._Id = "EventVenue";
			this._Schema_Org_Url = "http://schema.org/EventVenue";
			string label = "";
			GetLabel(out label, "EventVenue", typeof(EventVenue_Core));
			this._Label = label;
			this._Ancestors = new int[]{266,206,62};
			this._SubTypes = new int[0];
			this._SuperTypes = new int[]{62};
			this._Properties = new int[]{67,108,143,229,5,10,49,85,91,98,115,135,159,199,196,152};

		}

		/// <summary>
		/// Physical address of the item.
		/// </summary>
		private Address_Core address;
		public Address_Core Address
		{
			get
			{
				return address;
			}
			set
			{
				address = value;
				SetPropertyInstance(address);
			}
		}

		/// <summary>
		/// The overall rating, based on a collection of reviews or ratings, of the item.
		/// </summary>
		private Properties.AggregateRating_Core aggregateRating;
		public Properties.AggregateRating_Core AggregateRating
		{
			get
			{
				return aggregateRating;
			}
			set
			{
				aggregateRating = value;
				SetPropertyInstance(aggregateRating);
			}
		}

		/// <summary>
		/// The basic containment relation between places.
		/// </summary>
		private ContainedIn_Core containedIn;
		public ContainedIn_Core ContainedIn
		{
			get
			{
				return containedIn;
			}
			set
			{
				containedIn = value;
				SetPropertyInstance(containedIn);
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
		/// Upcoming or past events associated with this place or organization.
		/// </summary>
		private Events_Core events;
		public Events_Core Events
		{
			get
			{
				return events;
			}
			set
			{
				events = value;
				SetPropertyInstance(events);
			}
		}

		/// <summary>
		/// The fax number.
		/// </summary>
		private FaxNumber_Core faxNumber;
		public FaxNumber_Core FaxNumber
		{
			get
			{
				return faxNumber;
			}
			set
			{
				faxNumber = value;
				SetPropertyInstance(faxNumber);
			}
		}

		/// <summary>
		/// The geo coordinates of the place.
		/// </summary>
		private Geo_Core geo;
		public Geo_Core Geo
		{
			get
			{
				return geo;
			}
			set
			{
				geo = value;
				SetPropertyInstance(geo);
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
		/// A count of a specific user interactions with this item\u2014for example, <code>20 UserLikes</code>, <code>5 UserComments</code>, or <code>300 UserDownloads</code>. The user interaction type should be one of the sub types of <a href=\http://schema.org/UserInteraction\>UserInteraction</a>.
		/// </summary>
		private InteractionCount_Core interactionCount;
		public InteractionCount_Core InteractionCount
		{
			get
			{
				return interactionCount;
			}
			set
			{
				interactionCount = value;
				SetPropertyInstance(interactionCount);
			}
		}

		/// <summary>
		/// A URL to a map of the place.
		/// </summary>
		private Maps_Core maps;
		public Maps_Core Maps
		{
			get
			{
				return maps;
			}
			set
			{
				maps = value;
				SetPropertyInstance(maps);
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
		/// The opening hours for a business. Opening hours can be specified as a weekly time range, starting with days, then times per day. Multiple days can be listed with commas ',' separating each day. Day or time ranges are specified using a hyphen '-'.<br/>- Days are specified using the following two-letter combinations: <code>Mo</code>, <code>Tu</code>, <code>We</code>, <code>Th</code>, <code>Fr</code>, <code>Sa</code>, <code>Su</code>.<br/>- Times are specified using 24:00 time. For example, 3pm is specified as <code>15:00</code>. <br/>- Here is an example: <code>&lt;time itemprop=\openingHours\ datetime=\Tu,Th 16:00-20:00\&gt;Tuesdays and Thursdays 4-8pm&lt;/time&gt;</code>. <br/>- If a business is open 7 days a week, then it can be specified as <code>&lt;time itemprop=\openingHours\ datetime=\Mo-Su\&gt;Monday through Sunday, all day&lt;/time&gt;</code>.
		/// </summary>
		private OpeningHours_Core openingHours;
		public OpeningHours_Core OpeningHours
		{
			get
			{
				return openingHours;
			}
			set
			{
				openingHours = value;
				SetPropertyInstance(openingHours);
			}
		}

		/// <summary>
		/// Photographs of this place.
		/// </summary>
		private Photos_Core photos;
		public Photos_Core Photos
		{
			get
			{
				return photos;
			}
			set
			{
				photos = value;
				SetPropertyInstance(photos);
			}
		}

		/// <summary>
		/// Review of the item.
		/// </summary>
		private Reviews_Core reviews;
		public Reviews_Core Reviews
		{
			get
			{
				return reviews;
			}
			set
			{
				reviews = value;
				SetPropertyInstance(reviews);
			}
		}

		/// <summary>
		/// The telephone number.
		/// </summary>
		private Telephone_Core telephone;
		public Telephone_Core Telephone
		{
			get
			{
				return telephone;
			}
			set
			{
				telephone = value;
				SetPropertyInstance(telephone);
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

	}
}