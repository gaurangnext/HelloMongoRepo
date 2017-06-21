using HelloMongo.Properties;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloMongo
{
    public class MongoDBContext
    {
        public MongoDatabase Database;

        public MongoDBContext()
        {
            //var client = new MongoClient(Settings.Default.HelloMongoConnectionString);
            
            
            var connectionString = @"mongodb://rentalAdminUser:rentalAdminUser@localhost:27017/HelloMongoDB";
            var mongoUrl = new MongoUrl(connectionString);
            var dbname = mongoUrl.DatabaseName;
            var client = new MongoClient(mongoUrl);

            var server = client.GetServer();
            Database = server.GetDatabase(Settings.Default.HelloMongoDatabaseName);
        }

        public MongoCollection<Rental.Rental> Rentals
        {
            get
            {
                return Database.GetCollection<Rental.Rental>("rentals");
            }
        }
        
    }
}