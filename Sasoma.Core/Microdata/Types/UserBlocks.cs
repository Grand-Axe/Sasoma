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
	/// User interaction: Block this content.
	/// </summary>
	public class UserBlocks_Core : TypeCore, IUserInteraction
	{
		public int TypeId
		{
			get
			{
				return 273;
			}
		}

		public string Id
		{
			get
			{
				return "UserBlocks";
			}
		}

		public string Schema_Org_Url
		{
			get
			{
				return "http://schema.org/UserBlocks";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "UserBlocks", typeof(UserBlocks_Core));
				return label;
			}
		}

		public int[] Ancestors
		{
			get
			{
				return new int[]{266,98,277};
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
				return new int[]{277};
			}
		}

		public int[] Properties
		{
			get
			{
				return new int[]{67,108,143,229,19,71,82,130,151,158,214,216,218};
			}
		}


		/// <summary>
		/// A person attending the event.
		/// </summary>
		public Attendees_Core Attendees { get; set; }

		/// <summary>
		/// A short description of the item.
		/// </summary>
		public Description_Core Description { get; set; }

		/// <summary>
		/// The duration of the item (movie, audio recording, event, etc.) in <a href=\http://en.wikipedia.org/wiki/ISO_8601\ target=\new\>ISO 8601 date format</a>.
		/// </summary>
		public Properties.Duration_Core Duration { get; set; }

		/// <summary>
		/// The end date and time of the event (in <a href=\http://en.wikipedia.org/wiki/ISO_8601\ target=\new\>ISO 8601 date format</a>).
		/// </summary>
		public EndDate_Core EndDate { get; set; }

		/// <summary>
		/// URL of an image of the item.
		/// </summary>
		public Image_Core Image { get; set; }

		/// <summary>
		/// The location of the event or organization.
		/// </summary>
		public Location_Core Location { get; set; }

		/// <summary>
		/// The name of the item.
		/// </summary>
		public Name_Core Name { get; set; }

		/// <summary>
		/// An offer to sell this item\u2014for example, an offer to sell a product, the DVD of a movie, or tickets to an event.
		/// </summary>
		public Offers_Core Offers { get; set; }

		/// <summary>
		/// The main performer or performers of the event\u2014for example, a presenter, musician, or actor.
		/// </summary>
		public Performers_Core Performers { get; set; }

		/// <summary>
		/// The start date and time of the event (in <a href=\http://en.wikipedia.org/wiki/ISO_8601\ target=\new\>ISO 8601 date format</a>).
		/// </summary>
		public StartDate_Core StartDate { get; set; }

		/// <summary>
		/// Events that are a part of this event. For example, a conference event includes many presentations, each are subEvents of the conference.
		/// </summary>
		public SubEvents_Core SubEvents { get; set; }

		/// <summary>
		/// An event that this event is a part of. For example, a collection of individual music performances might each have a music festival as their superEvent.
		/// </summary>
		public SuperEvent_Core SuperEvent { get; set; }

		/// <summary>
		/// URL of the item.
		/// </summary>
		public Properties.URL_Core URL { get; set; }

	}
}