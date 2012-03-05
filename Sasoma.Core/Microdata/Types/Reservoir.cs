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
	/// A reservoir, like the Lake Kariba reservoir.
	/// </summary>
	public class Reservoir_Core : TypeCore, IBodyOfWater
	{
		public int TypeId
		{
			get
			{
				return 226;
			}
		}

		public string Id
		{
			get
			{
				return "Reservoir";
			}
		}

		public string Schema_Org_Url
		{
			get
			{
				return "http://schema.org/Reservoir";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "Reservoir", typeof(Reservoir_Core));
				return label;
			}
		}

		public int[] Ancestors
		{
			get
			{
				return new int[]{266,206,146,40};
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
				return new int[]{40};
			}
		}

		public int[] Properties
		{
			get
			{
				return new int[]{67,108,143,229,5,10,49,85,91,98,115,135,159,199,196};
			}
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