using System.Collections.Generic;

using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace WFClient
{
    public class Game
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string Name { get; set; }

        public string Developer { get; set; }

        public string Publisher { get; set; }

        public List<string> Platforms { get; set; }

        public override string ToString() 
            => $"\n Nazwa: {this.Name}\n Wydawca: {this.Developer} \n Producent: {this.Publisher} \n Platformy: {string.Join(",", Platforms)}";
    }
}