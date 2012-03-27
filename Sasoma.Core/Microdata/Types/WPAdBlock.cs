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
	/// An advertising section of the page.
	/// </summary>
	public class WPAdBlock_Core : TypeCore, IWebPageElement
	{
		public WPAdBlock_Core()
		{
			this._TypeId = 288;
			this._Id = "WPAdBlock";
			this._Schema_Org_Url = "http://schema.org/WPAdBlock";
			string label = "";
			GetLabel(out label, "WPAdBlock", typeof(WPAdBlock_Core));
			this._Label = label;
			this._Ancestors = new int[]{266,78,294};
			this._SubTypes = new int[0];
			this._SuperTypes = new int[]{294};
			this._Properties = new int[]{67,108,143,229,0,2,10,12,18,20,24,26,21,50,51,54,57,58,59,61,62,64,70,72,81,97,100,110,115,116,126,138,151,178,179,180,199,211,219,230,231};

		}

		/// <summary>
		/// The subject matter of the content.
		/// </summary>
		public About_Core About { get; set; }

		/// <summary>
		/// Specifies the Person that is legally accountable for the CreativeWork.
		/// </summary>
		public AccountablePerson_Core AccountablePerson { get; set; }

		/// <summary>
		/// The overall rating, based on a collection of reviews or ratings, of the item.
		/// </summary>
		public Properties.AggregateRating_Core AggregateRating { get; set; }

		/// <summary>
		/// A secondary title of the CreativeWork.
		/// </summary>
		public AlternativeHeadline_Core AlternativeHeadline { get; set; }

		/// <summary>
		/// The media objects that encode this creative work. This property is a synonym for encodings.
		/// </summary>
		public AssociatedMedia_Core AssociatedMedia { get; set; }

		/// <summary>
		/// An embedded audio object.
		/// </summary>
		public Audio_Core Audio { get; set; }

		/// <summary>
		/// The author of this content. Please note that author is special in that HTML 5 provides a special mechanism for indicating authorship via the rel tag. That is equivalent to this and may be used interchangabely.
		/// </summary>
		public Author_Core Author { get; set; }

		/// <summary>
		/// Awards won by this person or for this creative work.
		/// </summary>
		public Awards_Core Awards { get; set; }

		/// <summary>
		/// Comments, typically from users, on this CreativeWork.
		/// </summary>
		public Comment_Core Comment { get; set; }

		/// <summary>
		/// The location of the content.
		/// </summary>
		public ContentLocation_Core ContentLocation { get; set; }

		/// <summary>
		/// Official rating of a piece of content\u2014for example,'MPAA PG-13'.
		/// </summary>
		public ContentRating_Core ContentRating { get; set; }

		/// <summary>
		/// A secondary contributor to the CreativeWork.
		/// </summary>
		public Contributor_Core Contributor { get; set; }

		/// <summary>
		/// The party holding the legal copyright to the CreativeWork.
		/// </summary>
		public CopyrightHolder_Core CopyrightHolder { get; set; }

		/// <summary>
		/// The year during which the claimed copyright for the CreativeWork was first asserted.
		/// </summary>
		public CopyrightYear_Core CopyrightYear { get; set; }

		/// <summary>
		/// The creator/author of this CreativeWork or UserComments. This is the same as the Author property for CreativeWork.
		/// </summary>
		public Creator_Core Creator { get; set; }

		/// <summary>
		/// The date on which the CreativeWork was created.
		/// </summary>
		public DateCreated_Core DateCreated { get; set; }

		/// <summary>
		/// The date on which the CreativeWork was most recently modified.
		/// </summary>
		public DateModified_Core DateModified { get; set; }

		/// <summary>
		/// Date of first broadcast/publication.
		/// </summary>
		public DatePublished_Core DatePublished { get; set; }

		/// <summary>
		/// A short description of the item.
		/// </summary>
		public Description_Core Description { get; set; }

		/// <summary>
		/// A link to the page containing the comments of the CreativeWork.
		/// </summary>
		public DiscussionURL_Core DiscussionURL { get; set; }

		/// <summary>
		/// Specifies the Person who edited the CreativeWork.
		/// </summary>
		public Editor_Core Editor { get; set; }

		/// <summary>
		/// The media objects that encode this creative work
		/// </summary>
		public Encodings_Core Encodings { get; set; }

		/// <summary>
		/// Genre of the creative work
		/// </summary>
		public Genre_Core Genre { get; set; }

		/// <summary>
		/// Headline of the article
		/// </summary>
		public Headline_Core Headline { get; set; }

		/// <summary>
		/// URL of an image of the item.
		/// </summary>
		public Image_Core Image { get; set; }

		/// <summary>
		/// The language of the content. please use one of the language codes from the <a href=\http://tools.ietf.org/html/bcp47\>IETF BCP 47 standard.</a>
		/// </summary>
		public InLanguage_Core InLanguage { get; set; }

		/// <summary>
		/// A count of a specific user interactions with this item\u2014for example, <code>20 UserLikes</code>, <code>5 UserComments</code>, or <code>300 UserDownloads</code>. The user interaction type should be one of the sub types of <a href=\http://schema.org/UserInteraction\>UserInteraction</a>.
		/// </summary>
		public InteractionCount_Core InteractionCount { get; set; }

		/// <summary>
		/// Indicates whether this content is family friendly.
		/// </summary>
		public IsFamilyFriendly_Core IsFamilyFriendly { get; set; }

		/// <summary>
		/// The keywords/tags used to describe this content.
		/// </summary>
		public Keywords_Core Keywords { get; set; }

		/// <summary>
		/// Indicates that the CreativeWork contains a reference to, but is not necessarily about a concept.
		/// </summary>
		public Mentions_Core Mentions { get; set; }

		/// <summary>
		/// The name of the item.
		/// </summary>
		public Name_Core Name { get; set; }

		/// <summary>
		/// An offer to sell this item\u2014for example, an offer to sell a product, the DVD of a movie, or tickets to an event.
		/// </summary>
		public Offers_Core Offers { get; set; }

		/// <summary>
		/// Specifies the Person or Organization that distributed the CreativeWork.
		/// </summary>
		public Provider_Core Provider { get; set; }

		/// <summary>
		/// The publisher of the creative work.
		/// </summary>
		public Publisher_Core Publisher { get; set; }

		/// <summary>
		/// Link to page describing the editorial principles of the organization primarily responsible for the creation of the CreativeWork.
		/// </summary>
		public PublishingPrinciples_Core PublishingPrinciples { get; set; }

		/// <summary>
		/// Review of the item.
		/// </summary>
		public Reviews_Core Reviews { get; set; }

		/// <summary>
		/// The Organization on whose behalf the creator was working.
		/// </summary>
		public SourceOrganization_Core SourceOrganization { get; set; }

		/// <summary>
		/// A thumbnail image relevant to the Thing.
		/// </summary>
		public ThumbnailURL_Core ThumbnailURL { get; set; }

		/// <summary>
		/// URL of the item.
		/// </summary>
		public Properties.URL_Core URL { get; set; }

		/// <summary>
		/// The version of the CreativeWork embodied by a specified resource.
		/// </summary>
		public Version_Core Version { get; set; }

		/// <summary>
		/// An embedded video object.
		/// </summary>
		public Video_Core Video { get; set; }

	}
}