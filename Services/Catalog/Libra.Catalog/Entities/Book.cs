using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Libra.Catalog.Entities
{
    public class Book
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string BookId { get; set; }
        public string BookName { get; set; }
        public decimal BookPrice { get; set; }
        public string AuthorName { get; set; }
        public string Publisher { get; set; }
        public int PageCount { get; set; }
        public int UnitsInStock { get; set; }
        public string BookImageUrl { get; set; }
        public string BookDescription { get; set; }
        public string CategoryId { get; set; }
        [BsonIgnore]
        public Category Category { get; set; }

    }
}
