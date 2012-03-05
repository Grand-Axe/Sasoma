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
	/// A person (alive, dead, undead, or fictional).
	/// </summary>
	public class Person_Core : TypeCore, IThing
	{
		public int TypeId
		{
			get
			{
				return 201;
			}
		}

		public string Id
		{
			get
			{
				return "Person";
			}
		}

		public string Schema_Org_Url
		{
			get
			{
				return "http://schema.org/Person";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "Person", typeof(Person_Core));
				return label;
			}
		}

		public int[] Ancestors
		{
			get
			{
				return new int[]{266};
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
				return new int[]{266};
			}
		}

		public int[] Properties
		{
			get
			{
				return new int[]{67,108,143,229,4,5,9,14,26,30,43,46,47,66,75,89,91,93,96,99,104,105,106,115,125,127,136,144,153,157,189,207,213,196,237,238};
			}
		}


		/// <summary>
		/// An additional name for a Person, can be used for a middle name.
		/// </summary>
		public AdditionalName_Core AdditionalName { get; set; }

		/// <summary>
		/// Physical address of the item.
		/// </summary>
		public Address_Core Address { get; set; }

		/// <summary>
		/// An organization that this person is affiliated with. For example, a school/university, a club, or a team.
		/// </summary>
		public Affiliation_Core Affiliation { get; set; }

		/// <summary>
		/// An educational organizations that the person is an alumni of.
		/// </summary>
		public AlumniOf_Core AlumniOf { get; set; }

		/// <summary>
		/// Awards won by this person or for this creative work.
		/// </summary>
		public Awards_Core Awards { get; set; }

		/// <summary>
		/// Date of birth.
		/// </summary>
		public BirthDate_Core BirthDate { get; set; }

		/// <summary>
		/// A child of the person.
		/// </summary>
		public Children_Core Children { get; set; }

		/// <summary>
		/// A colleague of the person.
		/// </summary>
		public Colleagues_Core Colleagues { get; set; }

		/// <summary>
		/// A contact point for a person or organization.
		/// </summary>
		public ContactPoints_Core ContactPoints { get; set; }

		/// <summary>
		/// Date of death.
		/// </summary>
		public DeathDate_Core DeathDate { get; set; }

		/// <summary>
		/// A short description of the item.
		/// </summary>
		public Description_Core Description { get; set; }

		/// <summary>
		/// Email address.
		/// </summary>
		public Email_Core Email { get; set; }

		/// <summary>
		/// Family name. In the U.S., the last name of an Person. This can be used along with givenName instead of the Name property.
		/// </summary>
		public FamilyName_Core FamilyName { get; set; }

		/// <summary>
		/// The fax number.
		/// </summary>
		public FaxNumber_Core FaxNumber { get; set; }

		/// <summary>
		/// The most generic uni-directional social relation.
		/// </summary>
		public Follows_Core Follows { get; set; }

		/// <summary>
		/// Gender of the person.
		/// </summary>
		public Gender_Core Gender { get; set; }

		/// <summary>
		/// Given name. In the U.S., the first name of a Person. This can be used along with familyName instead of the Name property.
		/// </summary>
		public GivenName_Core GivenName { get; set; }

		/// <summary>
		/// A contact location for a person's residence.
		/// </summary>
		public HomeLocation_Core HomeLocation { get; set; }

		/// <summary>
		/// An honorific prefix preceding a Person's name such as Dr/Mrs/Mr.
		/// </summary>
		public HonorificPrefix_Core HonorificPrefix { get; set; }

		/// <summary>
		/// An honorific suffix preceding a Person's name such as M.D. /PhD/MSCSW.
		/// </summary>
		public HonorificSuffix_Core HonorificSuffix { get; set; }

		/// <summary>
		/// URL of an image of the item.
		/// </summary>
		public Image_Core Image { get; set; }

		/// <summary>
		/// A count of a specific user interactions with this item\u2014for example, <code>20 UserLikes</code>, <code>5 UserComments</code>, or <code>300 UserDownloads</code>. The user interaction type should be one of the sub types of <a href=\http://schema.org/UserInteraction\>UserInteraction</a>.
		/// </summary>
		public InteractionCount_Core InteractionCount { get; set; }

		/// <summary>
		/// The job title of the person (for example, Financial Manager).
		/// </summary>
		public JobTitle_Core JobTitle { get; set; }

		/// <summary>
		/// The most generic bi-directional social/work relation.
		/// </summary>
		public Knows_Core Knows { get; set; }

		/// <summary>
		/// An organization to which the person belongs.
		/// </summary>
		public MemberOf_Core MemberOf { get; set; }

		/// <summary>
		/// The name of the item.
		/// </summary>
		public Name_Core Name { get; set; }

		/// <summary>
		/// Nationality of the person.
		/// </summary>
		public Nationality_Core Nationality { get; set; }

		/// <summary>
		/// A parents of the person.
		/// </summary>
		public Parents_Core Parents { get; set; }

		/// <summary>
		/// Event that this person is a performer or participant in.
		/// </summary>
		public PerformerIn_Core PerformerIn { get; set; }

		/// <summary>
		/// The most generic familial relation.
		/// </summary>
		public RelatedTo_Core RelatedTo { get; set; }

		/// <summary>
		/// A sibling of the person.
		/// </summary>
		public Siblings_Core Siblings { get; set; }

		/// <summary>
		/// The person's spouse.
		/// </summary>
		public Spouse_Core Spouse { get; set; }

		/// <summary>
		/// The telephone number.
		/// </summary>
		public Telephone_Core Telephone { get; set; }

		/// <summary>
		/// URL of the item.
		/// </summary>
		public Properties.URL_Core URL { get; set; }

		/// <summary>
		/// A contact location for a person's place of work.
		/// </summary>
		public WorkLocation_Core WorkLocation { get; set; }

		/// <summary>
		/// Organizations that the person works for.
		/// </summary>
		public WorksFor_Core WorksFor { get; set; }

	}
}