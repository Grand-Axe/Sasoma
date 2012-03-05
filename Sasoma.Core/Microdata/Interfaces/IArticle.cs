using System;
using Sasoma.Microdata.Types;
using Sasoma.Microdata.Properties;

namespace Sasoma.Microdata.Interfaces
{
    public interface IArticle : ICreativeWork
    {
        ArticleBody_Core ArticleBody { get; set; }
        ArticleSection_Core ArticleSection { get; set; }
        WordCount_Core WordCount { get; set; }
    }
}
