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
	/// A contact point\u2014for example, a Customer Complaints department.
	/// </summary>
	public class ContactPoint_Core : TypeCore, IStructuredValue
	{
		public int TypeId
		{
			get
			{
				return 70;
			}
		}

		public string Id
		{
			get
			{
				return "ContactPoint";
			}
		}

		public string Schema_Org_Url
		{
			get
			{
				return "http://schema.org/ContactPoint";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "ContactPoint", typeof(ContactPoint_Core));
				return label;
			}
		}

		public int[] Ancestors
		{
			get
			{
				return new int[]{266,138,253};
			}
		}

		public int[] SubTypes
		{
			get
			{
				return new int[]{213};
			}
		}

		public int[] SuperTypes
		{
			get
			{
				return new int[]{253};
			}
		}

		public int[] Properties
		{
			get
			{
				return new int[]{67,108,143,229,48,75,91,196};
			}
		}


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
		/// The telephone number.
		/// </summary>
		public Telephone_Core Telephone { get; set; }

		/// <summary>
		/// URL of the item.
		/// </summary>
		public Properties.URL_Core URL { get; set; }

	}
}