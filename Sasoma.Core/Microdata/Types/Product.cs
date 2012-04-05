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
	/// A product is anything that is made available for sale\u2014for example, a pair of shoes, a concert ticket, or a car.
	/// </summary>
	public class Product_Core : TypeCore, IThing
	{
		public Product_Core()
		{
			this._TypeId = 215;
			this._Id = "Product";
			this._Schema_Org_Url = "http://schema.org/Product";
			string label = "";
			GetLabel(out label, "Product", typeof(Product_Core));
			this._Label = label;
			this._Ancestors = new int[]{266};
			this._SubTypes = new int[0];
			this._SuperTypes = new int[]{266};
			this._Properties = new int[]{67,108,143,229,10,37,134,140,151,175,199};

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
		/// The brand of the product.
		/// </summary>
		private Brand_Core brand;
		public Brand_Core Brand
		{
			get
			{
				return brand;
			}
			set
			{
				brand = value;
				SetPropertyInstance(brand);
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
		/// The manufacturer of the product.
		/// </summary>
		private Manufacturer_Core manufacturer;
		public Manufacturer_Core Manufacturer
		{
			get
			{
				return manufacturer;
			}
			set
			{
				manufacturer = value;
				SetPropertyInstance(manufacturer);
			}
		}

		/// <summary>
		/// The model of the product.
		/// </summary>
		private Model_Core model;
		public Model_Core Model
		{
			get
			{
				return model;
			}
			set
			{
				model = value;
				SetPropertyInstance(model);
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
		/// An offer to sell this item\u2014for example, an offer to sell a product, the DVD of a movie, or tickets to an event.
		/// </summary>
		private Offers_Core offers;
		public Offers_Core Offers
		{
			get
			{
				return offers;
			}
			set
			{
				offers = value;
				SetPropertyInstance(offers);
			}
		}

		/// <summary>
		/// The product identifier, such as ISBN. For example: <code>&lt;meta itemprop='productID' content='isbn:123-456-789'/&gt;</code>.
		/// </summary>
		private ProductID_Core productID;
		public ProductID_Core ProductID
		{
			get
			{
				return productID;
			}
			set
			{
				productID = value;
				SetPropertyInstance(productID);
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