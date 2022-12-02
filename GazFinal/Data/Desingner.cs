using MongoDB.Bson.Serialization.Attributes;

namespace GazFinal.Data
{
    public class Desingner : User
    {
        //Застройщик
        [BsonIgnoreIfNull]
        public string? FullName { get; set; }
        [BsonIgnoreIfNull] 
        public string? Department { get; set; }

        [BsonIgnoreIfNull]
        public List<Project> projectsGas = new List<Project>();

        [BsonIgnoreIfNull]
        public List<Project> projectsWater = new List<Project>();
    }
}
