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