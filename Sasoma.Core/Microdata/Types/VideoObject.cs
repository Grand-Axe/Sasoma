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
	/// A video file.
	/// </summary>
	public class VideoObject_Core : TypeCore, IMediaObject
	{
		public int TypeId
		{
			get
			{
				return 285;
			}
		}

		public string Id
		{
			get
			{
				return "VideoObject";
			}
		}

		public string Schema_Org_Url
		{
			get
			{
				return "http://schema.org/VideoObject";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "VideoObject", typeof(VideoObject_Core));
				return label;
			}
		}

		public int[] Ancestors
		{
			get
			{
				return new int[]{266,78,161};
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
				return new int[]{161};
			}
		}

		public int[] Properties
		{
			get
			{
				return new int[]{67,108,143,229,0,2,10,12,18,20,24,26,21,50,51,54,57,58,59,61,62,64,70,72,81,97,100,110,115,116,126,138,151,178,179,180,199,211,219,230,231,17,31,52,53,71,76,79,80,88,101,160,188,192,228,234,41,176,197,226,232,233};
			}
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
		/// A NewsArticle associated with the Media Object.
		/// </summary>
		public AssociatedArticle_Core AssociatedArticle { get; set; }

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
		/// The bitrate of the media object.
		/// </summary>
		public Bitrate_Core Bitrate { get; set; }

		/// <summary>
		/// The caption for this object.
		/// </summary>
		public Caption_Core Caption { get; set; }

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
		/// File size in (mega/kilo) bytes.
		/// </summary>
		public ContentSize_Core ContentSize { get; set; }

		/// <summary>
		/// Actual bytes of the media object, for example the image file or video file.
		/// </summary>
		public ContentURL_Core ContentURL { get; set; }

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
		/// The duration of the item (movie, audio recording, event, etc.) in <a href=\http://en.wikipedia.org/wiki/ISO_8601\ target=\new\>ISO 8601 date format</a>.
		/// </summary>
		public Properties.Duration_Core Duration { get; set; }

		/// <summary>
		/// Specifies the Person who edited the CreativeWork.
		/// </summary>
		public Editor_Core Editor { get; set; }

		/// <summary>
		/// A URL pointing to a player for a specific video. In general, this is the information in the <code>src</code> element of an <code>embed</code> tag and should not be the same as the content of the <code>loc</code> tag.
		/// </summary>
		public EmbedURL_Core EmbedURL { get; set; }

		/// <summary>
		/// The creative work encoded by this media object
		/// </summary>
		public EncodesCreativeWork_Core EncodesCreativeWork { get; set; }

		/// <summary>
		/// mp3, mpeg4, etc.
		/// </summary>
		public EncodingFormat_Core EncodingFormat { get; set; }

		/// <summary>
		/// The media objects that encode this creative work
		/// </summary>
		public Encodings_Core Encodings { get; set; }

		/// <summary>
		/// Date the content expires and is no longer useful or available. Useful for videos.
		/// </summary>
		public Expires_Core Expires { get; set; }

		/// <summary>
		/// Genre of the creative work
		/// </summary>
		public Genre_Core Genre { get; set; }

		/// <summary>
		/// Headline of the article
		/// </summary>
		public Headline_Core Headline { get; set; }

		/// <summary>
		/// The height of the media object.
		/// </summary>
		public Height_Core Height { get; set; }

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
		/// Player type required\u2014for example, Flash or Silverlight.
		/// </summary>
		public PlayerType_Core PlayerType { get; set; }

		/// <summary>
		/// The production company or studio that made the movie, TV series, season, or episode, or video.
		/// </summary>
		public ProductionCompany_Core ProductionCompany { get; set; }

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
		/// The regions where the media is allowed. If not specified, then it's assumed to be allowed everywhere. Specify the countries in <a href=\http://en.wikipedia.org/wiki/ISO_3166\ target=\new\>ISO 3166 format</a>.
		/// </summary>
		public RegionsAllowed_Core RegionsAllowed { get; set; }

		/// <summary>
		/// Indicates if use of the media require a subscription  (either paid or free). Allowed values are <code>yes</code> or <code>no</code>.
		/// </summary>
		public RequiresSubscription_Core RequiresSubscription { get; set; }

		/// <summary>
		/// Review of the item.
		/// </summary>
		public Reviews_Core Reviews { get; set; }

		/// <summary>
		/// The Organization on whose behalf the creator was working.
		/// </summary>
		public SourceOrganization_Core SourceOrganization { get; set; }

		/// <summary>
		/// Thumbnail image for an image or video.
		/// </summary>
		public Thumbnail_Core Thumbnail { get; set; }

		/// <summary>
		/// A thumbnail image relevant to the Thing.
		/// </summary>
		public ThumbnailURL_Core ThumbnailURL { get; set; }

		/// <summary>
		/// If this MediaObject is an AudioObject or VideoObject, the transcript of that object.
		/// </summary>
		public Transcript_Core Transcript { get; set; }

		/// <summary>
		/// Date when this media object was uploaded to this site.
		/// </summary>
		public UploadDate_Core UploadDate { get; set; }

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

		/// <summary>
		/// The frame size of the video.
		/// </summary>
		public VideoFrameSize_Core VideoFrameSize { get; set; }

		/// <summary>
		/// The quality of the video.
		/// </summary>
		public VideoQuality_Core VideoQuality { get; set; }

		/// <summary>
		/// The width of the media object.
		/// </summary>
		public Width_Core Width { get; set; }

	}
}