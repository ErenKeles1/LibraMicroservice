using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Kitap.Catalog.Entities
{
    public class BookImage
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string BookImageId { get; set; }
        public string Image1 { get; set; }
        public string Image2 { get; set; }
        public string Image3 { get; set; }
        public string BookId { get; set; }
        [BsonIgnore]
        public Book Book { get; set; }
    }
}
