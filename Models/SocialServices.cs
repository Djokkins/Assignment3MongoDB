using System;
using System.Collections.Generic;
using System.Text;

namespace assignment3MongoDB.Models
{
    class SocialServices
    {
        private readonly IMongoCollection<Person> _people;

        public SocialServices()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("BookstoreDb");

            _books = database.GetCollection<Book>("Books");
        }

        public List<Book> Get() =>
            _books.Find(book => true).ToList();

        public Book Get(string id) =>
            _books.Find<Book>(book => book.Id == id).FirstOrDefault();

        public Book Create(Book book)
        {
            _books.InsertOne(book);
            return book;
        }

        public void Update(string id, Book bookIn) =>
            _books.ReplaceOne(book => book.Id == id, bookIn);

        public void Remove(Book bookIn) =>
            _books.DeleteOne(book => book.Id == bookIn.Id);

        public void Remove(string id) =>
            _books.DeleteOne(book => book.Id == id);
    }
}
