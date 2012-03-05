using System;
using Sasoma.Microdata.Types;
using Sasoma.Microdata.Properties;

namespace Sasoma.Microdata.Interfaces
{
    public interface IMediaObject : ICreativeWork
    {
        AssociatedArticle_Core AssociatedArticle { get; set; }
        Bitrate_Core Bitrate { get; set; }
        ContentSize_Core ContentSize { get; set; }
        ContentURL_Core ContentURL { get; set; }
        Properties.Duration_Core Duration { get; set; }
        EmbedURL_Core EmbedURL { get; set; }
        EncodesCreativeWork_Core EncodesCreativeWork { get; set; }
        EncodingFormat_Core EncodingFormat { get; set; }
        Expires_Core Expires { get; set; }
        Height_Core Height { get; set; }
        PlayerType_Core PlayerType { get; set; }
        RegionsAllowed_Core RegionsAllowed { get; set; }
        RequiresSubscription_Core RequiresSubscription { get; set; }
        UploadDate_Core UploadDate { get; set; }
        Width_Core Width { get; set; }
    }
}
