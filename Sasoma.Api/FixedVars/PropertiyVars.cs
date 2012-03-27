using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sasoma.Api.FixedVars
{
    // !!! Do not edit this struct except you know what you are doing and why. !!!

    /// <summary>
    /// 
    /// </summary>
    public class PropertiyVars
    {
        /// <summary>
        /// 
        /// </summary>
        public static string[] PropertyList = 
        {
            "about","acceptsReservations","accountablePerson","actors","additionalName","address","addressCountry",
            "addressLocality","addressRegion","affiliation","aggregateRating","albums","alternativeHeadline","alumni",
            "alumniOf","articleBody","articleSection","associatedArticle","associatedMedia","attendees",
            "audio","comment","commentText","commentTime","author","availability","awards","baseSalary","benefits",
            "bestRating","birthDate","bitrate","blogPosts","bookEdition","bookFormat","box","branchOf","brand",
            "breadcrumb","byArtist","calories","caption","carbohydrateContent","children","cholesterolContent","circle",
            "colleagues","contactPoints","contactType","containedIn","contentLocation","contentRating","contentSize",
            "contentURL","contributor","cookTime","cookingMethod","copyrightHolder","copyrightYear","creator","currenciesAccepted",
            "dateCreated","dateModified","datePosted","datePublished","dateline","deathDate","description","director",
            "discusses","discussionUrl","duration","editor","educationRequirements","elevation","email","embedURL",
            "employees","employmentType","encodesCreativeWork","encodingFormat","encodings","endDate","episodeNumber",
            "episodes","events","exifData","experienceRequirements","expires","familyName","fatContent","faxNumber",
            "fiberContent","follows","founders","foundingDate","gender","genre","geo","givenName","headline","height",
            "highPrice","hiringOrganization","homeLocation","honorificPrefix","honorificSuffix","illustrator","image",
            "inAlbum","inLanguage","inPlaylist","incentives","industry","ingredients","interactionCount","isFamilyFriendly",
            "isPartOf","isbn","itemCondition","itemListElement","itemListOrder","itemOffered","itemReviewed","jobLocation",
            "jobTitle","keywords","knows","latitude","line","location","longitude","lowPrice","mainContentOfPage","manufacturer",
            "maps","memberOf","members","mentions","menu","model","musicBy","musicGroupMember","name","nationality","numTracks",
            "numberOfEpisodes","numberOfPages","nutrition","occupationalCategory","offerCount","offers","openingHours","parents",
            "partOfSeason","partOfTVSeries","paymentAccepted","performerIn","performers","photos","playerType","polygon",
            "postOfficeBoxNumber","postalCode","prepTime","price","priceCurrency","priceRange","priceValidUntil","primaryImageOfPage",
            "printColumn","printEdition","printPage","printSection","producer","productID","productionCompany","proteinContent",
            "provider","publisher","publishingPrinciples","qualifications","ratingCount","ratingValue","recipeCategory",
            "recipeCuisine","recipeInstructions","recipeYield","regionsAllowed","relatedTo","replyToUrl","representativeOfPage",
            "requiresSubscription","responsibilities","reviewBody","reviewCount","telephone","thumbnail","reviewRating","reviews",
            "salaryCurrency","saturatedFatContent","seasonNumber","seasons","seller","servesCuisine","servingSize","siblings",
            "significantLinks","skills","sodiumContent","sourceOrganization","specialCommitments","spouse","startDate",
            "streetAddress","subEvents","sugarContent","superEvent","thumbnailUrl","tickerSymbol","title","totalTime","tracks",
            "trailer","transFatContent","transcript","unsaturatedFatContent","uploadDate","url","version","video",
            "videoFrameSize","videoQuality","width","wordCount","workHours","workLocation","worksFor","worstRating"
        };

        /// <summary>
        /// 
        /// </summary>
        public static int[,] PropertyRangeArray = new int[,]
        {
            {0,266}, {1,6}, {1,7}, {2,201}, {3,201}, {4,6}, {5,213}, {6,74}, {7,6}, {8,6}, {9,193}, 
            {10,13}, {11,174}, {12,6}, {13,201}, {14,88}, {15,6}, {16,6}, {17,184}, {18,161}, {19,193}, {19,201}, 
            {20,22}, {21,275}, {22,6}, {23,2}, {24,193}, {24,201}, {25,140}, {26,6}, {27,5}, {28,6}, {29,5}, 
            {29,6}, {30,2}, {31,6}, {32,39}, {33,6}, {34,42}, {35,6}, {36,193}, {37,193}, {38,6}, {39,176}, 
            {40,95}, {41,6}, {42,159}, {43,201}, {44,159}, {45,6}, {46,201}, {47,70}, {48,6}, {49,206}, {50,206}, 
            {51,6}, {52,6}, {53,7}, {54,193}, {54,201}, {55,86}, {56,6}, {57,193}, {57,201}, {58,5}, {59,193}, 
            {59,201}, {60,6}, {61,2}, {62,2}, {63,2}, {64,2}, {65,6}, {66,2}, {67,6}, {68,201}, {69,78}, 
            {70,7}, {71,86}, {72,201}, {73,6}, {74,5}, {74,6}, {75,6}, {76,7}, {77,201}, {78,6}, {79,78}, 
            {80,6}, {81,161}, {82,2}, {83,5}, {84,256}, {85,98}, {86,6}, {87,6}, {88,2}, {89,6}, {90,159}, 
            {91,6}, {92,159}, {93,201}, {94,201}, {95,2}, {96,6}, {97,6}, {98,113}, {98,114}, {99,6}, {100,6}, 
            {101,76}, {102,5}, {102,6}, {103,193}, {104,70}, {104,206}, {105,6}, {106,6}, {107,201}, {108,7}, {109,174}, 
            {110,6}, {111,177}, {112,6}, {113,6}, {114,6}, {115,6}, {116,0}, {117,64}, {118,6}, {119,190}, {120,6}, 
            {121,6}, {122,215}, {123,266}, {124,206}, {125,6}, {126,6}, {127,201}, {128,5}, {128,6}, {129,6}, {130,206}, 
            {130,213}, {131,5}, {131,6}, {132,5}, {132,6}, {133,294}, {134,193}, {135,7}, {136,193}, {137,193}, {137,201}, 
            {138,266}, {139,6}, {139,7}, {140,6}, {141,176}, {141,201}, {142,201}, {143,6}, {144,74}, {145,4}, {146,5}, 
            {147,4}, {148,187}, {149,6}, {150,4}, {151,189}, {152,86}, {153,201}, {154,257}, {155,258}, {156,6}, {157,98}, 
            {158,193}, {158,201}, {159,136}, {159,204}, {160,6}, {161,6}, {162,6}, {163,6}, {164,86}, {165,5}, {165,6}, 
            {166,6}, {167,6}, {168,2}, {169,136}, {170,6}, {171,6}, {172,6}, {173,6}, {174,201}, {175,6}, {176,193}, 
            {177,159}, {178,193}, {178,201}, {179,193}, {180,7}, {181,6}, {182,5}, {183,6}, {184,6}, {185,6}, {186,6}, 
            {187,6}, {188,206}, {189,201}, {190,7}, {191,0}, {192,0}, {193,6}, {194,6}, {195,5}, {196,6}, {197,136}, 
            {198,222}, {199,229}, {200,6}, {201,159}, {202,4}, {203,257}, {204,193}, {205,6}, {206,6}, {207,201}, {208,7}, 
            {209,6}, {210,159}, {211,193}, {212,6}, {213,201}, {214,2}, {215,6}, {216,98}, {217,159}, {218,98}, {219,7}, 
            {220,6}, {221,6}, {222,86}, {223,178}, {224,285}, {225,159}, {226,6}, {227,159}, {228,2}, {229,7}, {230,5}, 
            {231,285}, {232,6}, {233,6}, {234,76}, {235,4}, {236,6}, {237,70}, {237,206}, {238,193}, {239,5}, {239,6}
        };

        /// <summary>
        /// 
        /// </summary>
        public static int[,] PropertyDomainArray = new int[,]
        {
            {0,78}, {1,106}, {2,78}, {3,169}, {3,256}, {3,258}, {4,201}, {5,193}, {5,201}, {5,206}, {6,213}, 
            {7,213}, {8,213}, {9,201}, {10,78}, {10,189}, {10,193}, {10,206}, {10,215}, {11,176}, {12,78}, {13,88}, 
            {14,201}, {15,20}, {16,20}, {17,161}, {18,78}, {19,98}, {20,78}, {21,78}, {22,275}, {23,275}, {24,78}, 
            {25,189}, {26,78}, {26,201}, {27,144}, {28,144}, {29,222}, {30,201}, {31,161}, {32,38}, {33,41}, {34,41}, 
            {35,114}, {36,155}, {37,215}, {38,293}, {39,174}, {39,178}, {40,187}, {41,136}, {41,285}, {42,187}, {43,201}, 
            {44,187}, {45,114}, {46,201}, {47,193}, {47,201}, {48,70}, {49,206}, {50,78}, {51,78}, {52,161}, {53,161}, 
            {54,78}, {55,224}, {56,224}, {57,78}, {58,78}, {59,78}, {59,275}, {60,155}, {61,78}, {62,78}, {63,144}, 
            {64,78}, {65,184}, {66,201}, {67,266}, {68,169}, {68,256}, {68,258}, {69,275}, {70,78}, {71,98}, {71,161}, 
            {71,169}, {71,178}, {72,78}, {73,144}, {74,113}, {74,114}, {75,70}, {75,193}, {75,201}, {76,161}, {77,193}, 
            {78,144}, {79,161}, {80,161}, {81,78}, {82,98}, {82,257}, {82,258}, {83,256}, {84,257}, {84,258}, {85,193}, 
            {85,206}, {86,136}, {87,144}, {88,161}, {89,201}, {90,187}, {91,70}, {91,193}, {91,201}, {91,206}, {92,187}, 
            {93,201}, {94,193}, {95,193}, {96,201}, {97,78}, {98,206}, {99,201}, {100,78}, {101,161}, {102,12}, {103,144}, 
            {104,201}, {105,201}, {106,201}, {107,41}, {108,266}, {109,178}, {110,78}, {111,178}, {112,144}, {113,144}, {114,224}, 
            {115,78}, {115,193}, {115,201}, {115,206}, {116,78}, {117,293}, {118,41}, {119,189}, {120,141}, {121,141}, {122,189}, 
            {123,13}, {123,229}, {124,144}, {125,201}, {126,78}, {127,201}, {128,113}, {129,114}, {130,98}, {130,193}, {131,113}, 
            {132,12}, {133,293}, {134,215}, {135,206}, {136,201}, {137,193}, {138,78}, {139,106}, {140,215}, {141,169}, {141,256}, 
            {141,258}, {142,176}, {143,266}, {144,201}, {145,177}, {146,257}, {146,258}, {147,41}, {148,224}, {149,144}, {150,12}, 
            {151,78}, {151,98}, {151,215}, {152,62}, {152,155}, {153,201}, {154,256}, {155,256}, {155,257}, {156,155}, {157,201}, 
            {158,98}, {159,206}, {160,161}, {161,114}, {162,213}, {163,213}, {164,224}, {165,189}, {166,189}, {167,155}, {168,189}, 
            {169,293}, {170,184}, {171,184}, {172,184}, {173,184}, {174,169}, {174,256}, {174,258}, {175,215}, {176,169}, {176,256}, 
            {176,258}, {176,285}, {177,187}, {178,78}, {179,78}, {180,78}, {181,144}, {182,13}, {183,222}, {184,224}, {185,224}, 
            {186,224}, {187,224}, {188,161}, {189,201}, {190,275}, {191,136}, {192,161}, {193,144}, {194,229}, {195,13}, {196,70}, 
            {196,193}, {196,201}, {196,206}, {197,136}, {197,285}, {198,229}, {199,78}, {199,189}, {199,193}, {199,206}, {199,215}, 
            {200,144}, {201,187}, {202,257}, {203,258}, {204,189}, {205,106}, {206,187}, {207,201}, {208,293}, {209,144}, {210,187}, 
            {211,78}, {212,144}, {213,201}, {214,98}, {214,257}, {214,258}, {215,213}, {216,98}, {217,187}, {218,98}, {219,78}, 
            {220,73}, {221,144}, {222,224}, {223,176}, {223,177}, {224,169}, {224,256}, {224,257}, {224,258}, {225,187}, {226,22}, 
            {226,285}, {227,187}, {228,161}, {229,266}, {230,78}, {231,78}, {232,285}, {233,285}, {234,161}, {235,20}, {236,144}, 
            {237,201}, {238,201}, {239,222}
        };
    }

}
