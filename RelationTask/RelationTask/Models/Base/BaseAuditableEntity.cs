namespace RelationTask.Models.Base;
public class BaseAuditableEntity : BaseEntity
{
    public string CreatedBy { get; set; } = null!;
    public DateTime CreatedDate { get; set; } = default!; 
    public string? ModifiedBy { get; set; }
    public DateTime? ModifiedDate { get; set; } 
}
