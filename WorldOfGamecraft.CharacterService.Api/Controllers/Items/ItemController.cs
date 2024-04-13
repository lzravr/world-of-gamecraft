using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WorldOfGamecraft.CharacterService.Application.Items;
using WorldOfGamecraft.CharacterService.Application.Items.AddItems;
using WorldOfGamecraft.CharacterService.Application.Items.GetItems;

namespace WorldOfGamecraft.CharacterService.Api.Controllers.Items;

[Authorize]
[Route("api/item")]
[ApiController]
public class ItemController : ControllerBase
{
    private readonly ISender _sender;

    public ItemController(ISender sender)
    {
        _sender = sender;
    }

    [HttpGet]
    [Authorize(Roles = "GameMaster")]
    public async Task<ActionResult<List<ItemResponse>>> GetAsync(CancellationToken cancellationToken)
    {
        var query = new GetAllItemsQuery();

        var result = await _sender.Send(query, cancellationToken);

        return Ok(result);
    }

    [HttpGet]
    [Route("{id}")]
    public async Task<ActionResult<ItemResponse>> GetByIdAsync(Guid Id, CancellationToken cancellationToken)
    {
        var query = new GetItemByIdQuery(Id);

        var result = await _sender.Send(query, cancellationToken);

        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> CreateAsync(CreateItemRequest request, CancellationToken cancellationToken)
    {
        var command = new AddItemCommand(request.Name, request.Description, request.BonusStrength, request.BonusAgility, request.BonusInteligence, request.BonusFaith);

        var result = await _sender.Send(command, cancellationToken);

        return CreatedAtRoute(nameof(GetByIdAsync), new { id = result }, result);
    }
}
