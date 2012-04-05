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
	/// An audio file.
	/// </summary>
	public class AudioObject_Core : TypeCore, IMediaObject
	{
		public AudioObject_Core()
		{
			this._TypeId = 22;
			this._Id = "AudioObject";
			this._Schema_Org_Url = "http://schema.org/AudioObject";
			string label = "";
			GetLabel(out label, "AudioObject", typeof(AudioObject_Core));
			this._Label = label;
			this._Ancestors = new int[]{266,78,161};
			this._SubTypes = new int[0];
			this._SuperTypes = new int[]{161};
			this._Properties = new int[]{67,108,143,229,0,2,10,12,18,20,24,26,21,50,51,54,57,58,59,61,62,64,70,72,81,97,100,110,115,116,126,138,151,178,179,180,199,211,219,230,231,17,31,52,53,71,76,79,80,88,101,160,188,192,228,234,226};

		}

		/// <summary>
		/// The subject matter of the content.
		/// </summary>
		private About_Core about;
		public About_Core About
		{
			get
			{
				return about;
			}
			set
			{
				about = value;
				SetPropertyInstance(about);
			}
		}

		/// <summary>
		/// Specifies the Person that is legally accountable for the CreativeWork.
		/// </summary>
		private AccountablePerson_Core accountablePerson;
		public AccountablePerson_Core AccountablePerson
		{
			get
			{
				return accountablePerson;
			}
			set
			{
				accountablePerson = value;
				SetPropertyInstance(accountablePerson);
			}
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
		/// A secondary title of the CreativeWork.
		/// </summary>
		private AlternativeHeadline_Core alternativeHeadline;
		public AlternativeHeadline_Core AlternativeHeadline
		{
			get
			{
				return alternativeHeadline;
			}
			set
			{
				alternativeHeadline = value;
				SetPropertyInstance(alternativeHeadline);
			}
		}

		/// <summary>
		/// A NewsArticle associated with the Media Object.
		/// </summary>
		private AssociatedArticle_Core associatedArticle;
		public AssociatedArticle_Core AssociatedArticle
		{
			get
			{
				return associatedArticle;
			}
			set
			{
				associatedArticle = value;
				SetPropertyInstance(associatedArticle);
			}
		}

		/// <summary>
		/// The media objects that encode this creative work. This property is a synonym for encodings.
		/// </summary>
		private AssociatedMedia_Core associatedMedia;
		public AssociatedMedia_Core AssociatedMedia
		{
			get
			{
				return associatedMedia;
			}
			set
			{
				associatedMedia = value;
				SetPropertyInstance(associatedMedia);
			}
		}

		/// <summary>
		/// An embedded audio object.
		/// </summary>
		private Audio_Core audio;
		public Audio_Core Audio
		{
			get
			{
				return audio;
			}
			set
			{
				audio = value;
				SetPropertyInstance(audio);
			}
		}

		/// <summary>
		/// The author of this content. Please note that author is special in that HTML 5 provides a special mechanism for indicating authorship via the rel tag. That is equivalent to this and may be used interchangabely.
		/// </summary>
		private Author_Core author;
		public Author_Core Author
		{
			get
			{
				return author;
			}
			set
			{
				author = value;
				SetPropertyInstance(author);
			}
		}

		/// <summary>
		/// Awards won by this person or for this creative work.
		/// </summary>
		private Awards_Core awards;
		public Awards_Core Awards
		{
			get
			{
				return awards;
			}
			set
			{
				awards = value;
				SetPropertyInstance(awards);
			}
		}

		/// <summary>
		/// The bitrate of the media object.
		/// </summary>
		private Bitrate_Core bitrate;
		public Bitrate_Core Bitrate
		{
			get
			{
				return bitrate;
			}
			set
			{
				bitrate = value;
				SetPropertyInstance(bitrate);
			}
		}

		/// <summary>
		/// Comments, typically from users, on this CreativeWork.
		/// </summary>
		private Comment_Core comment;
		public Comment_Core Comment
		{
			get
			{
				return comment;
			}
			set
			{
				comment = value;
				SetPropertyInstance(comment);
			}
		}

		/// <summary>
		/// The location of the content.
		/// </summary>
		private ContentLocation_Core contentLocation;
		public ContentLocation_Core ContentLocation
		{
			get
			{
				return contentLocation;
			}
			set
			{
				contentLocation = value;
				SetPropertyInstance(contentLocation);
			}
		}

		/// <summary>
		/// Official rating of a piece of content\u2014for example,'MPAA PG-13'.
		/// </summary>
		private ContentRating_Core contentRating;
		public ContentRating_Core ContentRating
		{
			get
			{
				return contentRating;
			}
			set
			{
				contentRating = value;
				SetPropertyInstance(contentRating);
			}
		}

		/// <summary>
		/// File size in (mega/kilo) bytes.
		/// </summary>
		private ContentSize_Core contentSize;
		public ContentSize_Core ContentSize
		{
			get
			{
				return contentSize;
			}
			set
			{
				contentSize = value;
				SetPropertyInstance(contentSize);
			}
		}

		/// <summary>
		/// Actual bytes of the media object, for example the image file or video file.
		/// </summary>
		private ContentURL_Core contentURL;
		public ContentURL_Core ContentURL
		{
			get
			{
				return contentURL;
			}
			set
			{
				contentURL = value;
				SetPropertyInstance(contentURL);
			}
		}

		/// <summary>
		/// A secondary contributor to the CreativeWork.
		/// </summary>
		private Contributor_Core contributor;
		public Contributor_Core Contributor
		{
			get
			{
				return contributor;
			}
			set
			{
				contributor = value;
				SetPropertyInstance(contributor);
			}
		}

		/// <summary>
		/// The party holding the legal copyright to the CreativeWork.
		/// </summary>
		private CopyrightHolder_Core copyrightHolder;
		public CopyrightHolder_Core CopyrightHolder
		{
			get
			{
				return copyrightHolder;
			}
			set
			{
				copyrightHolder = value;
				SetPropertyInstance(copyrightHolder);
			}
		}

		/// <summary>
		/// The year during which the claimed copyright for the CreativeWork was first asserted.
		/// </summary>
		private CopyrightYear_Core copyrightYear;
		public CopyrightYear_Core CopyrightYear
		{
			get
			{
				return copyrightYear;
			}
			set
			{
				copyrightYear = value;
				SetPropertyInstance(copyrightYear);
			}
		}

		/// <summary>
		/// The creator/author of this CreativeWork or UserComments. This is the same as the Author property for CreativeWork.
		/// </summary>
		private Creator_Core creator;
		public Creator_Core Creator
		{
			get
			{
				return creator;
			}
			set
			{
				creator = value;
				SetPropertyInstance(creator);
			}
		}

		/// <summary>
		/// The date on which the CreativeWork was created.
		/// </summary>
		private DateCreated_Core dateCreated;
		public DateCreated_Core DateCreated
		{
			get
			{
				return dateCreated;
			}
			set
			{
				dateCreated = value;
				SetPropertyInstance(dateCreated);
			}
		}

		/// <summary>
		/// The date on which the CreativeWork was most recently modified.
		/// </summary>
		private DateModified_Core dateModified;
		public DateModified_Core DateModified
		{
			get
			{
				return dateModified;
			}
			set
			{
				dateModified = value;
				SetPropertyInstance(dateModified);
			}
		}

		/// <summary>
		/// Date of first broadcast/publication.
		/// </summary>
		private DatePublished_Core datePublished;
		public DatePublished_Core DatePublished
		{
			get
			{
				return datePublished;
			}
			set
			{
				datePublished = value;
				SetPropertyInstance(datePublished);
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
		/// A link to the page containing the comments of the CreativeWork.
		/// </summary>
		private DiscussionURL_Core discussionURL;
		public DiscussionURL_Core DiscussionURL
		{
			get
			{
				return discussionURL;
			}
			set
			{
				discussionURL = value;
				SetPropertyInstance(discussionURL);
			}
		}

		/// <summary>
		/// The duration of the item (movie, audio recording, event, etc.) in <a href=\http://en.wikipedia.org/wiki/ISO_8601\ target=\new\>ISO 8601 date format</a>.
		/// </summary>
		private Properties.Duration_Core duration;
		public Properties.Duration_Core Duration
		{
			get
			{
				return duration;
			}
			set
			{
				duration = value;
				SetPropertyInstance(duration);
			}
		}

		/// <summary>
		/// Specifies the Person who edited the CreativeWork.
		/// </summary>
		private Editor_Core editor;
		public Editor_Core Editor
		{
			get
			{
				return editor;
			}
			set
			{
				editor = value;
				SetPropertyInstance(editor);
			}
		}

		/// <summary>
		/// A URL pointing to a player for a specific video. In general, this is the information in the <code>src</code> element of an <code>embed</code> tag and should not be the same as the content of the <code>loc</code> tag.
		/// </summary>
		private EmbedURL_Core embedURL;
		public EmbedURL_Core EmbedURL
		{
			get
			{
				return embedURL;
			}
			set
			{
				embedURL = value;
				SetPropertyInstance(embedURL);
			}
		}

		/// <summary>
		/// The creative work encoded by this media object
		/// </summary>
		private EncodesCreativeWork_Core encodesCreativeWork;
		public EncodesCreativeWork_Core EncodesCreativeWork
		{
			get
			{
				return encodesCreativeWork;
			}
			set
			{
				encodesCreativeWork = value;
				SetPropertyInstance(encodesCreativeWork);
			}
		}

		/// <summary>
		/// mp3, mpeg4, etc.
		/// </summary>
		private EncodingFormat_Core encodingFormat;
		public EncodingFormat_Core EncodingFormat
		{
			get
			{
				return encodingFormat;
			}
			set
			{
				encodingFormat = value;
				SetPropertyInstance(encodingFormat);
			}
		}

		/// <summary>
		/// The media objects that encode this creative work
		/// </summary>
		private Encodings_Core encodings;
		public Encodings_Core Encodings
		{
			get
			{
				return encodings;
			}
			set
			{
				encodings = value;
				SetPropertyInstance(encodings);
			}
		}

		/// <summary>
		/// Date the content expires and is no longer useful or available. Useful for videos.
		/// </summary>
		private Expires_Core expires;
		public Expires_Core Expires
		{
			get
			{
				return expires;
			}
			set
			{
				expires = value;
				SetPropertyInstance(expires);
			}
		}

		/// <summary>
		/// Genre of the creative work
		/// </summary>
		private Genre_Core genre;
		public Genre_Core Genre
		{
			get
			{
				return genre;
			}
			set
			{
				genre = value;
				SetPropertyInstance(genre);
			}
		}

		/// <summary>
		/// Headline of the article
		/// </summary>
		private Headline_Core headline;
		public Headline_Core Headline
		{
			get
			{
				return headline;
			}
			set
			{
				headline = value;
				SetPropertyInstance(headline);
			}
		}

		/// <summary>
		/// The height of the media object.
		/// </summary>
		private Height_Core height;
		public Height_Core Height
		{
			get
			{
				return height;
			}
			set
			{
				height = value;
				SetPropertyInstance(height);
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
		/// The language of the content. please use one of the language codes from the <a href=\http://tools.ietf.org/html/bcp47\>IETF BCP 47 standard.</a>
		/// </summary>
		private InLanguage_Core inLanguage;
		public InLanguage_Core InLanguage
		{
			get
			{
				return inLanguage;
			}
			set
			{
				inLanguage = value;
				SetPropertyInstance(inLanguage);
			}
		}

		/// <summary>
		/// A count of a specific user interactions with this item\u2014for example, <code>20 UserLikes</code>, <code>5 UserComments</code>, or <code>300 UserDownloads</code>. The user interaction type should be one of the sub types of <a href=\http://schema.org/UserInteraction\>UserInteraction</a>.
		/// </summary>
		private InteractionCount_Core interactionCount;
		public InteractionCount_Core InteractionCount
		{
			get
			{
				return interactionCount;
			}
			set
			{
				interactionCount = value;
				SetPropertyInstance(interactionCount);
			}
		}

		/// <summary>
		/// Indicates whether this content is family friendly.
		/// </summary>
		private IsFamilyFriendly_Core isFamilyFriendly;
		public IsFamilyFriendly_Core IsFamilyFriendly
		{
			get
			{
				return isFamilyFriendly;
			}
			set
			{
				isFamilyFriendly = value;
				SetPropertyInstance(isFamilyFriendly);
			}
		}

		/// <summary>
		/// The keywords/tags used to describe this content.
		/// </summary>
		private Keywords_Core keywords;
		public Keywords_Core Keywords
		{
			get
			{
				return keywords;
			}
			set
			{
				keywords = value;
				SetPropertyInstance(keywords);
			}
		}

		/// <summary>
		/// Indicates that the CreativeWork contains a reference to, but is not necessarily about a concept.
		/// </summary>
		private Mentions_Core mentions;
		public Mentions_Core Mentions
		{
			get
			{
				return mentions;
			}
			set
			{
				mentions = value;
				SetPropertyInstance(mentions);
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
		/// Player type required\u2014for example, Flash or Silverlight.
		/// </summary>
		private PlayerType_Core playerType;
		public PlayerType_Core PlayerType
		{
			get
			{
				return playerType;
			}
			set
			{
				playerType = value;
				SetPropertyInstance(playerType);
			}
		}

		/// <summary>
		/// Specifies the Person or Organization that distributed the CreativeWork.
		/// </summary>
		private Provider_Core provider;
		public Provider_Core Provider
		{
			get
			{
				return provider;
			}
			set
			{
				provider = value;
				SetPropertyInstance(provider);
			}
		}

		/// <summary>
		/// The publisher of the creative work.
		/// </summary>
		private Publisher_Core publisher;
		public Publisher_Core Publisher
		{
			get
			{
				return publisher;
			}
			set
			{
				publisher = value;
				SetPropertyInstance(publisher);
			}
		}

		/// <summary>
		/// Link to page describing the editorial principles of the organization primarily responsible for the creation of the CreativeWork.
		/// </summary>
		private PublishingPrinciples_Core publishingPrinciples;
		public PublishingPrinciples_Core PublishingPrinciples
		{
			get
			{
				return publishingPrinciples;
			}
			set
			{
				publishingPrinciples = value;
				SetPropertyInstance(publishingPrinciples);
			}
		}

		/// <summary>
		/// The regions where the media is allowed. If not specified, then it's assumed to be allowed everywhere. Specify the countries in <a href=\http://en.wikipedia.org/wiki/ISO_3166\ target=\new\>ISO 3166 format</a>.
		/// </summary>
		private RegionsAllowed_Core regionsAllowed;
		public RegionsAllowed_Core RegionsAllowed
		{
			get
			{
				return regionsAllowed;
			}
			set
			{
				regionsAllowed = value;
				SetPropertyInstance(regionsAllowed);
			}
		}

		/// <summary>
		/// Indicates if use of the media require a subscription  (either paid or free). Allowed values are <code>yes</code> or <code>no</code>.
		/// </summary>
		private RequiresSubscription_Core requiresSubscription;
		public RequiresSubscription_Core RequiresSubscription
		{
			get
			{
				return requiresSubscription;
			}
			set
			{
				requiresSubscription = value;
				SetPropertyInstance(requiresSubscription);
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
		/// The Organization on whose behalf the creator was working.
		/// </summary>
		private SourceOrganization_Core sourceOrganization;
		public SourceOrganization_Core SourceOrganization
		{
			get
			{
				return sourceOrganization;
			}
			set
			{
				sourceOrganization = value;
				SetPropertyInstance(sourceOrganization);
			}
		}

		/// <summary>
		/// A thumbnail image relevant to the Thing.
		/// </summary>
		private ThumbnailURL_Core thumbnailURL;
		public ThumbnailURL_Core ThumbnailURL
		{
			get
			{
				return thumbnailURL;
			}
			set
			{
				thumbnailURL = value;
				SetPropertyInstance(thumbnailURL);
			}
		}

		/// <summary>
		/// If this MediaObject is an AudioObject or VideoObject, the transcript of that object.
		/// </summary>
		private Transcript_Core transcript;
		public Transcript_Core Transcript
		{
			get
			{
				return transcript;
			}
			set
			{
				transcript = value;
				SetPropertyInstance(transcript);
			}
		}

		/// <summary>
		/// Date when this media object was uploaded to this site.
		/// </summary>
		private UploadDate_Core uploadDate;
		public UploadDate_Core UploadDate
		{
			get
			{
				return uploadDate;
			}
			set
			{
				uploadDate = value;
				SetPropertyInstance(uploadDate);
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

		/// <summary>
		/// The version of the CreativeWork embodied by a specified resource.
		/// </summary>
		private Version_Core version;
		public Version_Core Version
		{
			get
			{
				return version;
			}
			set
			{
				version = value;
				SetPropertyInstance(version);
			}
		}

		/// <summary>
		/// An embedded video object.
		/// </summary>
		private Video_Core video;
		public Video_Core Video
		{
			get
			{
				return video;
			}
			set
			{
				video = value;
				SetPropertyInstance(video);
			}
		}

		/// <summary>
		/// The width of the media object.
		/// </summary>
		private Width_Core width;
		public Width_Core Width
		{
			get
			{
				return width;
			}
			set
			{
				width = value;
				SetPropertyInstance(width);
			}
		}

	}
}