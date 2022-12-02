using MongoDB.Driver;

namespace GazFinal.Data
{
    public class Mongich
    {
        public User user1;
        public static void ReplaceByName(User member, string login)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("Gaz");
            var collection = database.GetCollection<User>("User");
            collection.ReplaceOne(x => x.Login == member.Login, member);
        }
        public static List<User> FindAll()
        {

            var client = new MongoClient();
            var database = client.GetDatabase("Gaz");
            var col = database.GetCollection<User>("User");
            var t = col.Find(x => true).ToList();
            List<User> result = new List<User>();
            foreach (var i in t)
            {
                result.Add(i);
            }
            return result;
        }
        public static void ReplaceByNameDoc(Project documents, string login)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("Davletka");
            var collection = database.GetCollection<Project>("Documents");
            collection.ReplaceOne(x => x.Name == login, documents);
        }

        public static void AddToDb(User use)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("Gaz");
            var col = database.GetCollection<User>("User");
            col.InsertOne(use);

        }
        public User GetUser()
        {
            return user1;
        }

        public void SetUser(User user)
        {
            this.user1 = user;
        }
    }
}
