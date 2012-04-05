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
	/// A person (alive, dead, undead, or fictional).
	/// </summary>
	public class Person_Core : TypeCore, IThing
	{
		public Person_Core()
		{
			this._TypeId = 201;
			this._Id = "Person";
			this._Schema_Org_Url = "http://schema.org/Person";
			string label = "";
			GetLabel(out label, "Person", typeof(Person_Core));
			this._Label = label;
			this._Ancestors = new int[]{266};
			this._SubTypes = new int[0];
			this._SuperTypes = new int[]{266};
			this._Properties = new int[]{67,108,143,229,4,5,9,14,26,30,43,46,47,66,75,89,91,93,96,99,104,105,106,115,125,127,136,144,153,157,189,207,213,196,237,238};

		}

		/// <summary>
		/// An additional name for a Person, can be used for a middle name.
		/// </summary>
		private AdditionalName_Core additionalName;
		public AdditionalName_Core AdditionalName
		{
			get
			{
				return additionalName;
			}
			set
			{
				additionalName = value;
				SetPropertyInstance(additionalName);
			}
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
		/// An organization that this person is affiliated with. For example, a school/university, a club, or a team.
		/// </summary>
		private Affiliation_Core affiliation;
		public Affiliation_Core Affiliation
		{
			get
			{
				return affiliation;
			}
			set
			{
				affiliation = value;
				SetPropertyInstance(affiliation);
			}
		}

		/// <summary>
		/// An educational organizations that the person is an alumni of.
		/// </summary>
		private AlumniOf_Core alumniOf;
		public AlumniOf_Core AlumniOf
		{
			get
			{
				return alumniOf;
			}
			set
			{
				alumniOf = value;
				SetPropertyInstance(alumniOf);
			}
		}

		/// <summary>
		/// Awards won by this person or for this creative work.
		/// </summary>
		private Awards_Core awards;
		public Awards_Core Awards
		{
			get
			{
				return awards;
			}
			set
			{
				awards = value;
				SetPropertyInstance(awards);
			}
		}

		/// <summary>
		/// Date of birth.
		/// </summary>
		private BirthDate_Core birthDate;
		public BirthDate_Core BirthDate
		{
			get
			{
				return birthDate;
			}
			set
			{
				birthDate = value;
				SetPropertyInstance(birthDate);
			}
		}

		/// <summary>
		/// A child of the person.
		/// </summary>
		private Children_Core children;
		public Children_Core Children
		{
			get
			{
				return children;
			}
			set
			{
				children = value;
				SetPropertyInstance(children);
			}
		}

		/// <summary>
		/// A colleague of the person.
		/// </summary>
		private Colleagues_Core colleagues;
		public Colleagues_Core Colleagues
		{
			get
			{
				return colleagues;
			}
			set
			{
				colleagues = value;
				SetPropertyInstance(colleagues);
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
		/// Date of death.
		/// </summary>
		private DeathDate_Core deathDate;
		public DeathDate_Core DeathDate
		{
			get
			{
				return deathDate;
			}
			set
			{
				deathDate = value;
				SetPropertyInstance(deathDate);
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
		/// Family name. In the U.S., the last name of an Person. This can be used along with givenName instead of the Name property.
		/// </summary>
		private FamilyName_Core familyName;
		public FamilyName_Core FamilyName
		{
			get
			{
				return familyName;
			}
			set
			{
				familyName = value;
				SetPropertyInstance(familyName);
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
		/// The most generic uni-directional social relation.
		/// </summary>
		private Follows_Core follows;
		public Follows_Core Follows
		{
			get
			{
				return follows;
			}
			set
			{
				follows = value;
				SetPropertyInstance(follows);
			}
		}

		/// <summary>
		/// Gender of the person.
		/// </summary>
		private Gender_Core gender;
		public Gender_Core Gender
		{
			get
			{
				return gender;
			}
			set
			{
				gender = value;
				SetPropertyInstance(gender);
			}
		}

		/// <summary>
		/// Given name. In the U.S., the first name of a Person. This can be used along with familyName instead of the Name property.
		/// </summary>
		private GivenName_Core givenName;
		public GivenName_Core GivenName
		{
			get
			{
				return givenName;
			}
			set
			{
				givenName = value;
				SetPropertyInstance(givenName);
			}
		}

		/// <summary>
		/// A contact location for a person's residence.
		/// </summary>
		private HomeLocation_Core homeLocation;
		public HomeLocation_Core HomeLocation
		{
			get
			{
				return homeLocation;
			}
			set
			{
				homeLocation = value;
				SetPropertyInstance(homeLocation);
			}
		}

		/// <summary>
		/// An honorific prefix preceding a Person's name such as Dr/Mrs/Mr.
		/// </summary>
		private HonorificPrefix_Core honorificPrefix;
		public HonorificPrefix_Core HonorificPrefix
		{
			get
			{
				return honorificPrefix;
			}
			set
			{
				honorificPrefix = value;
				SetPropertyInstance(honorificPrefix);
			}
		}

		/// <summary>
		/// An honorific suffix preceding a Person's name such as M.D. /PhD/MSCSW.
		/// </summary>
		private HonorificSuffix_Core honorificSuffix;
		public HonorificSuffix_Core HonorificSuffix
		{
			get
			{
				return honorificSuffix;
			}
			set
			{
				honorificSuffix = value;
				SetPropertyInstance(honorificSuffix);
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
		/// The job title of the person (for example, Financial Manager).
		/// </summary>
		private JobTitle_Core jobTitle;
		public JobTitle_Core JobTitle
		{
			get
			{
				return jobTitle;
			}
			set
			{
				jobTitle = value;
				SetPropertyInstance(jobTitle);
			}
		}

		/// <summary>
		/// The most generic bi-directional social/work relation.
		/// </summary>
		private Knows_Core knows;
		public Knows_Core Knows
		{
			get
			{
				return knows;
			}
			set
			{
				knows = value;
				SetPropertyInstance(knows);
			}
		}

		/// <summary>
		/// An organization to which the person belongs.
		/// </summary>
		private MemberOf_Core memberOf;
		public MemberOf_Core MemberOf
		{
			get
			{
				return memberOf;
			}
			set
			{
				memberOf = value;
				SetPropertyInstance(memberOf);
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
		/// Nationality of the person.
		/// </summary>
		private Nationality_Core nationality;
		public Nationality_Core Nationality
		{
			get
			{
				return nationality;
			}
			set
			{
				nationality = value;
				SetPropertyInstance(nationality);
			}
		}

		/// <summary>
		/// A parents of the person.
		/// </summary>
		private Parents_Core parents;
		public Parents_Core Parents
		{
			get
			{
				return parents;
			}
			set
			{
				parents = value;
				SetPropertyInstance(parents);
			}
		}

		/// <summary>
		/// Event that this person is a performer or participant in.
		/// </summary>
		private PerformerIn_Core performerIn;
		public PerformerIn_Core PerformerIn
		{
			get
			{
				return performerIn;
			}
			set
			{
				performerIn = value;
				SetPropertyInstance(performerIn);
			}
		}

		/// <summary>
		/// The most generic familial relation.
		/// </summary>
		private RelatedTo_Core relatedTo;
		public RelatedTo_Core RelatedTo
		{
			get
			{
				return relatedTo;
			}
			set
			{
				relatedTo = value;
				SetPropertyInstance(relatedTo);
			}
		}

		/// <summary>
		/// A sibling of the person.
		/// </summary>
		private Siblings_Core siblings;
		public Siblings_Core Siblings
		{
			get
			{
				return siblings;
			}
			set
			{
				siblings = value;
				SetPropertyInstance(siblings);
			}
		}

		/// <summary>
		/// The person's spouse.
		/// </summary>
		private Spouse_Core spouse;
		public Spouse_Core Spouse
		{
			get
			{
				return spouse;
			}
			set
			{
				spouse = value;
				SetPropertyInstance(spouse);
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

		/// <summary>
		/// A contact location for a person's place of work.
		/// </summary>
		private WorkLocation_Core workLocation;
		public WorkLocation_Core WorkLocation
		{
			get
			{
				return workLocation;
			}
			set
			{
				workLocation = value;
				SetPropertyInstance(workLocation);
			}
		}

		/// <summary>
		/// Organizations that the person works for.
		/// </summary>
		private WorksFor_Core worksFor;
		public WorksFor_Core WorksFor
		{
			get
			{
				return worksFor;
			}
			set
			{
				worksFor = value;
				SetPropertyInstance(worksFor);
			}
		}

	}
}