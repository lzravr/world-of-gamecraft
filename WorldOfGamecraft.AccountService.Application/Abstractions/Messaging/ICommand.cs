using MediatR;

namespace WorldOfGamecraft.AccountService.Application.Abstractions.Messaging;
public interface ICommand : IRequest, IBaseCommand
{
}

public interface IBaseCommand
{

}
