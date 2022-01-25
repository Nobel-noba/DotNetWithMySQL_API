using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace PracticeA.Models
{
    public class Users
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public ObjectId Id { get; set; }
        public int userid { get; set; }
        public string name { get; set; }
    }
}
