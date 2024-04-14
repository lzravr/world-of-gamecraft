using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Moq;
using WorldOfGamecraft.CharacterService.Api.Controllers.Characters;
using WorldOfGamecraft.CharacterService.Application.Characters.GetCharacters;
using WorldOfGamecraft.CharacterService.Infrastructure;

namespace WorldOfGamecraft.Test.Unit;

public class CharacterTests
{

    [Fact]
    public async Task CanGetCharacters()
    {
        // Arrange
        var mockMediator = new Mock<IMediator>();

        var characters = new List<CharacterResponse>
        {
            new CharacterResponse { Name = "Character1", Health = 100, Mana = 50 },
            new CharacterResponse { Name = "Character2", Health = 80, Mana = 60 }
        };

        mockMediator.Setup(m => m.Send(It.IsAny<GetAllCharactersQuery>(), default))
                    .ReturnsAsync(characters);

        var controller = new CharacterController(mockMediator.Object);

        // Act
        var result = await controller.GetAsync(CancellationToken.None);

        // Assert
        var okResult = Assert.IsType<OkObjectResult>(result.Result);
        var returnedCharacters = Assert.IsAssignableFrom<IEnumerable<CharacterResponse>>(okResult.Value);

        Assert.Equal(characters.Count, returnedCharacters.Count());

        var firstCharacter = returnedCharacters.First();
        Assert.Equal("Character1", firstCharacter.Name);
        Assert.Equal(100, firstCharacter.Health);
        Assert.Equal(50, firstCharacter.Mana);

        // Add more assertions for the second character if needed
    }
}