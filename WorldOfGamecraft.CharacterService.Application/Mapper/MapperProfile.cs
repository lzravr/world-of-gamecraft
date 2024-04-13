using AutoMapper;
using WorldOfGamecraft.CharacterService.Application.Characters.GetCharacters;
using WorldOfGamecraft.CharacterService.Domain.Characters;

namespace WorldOfGamecraft.CharacterService.Application.Mapper;
public class MapperProfile : Profile
{
    public MapperProfile()
    {
        CreateMap<Character, CharacterResponse>();
        CreateMap<Character, CharacterDetailsResponse>();
    }
}
