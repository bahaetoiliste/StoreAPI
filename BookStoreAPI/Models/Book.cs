﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BookStoreAPI.Models
{
    public class Book
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public String?  ID  { get; set; }
        [BsonElement("Name")]
        public String BookName { get; set; } = null!;

        public Decimal Price { get; set; } 
        public String Category { get; set; } = null!;
        public String Author { get; set; } = null!; 
        public Decimal Rating { get; set; } 
    }
}