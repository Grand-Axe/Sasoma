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
	/// A contact point\u2014for example, a Customer Complaints department.
	/// </summary>
	public class ContactPoint_Core : TypeCore, IStructuredValue
	{
		public ContactPoint_Core()
		{
			this._TypeId = 70;
			this._Id = "ContactPoint";
			this._Schema_Org_Url = "http://schema.org/ContactPoint";
			string label = "";
			GetLabel(out label, "ContactPoint", typeof(ContactPoint_Core));
			this._Label = label;
			this._Ancestors = new int[]{266,138,253};
			this._SubTypes = new int[]{213};
			this._SuperTypes = new int[]{253};
			this._Properties = new int[]{67,108,143,229,48,75,91,196};

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