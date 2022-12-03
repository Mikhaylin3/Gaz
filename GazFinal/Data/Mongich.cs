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
            var result = new List<User>();
            foreach (var i in t)
            {
                result.Add(i);
            }
            return result;
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
        public static User Find(string login)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("Gaz");
            var collection = database.GetCollection<User>("User");
            var list = collection.Find(x => x.Login == login).FirstOrDefault();
            return list;
        }
        public static List<User> FindAllProjector()
        {
            var client = new MongoClient();
            var database = client.GetDatabase("Gaz");
            var collection = database.GetCollection<User>("User");
            var list = collection.Find(x => true).ToList();
            var users = new List<User>();
            foreach (var user in list)
            {
                if (user.GetType().Name == "Projector")
                    users.Add(user);
            }
            return users;
        }
        public static void Replace(string login, User user)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("Gaz");
            var collection = database.GetCollection<User>("User");
            collection.ReplaceOne(z => z.Login == login, user);
        }
        public static List<User> FindAllDeveloper()
        {
            var client = new MongoClient();
            var database = client.GetDatabase("Gaz");
            var collection = database.GetCollection<User>("User");
            var list = collection.Find(x => true).ToList();
            var users = new List<User>();
            foreach (var user in list)
            {
                if (user.GetType().Name == "Developer")
                    users.Add(user);
            }
            return users;
        }



        //Project
        public Project project1;
        public Project GetProjectr()
        {
            return project1;
        }

        public void SetProject(Project project)
        {
            this.project1 = project;
        }
        public static void AddProjectToDB(Project project)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("Gaz");
            var collection = database.GetCollection<Project>("Project");
            collection.InsertOne(project);
        }
        public static Project FindProject(string name)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("Gaz");
            var collection = database.GetCollection<Project>("Project");
            var list = collection.Find(x => x.Name == name).FirstOrDefault();
            return list;
        }
        public static void ReplaceByNameDoc(Project documents, string login)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("Gaz");
            var collection = database.GetCollection<Project>("Project");
            collection.ReplaceOne(x => x.Name == login, documents);
        }

    }
}
