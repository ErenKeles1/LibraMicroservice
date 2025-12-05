using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Libra.Catalog.Entities
{
    public class BookDetail
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string BookDetailId { get; set; }
        public string BookDescription { get; set; }
        public string BookInfo { get; set; }
        public string BookId { get; set; }
        [BsonIgnore]
        public Book Book { get; set; }
    }
}
