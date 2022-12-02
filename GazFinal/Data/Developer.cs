using MongoDB.Bson.Serialization.Attributes;

namespace GazFinal.Data
{
    public class Developer : User
    {
        //Заказчик
        [BsonIgnoreIfNull]
        public string? INN { get; set; }
        [BsonIgnoreIfNull]
        public string? KPP { get; set; }
        [BsonIgnoreIfNull]
        public string? OGNR { get; set; }
        public string? Address { get; set; }
        [BsonIgnoreIfNull]
        public List<Project> projects = new List<Project>();
    }
}
