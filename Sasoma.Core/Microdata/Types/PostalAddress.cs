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
	/// The mailing address.
	/// </summary>
	public class PostalAddress_Core : TypeCore, IContactPoint
	{
		public int TypeId
		{
			get
			{
				return 213;
			}
		}

		public string Id
		{
			get
			{
				return "PostalAddress";
			}
		}

		public string Schema_Org_Url
		{
			get
			{
				return "http://schema.org/PostalAddress";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "PostalAddress", typeof(PostalAddress_Core));
				return label;
			}
		}

		public int[] Ancestors
		{
			get
			{
				return new int[]{266,138,253,70};
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
				return new int[]{70};
			}
		}

		public int[] Properties
		{
			get
			{
				return new int[]{67,108,143,229,48,75,91,196,6,7,8,162,163,215};
			}
		}


		/// <summary>
		/// The country. For example, USA. You can also provide the two-letter <a href=\http://en.wikipedia.org/wiki/ISO_3166-1\ target=\new\>ISO 3166-1 alpha-2 country code</a>.
		/// </summary>
		public AddressCountry_Core AddressCountry { get; set; }

		/// <summary>
		/// The locality. For example, Mountain View.
		/// </summary>
		public AddressLocality_Core AddressLocality { get; set; }

		/// <summary>
		/// The region. For example, CA.
		/// </summary>
		public AddressRegion_Core AddressRegion { get; set; }

		/// <summary>
		/// A person or organization can have different contact points, for different purposes. For example, a sales contact point, a PR contact point and so on. This property is used to specify the kind of contact point.
		/// </summary>
		public ContactType_Core ContactType { get; set; }

		/// <summary>
		/// A short description of the item.
		/// </summary>
		public Description_Core Description { get; set; }

		/// <summary>
		/// Email address.
		/// </summary>
		public Email_Core Email { get; set; }

		/// <summary>
		/// The fax number.
		/// </summary>
		public FaxNumber_Core FaxNumber { get; set; }

		/// <summary>
		/// URL of an image of the item.
		/// </summary>
		public Image_Core Image { get; set; }

		/// <summary>
		/// The name of the item.
		/// </summary>
		public Name_Core Name { get; set; }

		/// <summary>
		/// The postal code. For example, 94043.
		/// </summary>
		public PostalCode_Core PostalCode { get; set; }

		/// <summary>
		/// The post offce box number for PO box addresses.
		/// </summary>
		public PostOfficeBoxNumber_Core PostOfficeBoxNumber { get; set; }

		/// <summary>
		/// The street address. For example, 1600 Amphitheatre Pkwy.
		/// </summary>
		public StreetAddress_Core StreetAddress { get; set; }

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