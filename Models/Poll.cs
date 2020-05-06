using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace assignment3MongoDB.Models
{
    public class Poll
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Name")]
        public string author { get; set; }
        public List<PollOption> UserPoll;
        public int OptionAmount;
    }

    public class PollOption
    {
        public int Number;
        public string Option;
        public int Votes;
        public override string ToString()
        {
            return string.Format("poll option {0}, votes: {1}\n", Option, Votes);
        }
    }
}
