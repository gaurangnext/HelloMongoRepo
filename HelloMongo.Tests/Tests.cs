using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MongoDB.Bson;
using MongoDB.Bson.IO;

namespace HelloMongo.Tests
{
    [TestClass]
    public class Tests
    {
        public Tests()
        {
            JsonWriterSettings.Defaults.Indent = true;
        }
        [TestMethod]
        public void AddElements()
        {
            var person = new BsonDocument();
            person.Add("FirstName", "Gaurang");             
            person.Add("LastName", new BsonString("Shah"));
            Console.WriteLine(person.ToJson());
        }

        [TestMethod]
        public void EmptyDocument()
        {
            var document = new BsonDocument();
            Console.WriteLine("Here it is: \n"+document);
        }

        [TestMethod]
        public void AddPoco()
        {

            var contact = new Contact()
            {
                Email = "Gaurang.shah@gmail.com",
                Phone = "954 444 4444"
            };
            var person = new Person() {
                FirstName = "Gaurang",
                LastName = "Shah",
                Bod = new DateTime(1978, 5, 2),
                Contact = contact
            };

            Console.WriteLine(person.ToJson());

            var p = person.ToBsonDocument();
            Console.WriteLine(p);
            

        }
    }
}
