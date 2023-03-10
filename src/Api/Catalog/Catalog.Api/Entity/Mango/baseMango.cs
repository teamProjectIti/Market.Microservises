using MongoDB.Bson;

namespace Catalog.Api.Entity.Mango
{
    public abstract class baseMango : IbaseMango
    {
        public ObjectId Id { get; set; }

        public DateTime CreatedAt => Id.CreationTime;
    }
}
