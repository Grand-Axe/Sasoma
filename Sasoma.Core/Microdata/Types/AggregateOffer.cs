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
	/// When a single product that has different offers (for example, the same pair of shoes is offered by different merchants), then AggregateOffer can be used.
	/// </summary>
	public class AggregateOffer_Core : TypeCore, IOffer
	{
		public int TypeId
		{
			get
			{
				return 12;
			}
		}

		public string Id
		{
			get
			{
				return "AggregateOffer";
			}
		}

		public string Schema_Org_Url
		{
			get
			{
				return "http://schema.org/AggregateOffer";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "AggregateOffer", typeof(AggregateOffer_Core));
				return label;
			}
		}

		public int[] Ancestors
		{
			get
			{
				return new int[]{266,138,189};
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
				return new int[]{189};
			}
		}

		public int[] Properties
		{
			get
			{
				return new int[]{67,108,143,229,10,25,119,122,165,166,168,199,204,102,132,150};
			}
		}


		/// <summary>
		/// The overall rating, based on a collection of reviews or ratings, of the item.
		/// </summary>
		public Properties.AggregateRating_Core AggregateRating { get; set; }

		/// <summary>
		/// The availability of this item\u2014for example In stock, Out of stock, Pre-order, etc.
		/// </summary>
		public Availability_Core Availability { get; set; }

		/// <summary>
		/// A short description of the item.
		/// </summary>
		public Description_Core Description { get; set; }

		/// <summary>
		/// The highest price of all offers available.
		/// </summary>
		public HighPrice_Core HighPrice { get; set; }

		/// <summary>
		/// URL of an image of the item.
		/// </summary>
		public Image_Core Image { get; set; }

		/// <summary>
		/// The condition of the item for sale\u2014for example New, Refurbished, Used, etc.
		/// </summary>
		public ItemCondition_Core ItemCondition { get; set; }

		/// <summary>
		/// The item being sold.
		/// </summary>
		public ItemOffered_Core ItemOffered { get; set; }

		/// <summary>
		/// The lowest price of all offers available.
		/// </summary>
		public LowPrice_Core LowPrice { get; set; }

		/// <summary>
		/// The name of the item.
		/// </summary>
		public Name_Core Name { get; set; }

		/// <summary>
		/// The number of offers for the product.
		/// </summary>
		public OfferCount_Core OfferCount { get; set; }

		/// <summary>
		/// The offer price of the product.
		/// </summary>
		public Price_Core Price { get; set; }

		/// <summary>
		/// The currency (in 3-letter <a href=\http://en.wikipedia.org/wiki/ISO_4217\>ISO 4217 format</a>) of the offer price.
		/// </summary>
		public PriceCurrency_Core PriceCurrency { get; set; }

		/// <summary>
		/// The date after which the price is no longer available.
		/// </summary>
		public PriceValidUntil_Core PriceValidUntil { get; set; }

		/// <summary>
		/// Review of the item.
		/// </summary>
		public Reviews_Core Reviews { get; set; }

		/// <summary>
		/// The seller of the product.
		/// </summary>
		public Seller_Core Seller { get; set; }

		/// <summary>
		/// URL of the item.
		/// </summary>
		public Properties.URL_Core URL { get; set; }

	}
}