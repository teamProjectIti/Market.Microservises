using MongoDB.Bson;

namespace Catalogs.Entity.Mango
{
    public abstract class baseMango : IbaseMango
    {
        public ObjectId Id { get; set; }

        public DateTime CreatedAt => Id.CreationTime;
    }
}
