using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Catalogs.Entity.Mango
{
    public interface IbaseMango
    {
        [BsonId]
        [BsonRepresentation(BsonType.String)]
        ObjectId Id { get; set; }

        DateTime CreatedAt { get; }
    }
}
