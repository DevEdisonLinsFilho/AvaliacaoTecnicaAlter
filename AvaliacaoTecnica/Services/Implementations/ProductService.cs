using AutoMapper;
using AvaliacaoTecnica.DTO.Request;
using AvaliacaoTecnica.DTO.Response;
using AvaliacaoTecnica.Exceptions;
using Db.Entitites;
using Db.Repositories.Contracts;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.IdentityModel.Tokens;
using Service.Contracts;

namespace Service.Implementations
{
    /// <summary>
    /// Service pertinente aos produtos
    /// </summary>
    public class ProductService : IProductService
    {
        private readonly IMapper _mapper;
        private readonly IProductRepository _repository;

        public ProductService(IMapper mapper, IProductRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }
        
        public async Task<IEnumerable<ProductResponseDTO>> GetAll(int page, int pageSize)
        {
            try
            {
               var produtosEntities = await _repository.GetAll(page, pageSize);
               return _mapper.Map<IEnumerable<ProductResponseDTO>>(produtosEntities);
            }
            catch (ProductServiceException ex)
            {
                throw ex;
            }
        }

        public async Task<GenericResponseDTO> InsertProduct(ProductCreateDTO product)
        {
            try
            {
                var validation = ValidateProductCreateDTO(product);
                if (!validation.Success)
                    return validation;

                var entity = _mapper.Map<Product>(product);
                await _repository.Insert(entity);
                return new GenericResponseDTO(true);
            }
            catch (ProductServiceException ex)
            {
                throw ex;
            }

        }


        public async Task<GenericResponseDTO> UpdateProduct(int productId, ProductCreateDTO product)
        {
            try
            {
                var validation = ValidateProductCreateDTO(product);
                if (!validation.Success)
                    return validation;

                var entity = _mapper.Map<Product>(product);
                await _repository.Update(productId, entity);
                return new GenericResponseDTO(true);

            }
            catch (ProductServiceException ex)
            {
                throw ex;
            }
        }

        public async Task<GenericResponseDTO> PatchProduct(int productId, JsonPatchDocument product)
        {
            try
            {
                var validation = await ValidateJsonPatchDocument(productId, product);
                
                if (!validation.Success)
                    return validation;

                await _repository.Patch(productId, product);
                return new GenericResponseDTO(true);
            }
            catch (ProductServiceException ex)
            {
                throw ex;
            }

        }

        public async Task<GenericResponseDTO> DeleteProduct(int productId)
        {
            try
            {
                var validation = await ValidateDelete(productId);

                if (!validation.Success)
                    return validation;

                await _repository.Delete(productId);
                return new GenericResponseDTO(true);
            }
            catch (ProductServiceException ex)
            {
                throw ex;
            }

        }        

        private GenericResponseDTO ValidateProductCreateDTO(ProductCreateDTO product)
        {            
            if (string.IsNullOrEmpty(product.Description))
                return new GenericResponseDTO(false, "A descrição deve ser informada obrigatórioamente");

            if (product.Code <= 0)
                return new GenericResponseDTO(false, "O código deve ser informada obrigatórioamente");

            if (product.Price <= 0)
                return new GenericResponseDTO(false, "O preço deve ser informada obrigatórioamente");

            if (product.CategoryId <= 0)
                return new GenericResponseDTO(false, "A categoria deve ser informada obrigatórioamente");

            return new GenericResponseDTO();
        }

        private async Task<GenericResponseDTO> ValidateJsonPatchDocument(int productId, JsonPatchDocument patchJson)
        {
            if (productId <= 0)
                return new GenericResponseDTO(false, "O Id deve ser informado.");

            var product = await _repository.GetById(productId);
            if (product is null)
                return new GenericResponseDTO(false, "O Id informado não foi encontrado.");

            if (patchJson.Operations.IsNullOrEmpty())
                return new GenericResponseDTO(false, "A operação deve ser informada");              

            return new GenericResponseDTO();
        }

        private async Task<GenericResponseDTO> ValidateDelete(int productId)
        {
            if (productId <= 0)
                return new GenericResponseDTO(false, "O Id deve ser informado.");

            var product = await _repository.GetById(productId);
            if (product is null)
                return new GenericResponseDTO(false, "O Id informado não foi encontrado.");

            return new GenericResponseDTO();
        }

    }
}
