using MongoDB.Bson.Serialization.Attributes;

namespace GazFinal.Data
{
    public class Projector : User
    {
        //Проектировщик
        [BsonIgnoreIfNull]
        public string? NameOrg { get; set; }
        [BsonIgnoreIfNull]
        public string? INN { get; set; }
        [BsonIgnoreIfNull]
        public string? KPP { get; set; }
        [BsonIgnoreIfNull]
        public string? OGNR { get; set; }
        [BsonIgnoreIfNull]
        public string? nameDirector { get; set; }
        [BsonIgnoreIfNull]
        public string? Engineer { get; set; }
        [BsonIgnoreIfNull]
        public  List<Project> projects = new List<Project>(); 
    }
}
