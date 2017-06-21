using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloMongo.Rental
{
    public class Rental
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string RentalId { get; set; }

        public string Descsription {get;set;}
        public int NumberOfRooms {get;set;}
        public string Address {get;set;}

        [BsonRepresentation(BsonType.Double)]
        public decimal Price { get; set; }
    }
}