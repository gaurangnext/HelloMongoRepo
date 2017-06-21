using MongoDB.Bson.Serialization.Attributes;
using System;

namespace HelloMongo.Tests
{
    internal class Person
    {
        public Person()
        {
        }

        [BsonId]
        public int PersonId { get; set; }

        [BsonDateTimeOptions(DateOnly =true)]
        public DateTime Bod { get; set; }

        public Contact Contact { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}