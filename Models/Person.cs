using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using assignment3MongoDB.Models;


namespace assignment3MongoDB.Models
{
    public class Person
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Name")]
        public string Firstname { get; set; }

        public decimal Lastname { get; set; }

        public int Age { get; set; }

        public string Gender { get; set; }

        public List <Person> blocked { get; set; }

        public List<Circle> Circles{ get; set; }

        public List<Posts> Wall { get; set; }
        public List<Person> BlockedUsers { get; set; }
        public override string ToString()
        {
            return string.Format("Person({0}, {1}, {2}, {3})", Id, Firstname, Lastname, Age);
        }

    }
}
