namespace RelationTask.Models.Base;

public class BaseEntity : BaseEntity<int>
{

}

public class BaseEntity<TKey> where TKey : IEquatable<TKey>
{
    public TKey Id { get; set; } = default!;
}
