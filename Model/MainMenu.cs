using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;


namespace apiTestUnipCore.Model {
    public class MainMenu
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string  Id { get; set; }
        public string name { get; set; }

        public string icon { get; set; }

        public IEnumerable<SubMenu> items {get; set;}
    }
}