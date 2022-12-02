﻿using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace GazFinal.Data
{
    public class Project
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        ObjectId _id;

        public string? Name { get; set; }

        public string? Type { get; set; }

        public User? Developer { get; set; }

        public User? Projector { get; set; }

    }
}