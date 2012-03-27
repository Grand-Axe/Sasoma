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
	/// An offer to sell an item\u2014for example, an offer to sell a product, the DVD of a movie, or tickets to an event.
	/// </summary>
	public class Offer_Core : TypeCore, IIntangible
	{
		public Offer_Core()
		{
			this._TypeId = 189;
			this._Id = "Offer";
			this._Schema_Org_Url = "http://schema.org/Offer";
			string label = "";
			GetLabel(out label, "Offer", typeof(Offer_Core));
			this._Label = label;
			this._Ancestors = new int[]{266,138};
			this._SubTypes = new int[]{12};
			this._SuperTypes = new int[]{138};
			this._Properties = new int[]{67,108,143,229,10,25,119,122,165,166,168,199,204};

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
		/// The name of the item.
		/// </summary>
		public Name_Core Name { get; set; }

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