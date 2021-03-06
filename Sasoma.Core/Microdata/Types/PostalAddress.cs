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
	/// The mailing address.
	/// </summary>
	public class PostalAddress_Core : TypeCore, IContactPoint
	{
		public PostalAddress_Core()
		{
			this._TypeId = 213;
			this._Id = "PostalAddress";
			this._Schema_Org_Url = "http://schema.org/PostalAddress";
			string label = "";
			GetLabel(out label, "PostalAddress", typeof(PostalAddress_Core));
			this._Label = label;
			this._Ancestors = new int[]{266,138,253,70};
			this._SubTypes = new int[0];
			this._SuperTypes = new int[]{70};
			this._Properties = new int[]{67,108,143,229,48,75,91,196,6,7,8,162,163,215};

		}

		/// <summary>
		/// The country. For example, USA. You can also provide the two-letter <a href=\http://en.wikipedia.org/wiki/ISO_3166-1\ target=\new\>ISO 3166-1 alpha-2 country code</a>.
		/// </summary>
		private AddressCountry_Core addressCountry;
		public AddressCountry_Core AddressCountry
		{
			get
			{
				return addressCountry;
			}
			set
			{
				addressCountry = value;
				SetPropertyInstance(addressCountry);
			}
		}

		/// <summary>
		/// The locality. For example, Mountain View.
		/// </summary>
		private AddressLocality_Core addressLocality;
		public AddressLocality_Core AddressLocality
		{
			get
			{
				return addressLocality;
			}
			set
			{
				addressLocality = value;
				SetPropertyInstance(addressLocality);
			}
		}

		/// <summary>
		/// The region. For example, CA.
		/// </summary>
		private AddressRegion_Core addressRegion;
		public AddressRegion_Core AddressRegion
		{
			get
			{
				return addressRegion;
			}
			set
			{
				addressRegion = value;
				SetPropertyInstance(addressRegion);
			}
		}

		/// <summary>
		/// A person or organization can have different contact points, for different purposes. For example, a sales contact point, a PR contact point and so on. This property is used to specify the kind of contact point.
		/// </summary>
		private ContactType_Core contactType;
		public ContactType_Core ContactType
		{
			get
			{
				return contactType;
			}
			set
			{
				contactType = value;
				SetPropertyInstance(contactType);
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
		/// The postal code. For example, 94043.
		/// </summary>
		private PostalCode_Core postalCode;
		public PostalCode_Core PostalCode
		{
			get
			{
				return postalCode;
			}
			set
			{
				postalCode = value;
				SetPropertyInstance(postalCode);
			}
		}

		/// <summary>
		/// The post offce box number for PO box addresses.
		/// </summary>
		private PostOfficeBoxNumber_Core postOfficeBoxNumber;
		public PostOfficeBoxNumber_Core PostOfficeBoxNumber
		{
			get
			{
				return postOfficeBoxNumber;
			}
			set
			{
				postOfficeBoxNumber = value;
				SetPropertyInstance(postOfficeBoxNumber);
			}
		}

		/// <summary>
		/// The street address. For example, 1600 Amphitheatre Pkwy.
		/// </summary>
		private StreetAddress_Core streetAddress;
		public StreetAddress_Core StreetAddress
		{
			get
			{
				return streetAddress;
			}
			set
			{
				streetAddress = value;
				SetPropertyInstance(streetAddress);
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