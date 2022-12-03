using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace GazFinal.Data
{
    public class Project
    {
        public Project(string name, string type, User desingner, User projector)
        {
            Name = name;
            Type = type;
            Desingner = desingner;
            Projector = projector;
        }
        [BsonId]
        [BsonIgnoreIfDefault]
        ObjectId _id;
        [BsonIgnoreIfNull]
        public string? Name { get; set; }
        [BsonIgnoreIfNull]
        public string? Type { get; set; }
        [BsonIgnoreIfNull]
        public User? Desingner { get; set; }
        [BsonIgnoreIfNull]
        public User? Projector { get; set; }

        [BsonIgnoreIfNull]
        public List<DeveloperData> DevDoc = new List<DeveloperData>();
        public List<ProjectData>ProjDoc = new List<ProjectData>();
    }
}
