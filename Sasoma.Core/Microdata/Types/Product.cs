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
	/// A product is anything that is made available for sale\u2014for example, a pair of shoes, a concert ticket, or a car.
	/// </summary>
	public class Product_Core : TypeCore, IThing
	{
		public int TypeId
		{
			get
			{
				return 215;
			}
		}

		public string Id
		{
			get
			{
				return "Product";
			}
		}

		public string Schema_Org_Url
		{
			get
			{
				return "http://schema.org/Product";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "Product", typeof(Product_Core));
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
				return new int[]{67,108,143,229,10,37,134,140,151,175,199};
			}
		}


		/// <summary>
		/// The overall rating, based on a collection of reviews or ratings, of the item.
		/// </summary>
		public Properties.AggregateRating_Core AggregateRating { get; set; }

		/// <summary>
		/// The brand of the product.
		/// </summary>
		public Brand_Core Brand { get; set; }

		/// <summary>
		/// A short description of the item.
		/// </summary>
		public Description_Core Description { get; set; }

		/// <summary>
		/// URL of an image of the item.
		/// </summary>
		public Image_Core Image { get; set; }

		/// <summary>
		/// The manufacturer of the product.
		/// </summary>
		public Manufacturer_Core Manufacturer { get; set; }

		/// <summary>
		/// The model of the product.
		/// </summary>
		public Model_Core Model { get; set; }

		/// <summary>
		/// The name of the item.
		/// </summary>
		public Name_Core Name { get; set; }

		/// <summary>
		/// An offer to sell this item\u2014for example, an offer to sell a product, the DVD of a movie, or tickets to an event.
		/// </summary>
		public Offers_Core Offers { get; set; }

		/// <summary>
		/// The product identifier, such as ISBN. For example: <code>&lt;meta itemprop='productID' content='isbn:123-456-789'/&gt;</code>.
		/// </summary>
		public ProductID_Core ProductID { get; set; }

		/// <summary>
		/// Review of the item.
		/// </summary>
		public Reviews_Core Reviews { get; set; }

		/// <summary>
		/// URL of the item.
		/// </summary>
		public Properties.URL_Core URL { get; set; }

	}
}