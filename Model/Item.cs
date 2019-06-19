using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;


namespace apiTestUnipCore.Model {
    public class Item
    {
        public string name { get; set; }

        public string icon { get; set; }
        
    }
}