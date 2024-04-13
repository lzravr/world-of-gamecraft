using AutoMapper;
using WorldOfGamecraft.CharacterService.Application.Characters.GetCharacters;
using WorldOfGamecraft.CharacterService.Application.Items.GetItems;
using WorldOfGamecraft.CharacterService.Domain.Characters;
using WorldOfGamecraft.CharacterService.Domain.Items;

namespace WorldOfGamecraft.CharacterService.Application.Mapper;
public class MapperProfile : Profile
{
    public MapperProfile()
    {
        CreateMap<Character, CharacterResponse>();
        CreateMap<Character, CharacterDetailsResponse>();

        CreateMap<Item, ItemResponse>()
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.GetFullItemName()));
    }

}
