﻿using System;
using System.Collections.Generic;
using System.Text;
using assignment3MongoDB.Models;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace assignment3MongoDB.Services
{
    public class PersonService
    {
            private readonly IMongoCollection<Person> _people;

            public PersonService()
            {
                var client = new MongoClient("mongodb://localhost:27017");
                var database = client.GetDatabase("SocialNetworkDb");

                _people = database.GetCollection<Person>("People");

            }
        PersonService psdb = new PersonService();
            public List<Person> Get() =>
                _people.Find(person => true).ToList();

            public Person Get(string id) =>
                _people.Find<Person>(person => person.Id == id).FirstOrDefault();

            public Person Create(Person person)
            {
                _people.InsertOne(person);
                return person;
            }

            public void Update(string id, Person personIn) =>
                _people.ReplaceOne(person => person.Id == id, personIn);

            public void Remove(Person personIn) =>
                _people.DeleteOne(person => person.Id == personIn.Id);

            public void Remove(string id) =>
                _people.DeleteOne(book => book.Id == id);

    }
}
