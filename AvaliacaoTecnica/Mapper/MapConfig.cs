using Db.Entitites;
using AvaliacaoTecnica.DTO.Response;
using AvaliacaoTecnica.DTO.Request;

namespace AvaliacaoTecnica.Mapper
{
    public class MapConfig : AutoMapper.Profile
    {
        public MapConfig()
        {
            CreateMap<Product, ProductResponseDTO>().ForMember(dest => dest.Category, orig => orig.MapFrom(src => src.Category));
            CreateMap<Category, CategoryDTO>();
            CreateMap<ProductCreateDTO,Product>();
        }
    }
}
