﻿using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace assignment3MongoDB.Models
{
    public class Posts
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Name")]
        public string author { get; set; }

        public string content { get; set; }

        public DateTime created { get; set; } //understøtter mongoDB datetime?

        public string CircleID { get; set; }
}
}
