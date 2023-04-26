namespace Ordering.Doman.Common.EntityBase
{
    public abstract class BaseEntity
    {
        public long Id { get; protected set; }
        public string CreatedBy { get; set; }=string.Empty;
        public DateTime CreatedDate { get; set; }
        public string LastModifiedBy { get; set; } = string.Empty;
        public DateTime? LastModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
