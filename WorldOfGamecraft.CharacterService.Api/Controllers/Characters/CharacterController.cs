using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using WorldOfGamecraft.CharacterService.Application.Characters.AddCharacters;
using WorldOfGamecraft.CharacterService.Application.Characters.GetCharacters;
using WorldOfGamecraft.CharacterService.Domain.Characters;
using WorldOfGamecraft.Common;

namespace WorldOfGamecraft.CharacterService.Api.Controllers.Characters;

[Authorize]
[Route("api/character")]
[ApiController]
public class CharacterController : ControllerBase
{
    private readonly ISender _sender;

    public CharacterController(ISender sender)
    {
        _sender = sender;
    }

    [HttpGet]
    [Authorize(Roles = "GameMaster" )]
    public async Task<ActionResult<List<CharacterResponse>>> GetAsync(CancellationToken cancellationToken)
    {
        var query = new GetAllCharactersQuery();

        var result = await _sender.Send(query, cancellationToken);

        return Ok(result);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Character>> GetByIdAsync(Guid id, CancellationToken cancellation)
    {
        var claimsIdentity = User.Identity as ClaimsIdentity;

        if (claimsIdentity == null)
        {
            return BadRequest("Invalid token");
        }

        var usernameClaim = claimsIdentity.FindFirst(ClaimTypes.Name)?.Value;

        var query = new GetCharacterByIdQuery(id, usernameClaim);

        var result = await _sender.Send(query, cancellation);

        return Ok(result);
    }

    [HttpPost]
    public async Task<ActionResult<Guid>> Create(CreateCharacterRequest request, CancellationToken cancellationToken)
    {
        var claimsIdentity = User.Identity as ClaimsIdentity;

        if (claimsIdentity == null)
        {
            return BadRequest("Invalid token");
        }

        var usernameClaim = claimsIdentity.FindFirst(ClaimTypes.Name)?.Value;

        var command = new CreateCharacterCommand(request.Name, request.Health, request.Mana, request.ClassName, request.Strength, request.Agility, request.Inteligence, request.Faith, usernameClaim);

        var result = await _sender.Send(command, cancellationToken);

        return Ok(result);
    }
}
