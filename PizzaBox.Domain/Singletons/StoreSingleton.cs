using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;
using PizzaBox.Storing;

namespace PizzaBox.Domain.Singletons
{
    public class StoreSingleton
    {
        private static StoreSingleton _storeSingleton;
        public List<AStore> Stores { get; set; }
        public static StoreSingleton Instance 
        {
            get
            {
                if (_storeSingleton == null)
            {
                _storeSingleton = new StoreSingleton();
            }

            return _storeSingleton;
            }
        }

        private StoreSingleton()
        {
            var fs = new FileStorage();

            if (Stores == null)
            {
                Stores = fs.ReadFromXml<AStore>();
            }
        }

        public void WriteToXml(List<AStore> stores)
        {
            var path = @"store.xml";
            StreamWriter writer = new StreamWriter(path);
            XmlSerializer serializer = new XmlSerializer(typeof(List<AStore>));

            serializer.Serialize(writer, stores);
        }

        public IEnumerable<AStore> ReadFromXml()
        {
            var path = @"store.xml";
            StreamReader reader = new StreamReader(path);
            XmlSerializer serializer = new XmlSerializer(typeof(List<AStore>));

            return serializer.Deserialize(reader) as List<AStore>;
        }
    }
}