using System;
using Sasoma.Microdata.Types;
using Sasoma.Microdata.Properties;

namespace Sasoma.Microdata.Interfaces
{
    public interface ICreativeWork : IThing
    {
        About_Core About { get; set; }
        AccountablePerson_Core AccountablePerson { get; set; }
        Properties.AggregateRating_Core AggregateRating { get; set; }
        AlternativeHeadline_Core AlternativeHeadline { get; set; }
        AssociatedMedia_Core AssociatedMedia { get; set; }
        Audio_Core Audio { get; set; }
        Author_Core Author { get; set; }
        Awards_Core Awards { get; set; }
        Comment_Core Comment { get; set; }
        ContentLocation_Core ContentLocation { get; set; }
        ContentRating_Core ContentRating { get; set; }
        Contributor_Core Contributor { get; set; }
       CopyrightHolder_Core CopyrightHolder { get; set; }
       CopyrightYear_Core CopyrightYear { get; set; }
        Creator_Core Creator { get; set; }
       DateCreated_Core DateCreated { get; set; }
         DateModified_Core  DateModified { get; set; }
        DatePublished_Core DatePublished { get; set; }
        DiscussionURL_Core DiscussionURL { get; set; }
        Editor_Core Editor { get; set; }
        Encodings_Core Encodings { get; set; }
        Genre_Core Genre { get; set; }
        Headline_Core Headline { get; set; }
        InLanguage_Core InLanguage { get; set; }
        InteractionCount_Core InteractionCount { get; set; }
        IsFamilyFriendly_Core IsFamilyFriendly { get; set; }
        Keywords_Core Keywords { get; set; }
        Mentions_Core Mentions { get; set; }
        Offers_Core Offers { get; set; }
        Provider_Core Provider { get; set; }
        Publisher_Core Publisher { get; set; }
        PublishingPrinciples_Core PublishingPrinciples { get; set; }
        Reviews_Core Reviews { get; set; }
        SourceOrganization_Core SourceOrganization { get; set; }
        ThumbnailURL_Core ThumbnailURL { get; set; }
        Version_Core Version { get; set; }
        Video_Core Video { get; set; }
    }
}
