using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace GazFinal.Data
{
    public class DeveloperData
    {
        public DeveloperData(string name, bool required)
        {
            this.Name = name;
            this.Required = required;
        }
        [BsonId]
        [BsonIgnoreIfDefault]
        ObjectId id;
        public string? Name { get; set; }
        public string? Text { get; set; }
        public bool? Required { get; set; }
    }
}
