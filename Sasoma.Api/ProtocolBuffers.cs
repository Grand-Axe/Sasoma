using System;

using Sasoma.Microdata.Interfaces;
using ProtoBuf.Meta;
using Sasoma.Microdata.Properties;

namespace Sasoma.Api
{
    public class ProtocolBuffers
    {
        public static void Serialize<T>(IDataType microdataDataType) where T : IDataType
        {
        }

        public static void Serialize<T>(IProperty microdataProperty) where T : IProperty
        {
        }

        public static void Serialize<T>(IThing microdataThing) where T : IThing
        {
            RuntimeTypeModel model = TypeModel.Create();
            MetaType metaType1 = model.Add(typeof(T), false);
            metaType1.Add(1, "Ancestors")
                .Add(2, "Properties")
                .Add(3, "Schema_Org_Url")
                .Add(4, "SubTypes")
                .Add(5, "SuperTypes")
                .Add(6, "TypeId")
                .Add(7, "Id")
                .Add(8, "Label");

            //Description
            MetaType metaTypeForDescription = model.Add(typeof(Description_Core), false);
            metaTypeForDescription.Add(9, "Id")
                .Add(1, "Label")
                .Add(2, "Domains")
                .Add(3, "PropertyId")
                .Add(4, "Ranges");

            //Image_Core Image
            MetaType metaTypeForImage = model.Add(typeof(Image_Core), false);
            metaTypeForImage.Add(14, "Id")
                .Add(1, "Label")
                .Add(2, "Domains")
                .Add(3, "PropertyId")
                .Add(4, "Ranges");

            //Name_Core Name
            MetaType metaTypeForName = model.Add(typeof(Name_Core), false);
            metaTypeForName.Add(19, "Id")
                .Add(1, "Label")
                .Add(2, "Domains")
                .Add(3, "PropertyId")
                .Add(4, "Ranges");

            //Properties.URL_Core
            MetaType metaTypeForURL = model.Add(typeof(URL_Core), false);
            metaTypeForURL.Add(24, "Id")
                .Add(1, "Label")
                .Add(2, "Domains")
                .Add(3, "PropertyId")
                .Add(4, "Ranges");

            int tagIndex = 29;
            for (int i = 0; i < microdataThing.Properties.Length; i++)
            {
                tagIndex++;
            }
        }
    }
}

/*
public class Helper
{
    public static TypeModel CreateModel()
    {
        RuntimeTypeModel model = TypeModel.Create();

        model.Add(typeof(Client), false)
            .Add(1, "Id")
            .Add(2, "Name")
            .Add(3, "Trades");

        model.Add(typeof(Trade), false)
            .Add(1, "Ticker")
            .Add(2, "TradeType")
            .Add(3, "UnitPrice")
            .Add(4, "Quantity")
            .Add(5, "TransactionDate");

        TypeModel compiled = model.Compile();

        return compiled;
    }

    public static void RunPerfTests(int iterations)
    {
        var model = CreateModel();
        var clientWrite = Factory.Create();

        var stopwatch = new Stopwatch();
        stopwatch.Start();

        for (int i = 0; i < iterations; i++)
            using (Stream memoryStream = new MemoryStream())
                model.Serialize(memoryStream, clientWrite);

        stopwatch.Stop();

        using (Stream memoryStream = new MemoryStream())
        {
            model.Serialize(memoryStream, clientWrite);

            Console.WriteLine("ProtoBuf-net with compiled model ({0} size)", memoryStream.Length);
            Console.WriteLine("    Write: {0}", stopwatch.Elapsed);

            stopwatch.Reset();
            stopwatch.Start();

            for (int i = 0; i < iterations; i++)
            {
                memoryStream.Position = 0;
                var clientRead = model.Deserialize(memoryStream, null, typeof(Client));
            }
        }

        stopwatch.Stop();
        Console.WriteLine("    Read:  {0}", stopwatch.Elapsed);
    }
}
*/