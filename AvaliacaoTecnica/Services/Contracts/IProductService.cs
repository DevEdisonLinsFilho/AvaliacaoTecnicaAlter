using AvaliacaoTecnica.DTO.Request;
using AvaliacaoTecnica.DTO.Response;
using Microsoft.AspNetCore.JsonPatch;

namespace Service.Contracts
{
    public interface IProductService
    {
        public Task<IEnumerable<ProductResponseDTO>> GetAll(int page, int pageSize);
        public Task<GenericResponseDTO> InsertProduct(ProductCreateDTO product);
        public Task<GenericResponseDTO> UpdateProduct(int productId, ProductCreateDTO product);
        public Task<GenericResponseDTO> PatchProduct(int productId, JsonPatchDocument product);
        public Task<GenericResponseDTO> DeleteProduct(int productId);
    }
}
