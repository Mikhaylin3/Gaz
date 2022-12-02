using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace GazFinal.Data
{
    public class ProjectData
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        ObjectId id;
        public string? Name { get; set; }
        public string? Text { get; set; } 
        public bool? Required { get; set; }
    }
}
