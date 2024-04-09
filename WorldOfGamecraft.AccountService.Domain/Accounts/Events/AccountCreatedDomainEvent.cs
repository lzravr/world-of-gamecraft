using WorldOfGamecraft.Common.Abstractions;

namespace WorldOfGamecraft.AccountService.Domain.Accounts.Events;
public record AccountCreatedDomainEvent(Guid AccountId) : IDomainEvent;