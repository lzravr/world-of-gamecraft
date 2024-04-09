namespace WorldOfGamecraft.Common.Abstractions;
public interface IEntity
{
    void ClearDomainEvents();
    IReadOnlyList<IDomainEvent> GetDomainEvents();
}
