using System;
using System.Collections.Generic;
using System.Text;
using assignment3MongoDB.Models;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace assignment3MongoDB.Services
{
    public class CircleService
    {
        private readonly IMongoCollection<Circle> _circles;

        public CircleService()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("SocialNetworkDb");

            _circles = database.GetCollection<Circle>("Circles");

        }

        public List<Circle> Get() =>
            _circles.Find(Circle => true).ToList();

        public Circle Get(string id) =>
            _circles.Find<Circle>(Circle => Circle.Id == id).FirstOrDefault();

        public Circle Create(Circle circle)
        {
            _circles.InsertOne(circle);
            return circle;
        }

        public void Update(string id, Circle circleIn) =>
            _circles.ReplaceOne(circle => circle.Id == id, circleIn);

        public void Remove(Circle circleIn) =>
            _circles.DeleteOne(circle => circle.Id == circleIn.Id);

        public void Remove(string id) =>
            _circles.DeleteOne(circle => circle.Id == id);

    }
}

