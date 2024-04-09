namespace WorldOfGamecraft.Common.Abstractions;
public abstract class Entity : IEntity
{
    private readonly List<IDomainEvent> _domainEvents = new();

    public Guid Id { get; init; } = Guid.NewGuid();

    protected Entity(Guid id)
    {
        Id = id;
    }

    protected Entity() { }

    public void ClearDomainEvents()
    {
        _domainEvents.Clear();
    }

    public IReadOnlyList<IDomainEvent> GetDomainEvents()
    {
        return _domainEvents.ToList();
    }
    public void RaiseDomainEvent(IDomainEvent domainEvent)
    {
        _domainEvents.Add(domainEvent);
    }
}
