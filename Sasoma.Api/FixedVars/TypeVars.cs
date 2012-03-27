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
    public struct TypeVars
    {
        /// <summary>
        /// 
        /// </summary>
        public enum BooleanValues
        {
            False,
            True
        }


        /// <summary>
        /// 
        /// </summary>
        public enum BookFormatType
        {
            EBook,
            Hardcover,
            Paperback
        }

        /// <summary>
        /// 
        /// </summary>
        public enum ItemAvailability
        {
            Discontinued,
            InStock,
            InStoreOnly,
            OnlineOnly,
            OutOfStock,
            PreOrder
        }

        /// <summary>
        /// 
        /// </summary>
        public enum OfferItemCondition
        {
            DamagedCondition,
            NewCondition,
            RefurbishedCondition,
            UsedCondition
        }

        private static List<KeyVal<int, string>> instancelist;
        public static List<KeyVal<int, string>> Instancelist
        {
            get
            {
                if (instancelist == null)
                {
                    instancelist = new List<KeyVal<int, string>>();

                    instancelist.Add(new KeyVal<int, string>(1, "False"));
                    instancelist.Add(new KeyVal<int, string>(1, "True"));
                    instancelist.Add(new KeyVal<int, string>(43, "EBook"));
                    instancelist.Add(new KeyVal<int, string>(43, "Hardcover"));
                    instancelist.Add(new KeyVal<int, string>(43, "Paperback"));
                    instancelist.Add(new KeyVal<int, string>(141, "Discontinued"));
                    instancelist.Add(new KeyVal<int, string>(141, "InStock"));
                    instancelist.Add(new KeyVal<int, string>(141, "InStoreOnly"));
                    instancelist.Add(new KeyVal<int, string>(141, "OnlineOnly"));
                    instancelist.Add(new KeyVal<int, string>(141, "OutOfStock"));
                    instancelist.Add(new KeyVal<int, string>(141, "PreOrder"));
                    instancelist.Add(new KeyVal<int, string>(191, "DamagedCondition"));
                    instancelist.Add(new KeyVal<int, string>(191, "NewCondition"));
                    instancelist.Add(new KeyVal<int, string>(191, "RefurbishedCondition"));
                    instancelist.Add(new KeyVal<int, string>(191, "UsedCondition"));
                }
                return instancelist;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public static string[] TypeIdArray = 
        {
            "Boolean","DataType","Date","Float","Integer","Number","Text","URL","AboutPage","AccountingService","AdministrativeArea",
            "AdultEntertainment","AggregateOffer","AggregateRating","Airport","AmusementPark","AnimalShelter","ApartmentComplex","Aquarium","ArtGallery",
            "Article","Attorney","AudioObject","AutoBodyShop","AutoDealer","AutoPartsStore","AutoRental","AutoRepair","AutoWash","AutomatedTeller",
            "AutomotiveBusiness","Bakery","BankOrCreditUnion","BarOrPub","Beach","BeautySalon","BedAndBreakfast","BikeStore","Blog","BlogPosting","BodyOfWater",
            "Book","BookFormatType","BookStore","BowlingAlley","Brewery","BuddhistTemple","BusStation","BusStop","BusinessEvent","CafeOrCoffeeShop",
            "Campground","Canal","Casino","CatholicChurch","Cemetery","CheckoutPage","ChildCare","ChildrensEvent","Church","City","CityHall",
            "CivicStructure","ClothingStore","CollectionPage","CollegeOrUniversity","ComedyClub","ComedyEvent","ComputerStore","ContactPage",
            "ContactPoint","Continent","ConvenienceStore","Corporation","Country","Courthouse","Distance","DryCleaningOrLaundry","CreativeWork",
            "Crematorium","DanceEvent","DanceGroup","DaySpa","DefenceEstablishment","Dentist","DepartmentStore","Duration","EducationEvent",
            "EducationalOrganization","Electrician","ElectronicsStore","ElementarySchool","Embassy","EmergencyService","EmploymentAgency",
            "Energy","EntertainmentBusiness","Enumeration","Event","EventVenue","ExerciseGym","FastFoodRestaurant","Festival","FinancialService",
            "FireStation","Florist","FoodEstablishment","FoodEvent","FurnitureStore","GardenStore","GasStation","GatedResidenceCommunity",
            "GeneralContractor","GeoCoordinates","GeoShape","GolfCourse","GovernmentBuilding","GovernmentOffice","GovernmentOrganization",
            "GroceryStore","HVACBusiness","HairSalon","HardwareStore","HealthAndBeautyBusiness","HealthClub",
            "HighSchool","HinduTemple","HobbyShop","HomeAndConstructionBusiness","HomeGoodsStore","Hospital","Hostel","Hotel","HousePainter",
            "IceCreamShop","ImageGallery","ImageObject","InsuranceAgency","Intangible","InternetCafe","ItemAvailability","ItemList","ItemPage",
            "JewelryStore","JobPosting","LakeBodyOfWater","Landform","LandmarksOrHistoricalBuildings","Language","LegislativeBuilding","Library",
            "LiquorStore","LiteraryEvent","Mosque","Motel","LocalBusiness","Locksmith","LodgingBusiness","Map","Mass","MotorcycleDealer","MediaObject",
            "MedicalClinic","MedicalOrganization","MensClothingStore","MiddleSchool","MobilePhoneStore","MotorcycleRepair","Mountain","Movie",
            "MovieRentalStore","MovieTheater","MovingCompany","Museum","MusicAlbum","MusicEvent","MusicGroup","MusicPlaylist","MusicRecording",
            "MusicStore","MusicVenue","MusicVideoObject","NGO","NailSalon","NewsArticle","NightClub","Notary","NutritionInformation",
            "OceanBodyOfWater","Offer","OfferItemCondition","OfficeEquipmentStore","Optician","Organization","OutletStore","Painting","Park",
            "ParkingFacility","PawnShop","PerformingArtsTheater","PerformingGroup","Person","PetStore","Pharmacy","Photograph","Physician","Place",
            "PlaceOfWorship","Playground","Plumber","PoliceStation","Pond","PostOffice","PostalAddress","Preschool","Product","ProfessionalService",
            "ProfilePage","PublicSwimmingPool","Quantity","RVPark","RadioStation","Rating","RealEstateAgent","Recipe","RecyclingCenter","Reservoir",
            "Residence","Restaurant","Review","RiverBodyOfWater","RoofingContractor","SaleEvent","ScholarlyArticle","School","Sculpture","SeaBodyOfWater",
            "SearchResultsPage","SelfStorage","ShoeStore","ShoppingCenter","SingleFamilyResidence","SiteNavigationElement","SkiResort","SocialEvent",
            "SportingGoodsStore","SportsActivityLocation","SportsClub","SportsEvent","SportsTeam","StadiumOrArena",
            "State","Store","StructuredValue","SubwayStation","Synagogue","TVEpisode","TVSeason","TVSeries","Table","TattooParlor","TaxiStand",
            "TelevisionStation","TennisComplex","TheaterEvent","TheaterGroup","Thing","TireShop","TouristAttraction","TouristInformationCenter",
            "ToyStore","TrainStation","TravelAgency","UserBlocks","UserCheckins","UserComments","UserDownloads","UserInteraction","UserLikes",
            "UserPageVisits","UserPlays","UserPlusOnes","UserTweets","VeterinaryCare","VideoGallery","VideoObject","VisualArtsEvent","Volcano",
            "WPAdBlock","WPFooter","WPHeader","WPSideBar","Waterfall","WebPage","WebPageElement","WholesaleStore","Winery","Zoo"
        };

        /// <summary>
        /// TypeAncestors array. TypeId is on the left, while the TypeIds of its ancestors are on the right.
        /// </summary>
        public static int[,] TypeAncestorArray = new int[,]
        {
            {0,1}, {2,1}, {3,1}, {3,5}, {4,1}, {4,5}, {5,1}, {6,1}, {7,1}, {7,6}, {8,78}, 
            {8,266}, {8,293}, {9,103}, {9,155}, {9,193}, {9,266}, {10,206}, {10,266}, {11,96}, {11,155}, {11,193}, 
            {11,266}, {12,138}, {12,189}, {12,266}, {13,138}, {13,222}, {13,266}, {14,62}, {14,206}, {14,266}, {15,96}, 
            {15,155}, {15,193}, {15,266}, {16,155}, {16,193}, {16,266}, {17,206}, {17,227}, {17,266}, {18,62}, {18,206}, 
            {18,266}, {19,96}, {19,155}, {19,193}, {19,266}, {20,78}, {20,266}, {21,155}, {21,193}, {21,216}, {21,266}, 
            {22,78}, {22,161}, {22,266}, {23,30}, {23,155}, {23,193}, {23,266}, {24,30}, {24,155}, {24,193}, {24,266}, 
            {25,155}, {25,193}, {25,252}, {25,266}, {26,30}, {26,155}, {26,193}, {26,266}, {27,30}, {27,155}, {27,193}, 
            {27,266}, {28,30}, {28,155}, {28,193}, {28,266}, {29,103}, {29,155}, {29,193}, {29,266}, {30,155}, {30,193}, 
            {30,266}, {31,106}, {31,155}, {31,193}, {31,266}, {32,103}, {32,155}, {32,193}, {32,266}, {33,106}, {33,155}, 
            {33,193}, {33,266}, {34,62}, {34,206}, {34,266}, {35,123}, {35,155}, {35,193}, {35,266}, {36,155}, {36,157}, 
            {36,193}, {36,266}, {37,155}, {37,193}, {37,252}, {37,266}, {38,78}, {38,266}, {39,20}, {39,78}, {39,266}, 
            {40,146}, {40,206}, {40,266}, {41,78}, {41,266}, {42,97}, {42,138}, {42,266}, {43,155}, {43,193}, {43,252}, 
            {43,266}, {44,155}, {44,193}, {44,246}, {44,266}, {45,106}, {45,155}, {45,193}, {45,266}, {46,62}, {46,206}, 
            {46,207}, {46,266}, {47,62}, {47,206}, {47,266}, {48,62}, {48,206}, {48,266}, {49,98}, {49,266}, {50,106}, 
            {50,155}, {50,193}, {50,266}, {51,62}, {51,206}, {51,266}, {52,40}, {52,146}, {52,206}, {52,266}, {53,96}, 
            {53,155}, {53,193}, {53,266}, {54,62}, {54,206}, {54,207}, {54,266}, {55,62}, {55,206}, {55,266}, {56,78}, 
            {56,266}, {56,293}, {57,155}, {57,193}, {57,266}, {58,98}, {58,266}, {59,62}, {59,206}, {59,207}, {59,266}, 
            {60,10}, {60,206}, {60,266}, {61,62}, {61,116}, {61,206}, {61,266}, {62,206}, {62,266}, {63,155}, {63,193}, 
            {63,252}, {63,266}, {64,78}, {64,266}, {64,293}, {65,88}, {65,193}, {65,266}, {66,96}, {66,155}, {66,193}, 
            {66,266}, {67,98}, {67,266}, {68,155}, {68,193}, {68,252}, {68,266}, {69,78}, {69,266}, {69,293}, {70,138}, 
            {70,253}, {70,266}, {71,146}, {71,206}, {71,266}, {72,155}, {72,193}, {72,252}, {72,266}, {73,193}, {73,266}, 
            {74,10}, {74,206}, {74,266}, {75,62}, {75,116}, {75,206}, {75,266}, {76,138}, {76,219}, {76,266}, {77,155}, 
            {77,193}, {77,266}, {78,266}, {79,62}, {79,206}, {79,266}, {80,98}, {80,266}, {81,193}, {81,200}, {81,266}, 
            {82,123}, {82,155}, {82,193}, {82,266}, {83,62}, {83,116}, {83,206}, {83,266}, {84,155}, {84,163}, {84,193}, 
            {84,266}, {85,155}, {85,193}, {85,252}, {85,266}, {86,138}, {86,219}, {86,266}, {87,98}, {87,266}, {88,193}, 
            {88,266}, {89,128}, {89,155}, {89,193}, {89,266}, {90,155}, {90,193}, {90,252}, {90,266}, {91,88}, {91,193}, 
            {91,266}, {92,62}, {92,116}, {92,206}, {92,266}, {93,155}, {93,193}, {93,266}, {94,155}, {94,193}, {94,266}, 
            {95,138}, {95,219}, {95,266}, {96,155}, {96,193}, {96,266}, {97,138}, {97,266}, {98,266}, {99,62}, {99,206}, 
            {99,266}, {100,155}, {100,193}, {100,246}, {100,266}, {101,106}, {101,155}, {101,193}, {101,266}, {102,98}, {102,266}, 
            {103,155}, {103,193}, {103,266}, {104,62}, {104,206}, {104,266}, {105,155}, {105,193}, {105,252}, {105,266}, {106,155}, 
            {106,193}, {106,266}, {107,98}, {107,266}, {108,155}, {108,193}, {108,252}, {108,266}, {109,155}, {109,193}, {109,252}, 
            {109,266}, {110,30}, {110,155}, {110,193}, {110,266}, {111,206}, {111,227}, {111,266}, {112,128}, {112,155}, {112,193}, 
            {112,266}, {113,138}, {113,253}, {113,266}, {114,138}, {114,253}, {114,266}, {115,155}, {115,193}, {115,246}, {115,266}, 
            {116,62}, {116,206}, {116,266}, {117,155}, {117,193}, {117,266}, {118,193}, {118,266}, {119,155}, {119,193}, {119,252}, 
            {119,266}, {120,128}, {120,155}, {120,193}, {120,266}, {121,123}, {121,155}, {121,193}, {121,266}, {122,155}, {122,193}, 
            {122,252}, {122,266}, {123,155}, {123,193}, {123,266}, {124,123}, {124,155}, {124,193}, {124,266}, {125,88}, {125,193}, 
            {125,266}, {126,62}, {126,206}, {126,207}, {126,266}, {127,155}, {127,193}, {127,252}, {127,266}, {128,155}, {128,193}, 
            {128,266}, {129,155}, {129,193}, {129,252}, {129,266}, {130,155}, {130,163}, {130,193}, {130,266}, {131,155}, {131,157}, 
            {131,193}, {131,266}, {132,155}, {132,157}, {132,193}, {132,266}, {133,128}, {133,155}, {133,193}, {133,266}, {134,106}, 
            {134,155}, {134,193}, {134,266}, {135,64}, {135,78}, {135,266}, {135,293}, {136,78}, {136,161}, {136,266}, {137,103}, 
            {137,155}, {137,193}, {137,266}, {138,266}, {139,155}, {139,193}, {139,266}, {140,97}, {140,138}, {140,266}, {141,78}, 
            {141,266}, {142,78}, {142,266}, {142,293}, {143,155}, {143,193}, {143,252}, {143,266}, {144,138}, {144,266}, {145,40}, 
            {145,146}, {145,206}, {145,266}, {146,206}, {146,266}, {147,206}, {147,266}, {148,138}, {148,266}, {149,62}, {149,116}, 
            {149,206}, {149,266}, {150,155}, {150,193}, {150,266}, {151,155}, {151,193}, {151,252}, {151,266}, {152,98}, {152,266}, 
            {153,62}, {153,206}, {153,207}, {153,266}, {154,155}, {154,157}, {154,193}, {154,266}, {155,193}, {155,266}, {156,128}, 
            {156,155}, {156,193}, {156,266}, {157,155}, {157,193}, {157,266}, {158,78}, {158,266}, {159,138}, {159,219}, {159,266}, 
            {160,30}, {160,155}, {160,193}, {160,266}, {161,78}, {161,266}, {162,155}, {162,163}, {162,193}, {162,266}, {163,155}, 
            {163,193}, {163,266}, {164,155}, {164,193}, {164,252}, {164,266}, {165,88}, {165,193}, {165,266}, {166,155}, {166,193}, 
            {166,252}, {166,266}, {167,30}, {167,155}, {167,193}, {167,266}, {168,146}, {168,206}, {168,266}, {169,78}, {169,266}, 
            {170,155}, {170,193}, {170,252}, {170,266}, {171,96}, {171,155}, {171,193}, {171,266}, {172,128}, {172,155}, {172,193}, 
            {172,266}, {173,62}, {173,206}, {173,266}, {174,78}, {174,177}, {174,266}, {175,98}, {175,266}, {176,193}, {176,200}, 
            {176,266}, {177,78}, {177,266}, {178,78}, {178,266}, {179,155}, {179,193}, {179,252}, {179,266}, {180,62}, {180,206}, 
            {180,266}, {181,78}, {181,161}, {181,266}, {182,193}, {182,266}, {183,123}, {183,155}, {183,193}, {183,266}, {184,20}, 
            {184,78}, {184,266}, {185,96}, {185,155}, {185,193}, {185,266}, {186,155}, {186,193}, {186,216}, {186,266}, {187,138}, 
            {187,253}, {187,266}, {188,40}, {188,146}, {188,206}, {188,266}, {189,138}, {189,266}, {190,97}, {190,138}, {190,266}, 
            {191,155}, {191,193}, {191,252}, {191,266}, {192,155}, {192,163}, {192,193}, {192,266}, {193,266}, {194,155}, {194,193}, 
            {194,252}, {194,266}, {195,78}, {195,266}, {196,62}, {196,206}, {196,266}, {197,62}, {197,206}, {197,266}, {198,155}, 
            {198,193}, {198,252}, {198,266}, {199,62}, {199,206}, {199,266}, {200,193}, {200,266}, {201,266}, {202,155}, {202,193}, 
            {202,252}, {202,266}, {203,155}, {203,163}, {203,193}, {203,266}, {204,78}, {204,266}, {205,155}, {205,163}, {205,193}, 
            {205,266}, {206,266}, {207,62}, {207,206}, {207,266}, {208,62}, {208,206}, {208,266}, {209,128}, {209,155}, {209,193}, 
            {209,266}, {210,62}, {210,206}, {210,266}, {211,40}, {211,146}, {211,206}, {211,266}, {212,117}, {212,155}, {212,193}, 
            {212,266}, {213,70}, {213,138}, {213,253}, {213,266}, {214,88}, {214,193}, {214,266}, {215,266}, {216,155}, {216,193}, 
            {216,266}, {217,78}, {217,266}, {217,293}, {218,155}, {218,193}, {218,246}, {218,266}, {219,138}, {219,266}, {220,62}, 
            {220,206}, {220,266}, {221,155}, {221,193}, {221,266}, {222,138}, {222,266}, {223,155}, {223,193}, {223,266}, {224,78}, 
            {224,266}, {225,155}, {225,193}, {225,266}, {226,40}, {226,146}, {226,206}, {226,266}, {227,206}, {227,266}, {228,106}, 
            {228,155}, {228,193}, {228,266}, {229,78}, {229,266}, {230,40}, {230,146}, {230,206}, {230,266}, {231,128}, {231,155}, 
            {231,193}, {231,266}, {232,98}, {232,266}, {233,20}, {233,78}, {233,266}, {234,88}, {234,193}, {234,266}, {235,78}, 
            {235,266}, {236,40}, {236,146}, {236,206}, {236,266}, {237,78}, {237,266}, {237,293}, {238,155}, {238,193}, {238,266}, 
            {239,155}, {239,193}, {239,252}, {239,266}, {240,155}, {240,193}, {240,266}, {241,206}, {241,227}, {241,266}, {242,78}, 
            {242,266}, {242,294}, {243,155}, {243,193}, {243,246}, {243,266}, {244,98}, {244,266}, {245,155}, {245,193}, {245,252}, 
            {245,266}, {246,155}, {246,193}, {246,266}, {247,155}, {247,193}, {247,246}, {247,266}, {248,98}, {248,266}, {249,193}, 
            {249,266}, {250,62}, {250,206}, {250,266}, {251,10}, {251,206}, {251,266}, {252,155}, {252,193}, {252,266}, {253,138}, 
            {253,266}, {254,62}, {254,206}, {254,266}, {255,62}, {255,206}, {255,207}, {255,266}, {256,78}, {256,266}, {257,78}, 
            {257,266}, {258,78}, {258,266}, {259,78}, {259,266}, {259,294}, {260,123}, {260,155}, {260,193}, {260,266}, {261,62}, 
            {261,206}, {261,266}, {262,155}, {262,193}, {262,266}, {263,155}, {263,193}, {263,246}, {263,266}, {264,98}, {264,266}, 
            {265,193}, {265,200}, {265,266}, {267,155}, {267,193}, {267,252}, {267,266}, {268,206}, {268,266}, {269,155}, {269,193}, 
            {269,266}, {270,155}, {270,193}, {270,252}, {270,266}, {271,62}, {271,206}, {271,266}, {272,155}, {272,193}, {272,266}, 
            {273,98}, {273,266}, {273,277}, {274,98}, {274,266}, {274,277}, {275,98}, {275,266}, {275,277}, {276,98}, {276,266}, 
            {276,277}, {277,98}, {277,266}, {278,98}, {278,266}, {278,277}, {279,98}, {279,266}, {279,277}, {280,98}, {280,266}, 
            {280,277}, {281,98}, {281,266}, {281,277}, {282,98}, {282,266}, {282,277}, {283,155}, {283,163}, {283,193}, {283,266}, 
            {284,64}, {284,78}, {284,266}, {284,293}, {285,78}, {285,161}, {285,266}, {286,98}, {286,266}, {287,146}, {287,206}, 
            {287,266}, {288,78}, {288,266}, {288,294}, {289,78}, {289,266}, {289,294}, {290,78}, {290,266}, {290,294}, {291,78}, 
            {291,266}, {291,294}, {292,40}, {292,146}, {292,206}, {292,266}, {293,78}, {293,266}, {294,78}, {294,266}, {295,155}, 
            {295,193}, {295,252}, {295,266}, {296,106}, {296,155}, {296,193}, {296,266}, {297,62}, {297,206}, {297,266}
        };        
    }

}
