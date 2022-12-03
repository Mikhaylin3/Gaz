using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace GazFinal.Data
{
    [BsonKnownTypes(typeof(Desingner), typeof(Developer), typeof(Projector))]
    public class User
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        ObjectId id;
        public string? Login { get; set; }
        public string? Password { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        [BsonRequired]
        public string? Phone { get; set;}
        
    }
}
