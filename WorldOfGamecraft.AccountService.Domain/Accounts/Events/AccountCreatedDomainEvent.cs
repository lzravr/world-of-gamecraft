using WorldOfGamecraft.AccountService.Domain.Abstractions;

namespace WorldOfGamecraft.AccountService.Domain.Accounts.Events;
public record AccountCreatedDomainEvent(Guid AccountId) : IDomainEvent;