using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloMongo.Rental;
using MongoDB.Bson;
using MongoDB.Bson.IO;

namespace HelloMongo.Tests
{
    [TestClass]
    public class RentalTests
    {
        public RentalTests()
        {
            JsonWriterSettings.Defaults.Indent = true;
        }

        [TestMethod]
        public void Test1()
        {
            var rental = new Rental.Rental();
            rental.RentalId = ObjectId.GenerateNewId().ToString();
            rental.Price = 1;


            var doc = rental.ToBsonDocument();

            Console.WriteLine(doc.ToJson());
            Assert.IsTrue(doc["Price"].BsonType.Equals(BsonType.Double));
            Assert.IsTrue(doc["_id"].BsonType.Equals(BsonType.ObjectId));

        }

        [TestMethod]
        public void TestInsertDocument()
        {
            var rental = new Rental.Rental();
            rental.RentalId = ObjectId.GenerateNewId().ToString();
            rental.Price = 1;


            var doc = rental.ToBsonDocument();

            Console.WriteLine(doc.ToJson());
            Assert.IsTrue(doc["Price"].BsonType.Equals(BsonType.Double));
            Assert.IsTrue(doc["_id"].BsonType.Equals(BsonType.ObjectId));

        }
    }
}
