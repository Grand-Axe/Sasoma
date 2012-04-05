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
	/// When a single product that has different offers (for example, the same pair of shoes is offered by different merchants), then AggregateOffer can be used.
	/// </summary>
	public class AggregateOffer_Core : TypeCore, IOffer
	{
		public AggregateOffer_Core()
		{
			this._TypeId = 12;
			this._Id = "AggregateOffer";
			this._Schema_Org_Url = "http://schema.org/AggregateOffer";
			string label = "";
			GetLabel(out label, "AggregateOffer", typeof(AggregateOffer_Core));
			this._Label = label;
			this._Ancestors = new int[]{266,138,189};
			this._SubTypes = new int[0];
			this._SuperTypes = new int[]{189};
			this._Properties = new int[]{67,108,143,229,10,25,119,122,165,166,168,199,204,102,132,150};

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
		/// The availability of this item\u2014for example In stock, Out of stock, Pre-order, etc.
		/// </summary>
		private Availability_Core availability;
		public Availability_Core Availability
		{
			get
			{
				return availability;
			}
			set
			{
				availability = value;
				SetPropertyInstance(availability);
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
		/// The highest price of all offers available.
		/// </summary>
		private HighPrice_Core highPrice;
		public HighPrice_Core HighPrice
		{
			get
			{
				return highPrice;
			}
			set
			{
				highPrice = value;
				SetPropertyInstance(highPrice);
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
		/// The condition of the item for sale\u2014for example New, Refurbished, Used, etc.
		/// </summary>
		private ItemCondition_Core itemCondition;
		public ItemCondition_Core ItemCondition
		{
			get
			{
				return itemCondition;
			}
			set
			{
				itemCondition = value;
				SetPropertyInstance(itemCondition);
			}
		}

		/// <summary>
		/// The item being sold.
		/// </summary>
		private ItemOffered_Core itemOffered;
		public ItemOffered_Core ItemOffered
		{
			get
			{
				return itemOffered;
			}
			set
			{
				itemOffered = value;
				SetPropertyInstance(itemOffered);
			}
		}

		/// <summary>
		/// The lowest price of all offers available.
		/// </summary>
		private LowPrice_Core lowPrice;
		public LowPrice_Core LowPrice
		{
			get
			{
				return lowPrice;
			}
			set
			{
				lowPrice = value;
				SetPropertyInstance(lowPrice);
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
		/// The number of offers for the product.
		/// </summary>
		private OfferCount_Core offerCount;
		public OfferCount_Core OfferCount
		{
			get
			{
				return offerCount;
			}
			set
			{
				offerCount = value;
				SetPropertyInstance(offerCount);
			}
		}

		/// <summary>
		/// The offer price of the product.
		/// </summary>
		private Price_Core price;
		public Price_Core Price
		{
			get
			{
				return price;
			}
			set
			{
				price = value;
				SetPropertyInstance(price);
			}
		}

		/// <summary>
		/// The currency (in 3-letter <a href=\http://en.wikipedia.org/wiki/ISO_4217\>ISO 4217 format</a>) of the offer price.
		/// </summary>
		private PriceCurrency_Core priceCurrency;
		public PriceCurrency_Core PriceCurrency
		{
			get
			{
				return priceCurrency;
			}
			set
			{
				priceCurrency = value;
				SetPropertyInstance(priceCurrency);
			}
		}

		/// <summary>
		/// The date after which the price is no longer available.
		/// </summary>
		private PriceValidUntil_Core priceValidUntil;
		public PriceValidUntil_Core PriceValidUntil
		{
			get
			{
				return priceValidUntil;
			}
			set
			{
				priceValidUntil = value;
				SetPropertyInstance(priceValidUntil);
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
		/// The seller of the product.
		/// </summary>
		private Seller_Core seller;
		public Seller_Core Seller
		{
			get
			{
				return seller;
			}
			set
			{
				seller = value;
				SetPropertyInstance(seller);
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