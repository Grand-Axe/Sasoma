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
	/// Event type: Business event.
	/// </summary>
	public class BusinessEvent_Core : TypeCore, IEvent
	{
		public BusinessEvent_Core()
		{
			this._TypeId = 49;
			this._Id = "BusinessEvent";
			this._Schema_Org_Url = "http://schema.org/BusinessEvent";
			string label = "";
			GetLabel(out label, "BusinessEvent", typeof(BusinessEvent_Core));
			this._Label = label;
			this._Ancestors = new int[]{266,98};
			this._SubTypes = new int[0];
			this._SuperTypes = new int[]{98};
			this._Properties = new int[]{67,108,143,229,19,71,82,130,151,158,214,216,218};

		}

		/// <summary>
		/// A person attending the event.
		/// </summary>
		private Attendees_Core attendees;
		public Attendees_Core Attendees
		{
			get
			{
				return attendees;
			}
			set
			{
				attendees = value;
				SetPropertyInstance(attendees);
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
		/// The duration of the item (movie, audio recording, event, etc.) in <a href=\http://en.wikipedia.org/wiki/ISO_8601\ target=\new\>ISO 8601 date format</a>.
		/// </summary>
		private Properties.Duration_Core duration;
		public Properties.Duration_Core Duration
		{
			get
			{
				return duration;
			}
			set
			{
				duration = value;
				SetPropertyInstance(duration);
			}
		}

		/// <summary>
		/// The end date and time of the event (in <a href=\http://en.wikipedia.org/wiki/ISO_8601\ target=\new\>ISO 8601 date format</a>).
		/// </summary>
		private EndDate_Core endDate;
		public EndDate_Core EndDate
		{
			get
			{
				return endDate;
			}
			set
			{
				endDate = value;
				SetPropertyInstance(endDate);
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
		/// The location of the event or organization.
		/// </summary>
		private Location_Core location;
		public Location_Core Location
		{
			get
			{
				return location;
			}
			set
			{
				location = value;
				SetPropertyInstance(location);
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
		/// An offer to sell this item\u2014for example, an offer to sell a product, the DVD of a movie, or tickets to an event.
		/// </summary>
		private Offers_Core offers;
		public Offers_Core Offers
		{
			get
			{
				return offers;
			}
			set
			{
				offers = value;
				SetPropertyInstance(offers);
			}
		}

		/// <summary>
		/// The main performer or performers of the event\u2014for example, a presenter, musician, or actor.
		/// </summary>
		private Performers_Core performers;
		public Performers_Core Performers
		{
			get
			{
				return performers;
			}
			set
			{
				performers = value;
				SetPropertyInstance(performers);
			}
		}

		/// <summary>
		/// The start date and time of the event (in <a href=\http://en.wikipedia.org/wiki/ISO_8601\ target=\new\>ISO 8601 date format</a>).
		/// </summary>
		private StartDate_Core startDate;
		public StartDate_Core StartDate
		{
			get
			{
				return startDate;
			}
			set
			{
				startDate = value;
				SetPropertyInstance(startDate);
			}
		}

		/// <summary>
		/// Events that are a part of this event. For example, a conference event includes many presentations, each are subEvents of the conference.
		/// </summary>
		private SubEvents_Core subEvents;
		public SubEvents_Core SubEvents
		{
			get
			{
				return subEvents;
			}
			set
			{
				subEvents = value;
				SetPropertyInstance(subEvents);
			}
		}

		/// <summary>
		/// An event that this event is a part of. For example, a collection of individual music performances might each have a music festival as their superEvent.
		/// </summary>
		private SuperEvent_Core superEvent;
		public SuperEvent_Core SuperEvent
		{
			get
			{
				return superEvent;
			}
			set
			{
				superEvent = value;
				SetPropertyInstance(superEvent);
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