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
	/// A musical group, such as a band, an orchestra, or a choir. Can also be a solo musician.
	/// </summary>
	public class MusicGroup_Core : TypeCore, IPerformingGroup
	{
		public MusicGroup_Core()
		{
			this._TypeId = 176;
			this._Id = "MusicGroup";
			this._Schema_Org_Url = "http://schema.org/MusicGroup";
			string label = "";
			GetLabel(out label, "MusicGroup", typeof(MusicGroup_Core));
			this._Label = label;
			this._Ancestors = new int[]{266,193,200};
			this._SubTypes = new int[0];
			this._SuperTypes = new int[]{200};
			this._Properties = new int[]{67,108,143,229,5,10,47,75,77,85,91,94,95,115,130,137,199,196,11,142,223};

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
		/// A collection of music albums.
		/// </summary>
		public Albums_Core Albums { get; set; }

		/// <summary>
		/// A contact point for a person or organization.
		/// </summary>
		public ContactPoints_Core ContactPoints { get; set; }

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
		/// A member of this organization.
		/// </summary>
		public Members_Core Members { get; set; }

		/// <summary>
		/// A member of the music group\u2014for example, John, Paul, George, or Ringo.
		/// </summary>
		public MusicGroupMember_Core MusicGroupMember { get; set; }

		/// <summary>
		/// The name of the item.
		/// </summary>
		public Name_Core Name { get; set; }

		/// <summary>
		/// Review of the item.
		/// </summary>
		public Reviews_Core Reviews { get; set; }

		/// <summary>
		/// The telephone number.
		/// </summary>
		public Telephone_Core Telephone { get; set; }

		/// <summary>
		/// A music recording (track)\u2014usually a single song.
		/// </summary>
		public Tracks_Core Tracks { get; set; }

		/// <summary>
		/// URL of the item.
		/// </summary>
		public Properties.URL_Core URL { get; set; }

	}
}