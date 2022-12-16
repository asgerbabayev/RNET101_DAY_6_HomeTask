namespace RelationTask.Models.Base;

public class NameAuditableEntity : BaseAuditableEntity
{
    public string Name { get; set; } = null!;
}
