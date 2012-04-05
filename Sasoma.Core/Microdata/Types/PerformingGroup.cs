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
	/// A performance group, such as a band, an orchestra, or a circus.
	/// </summary>
	public class PerformingGroup_Core : TypeCore, IOrganization
	{
		public PerformingGroup_Core()
		{
			this._TypeId = 200;
			this._Id = "PerformingGroup";
			this._Schema_Org_Url = "http://schema.org/PerformingGroup";
			string label = "";
			GetLabel(out label, "PerformingGroup", typeof(PerformingGroup_Core));
			this._Label = label;
			this._Ancestors = new int[]{266,193};
			this._SubTypes = new int[]{81,176,265};
			this._SuperTypes = new int[]{193};
			this._Properties = new int[]{67,108,143,229,5,10,47,75,77,85,91,94,95,115,130,137,199,196};

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
		/// A contact point for a person or organization.
		/// </summary>
		private ContactPoints_Core contactPoints;
		public ContactPoints_Core ContactPoints
		{
			get
			{
				return contactPoints;
			}
			set
			{
				contactPoints = value;
				SetPropertyInstance(contactPoints);
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
		/// Email address.
		/// </summary>
		private Email_Core email;
		public Email_Core Email
		{
			get
			{
				return email;
			}
			set
			{
				email = value;
				SetPropertyInstance(email);
			}
		}

		/// <summary>
		/// People working for this organization.
		/// </summary>
		private Employees_Core employees;
		public Employees_Core Employees
		{
			get
			{
				return employees;
			}
			set
			{
				employees = value;
				SetPropertyInstance(employees);
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
		/// A person who founded this organization.
		/// </summary>
		private Founders_Core founders;
		public Founders_Core Founders
		{
			get
			{
				return founders;
			}
			set
			{
				founders = value;
				SetPropertyInstance(founders);
			}
		}

		/// <summary>
		/// The date that this organization was founded.
		/// </summary>
		private FoundingDate_Core foundingDate;
		public FoundingDate_Core FoundingDate
		{
			get
			{
				return foundingDate;
			}
			set
			{
				foundingDate = value;
				SetPropertyInstance(foundingDate);
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
		/// A member of this organization.
		/// </summary>
		private Members_Core members;
		public Members_Core Members
		{
			get
			{
				return members;
			}
			set
			{
				members = value;
				SetPropertyInstance(members);
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