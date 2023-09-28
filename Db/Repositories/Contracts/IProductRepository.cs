using Db.Entitites;
using Microsoft.AspNetCore.JsonPatch;

namespace Db.Repositories.Contracts
{
    public interface IProductRepository
    {
        /// <summary>
        /// Recupera todos os produtos
        /// </summary>
        /// <returns>Lista de produtos</returns>
        public Task<IEnumerable<Product>> GetAll(int page, int pageSize);

        /// <summary>
        /// Registra um produto
        /// </summary>
        /// <param name="entity">Entidade de produto</param>        
        public Task Insert(Product entity);

        /// <summary>
        /// Atualiza um produto
        /// </summary>
        /// <param name="entity">Entidade de produto</param>        
        /// <param name="entityId">ID da entidade de produto</param>        
        public Task Update(int entityId, Product entity);

        /// <summary>
        /// Atualiza campos específicos de um produto
        /// </summary>
        /// <param name="entity">Entidade de produto</param>        
        public Task Patch(int entityId, JsonPatchDocument jsonPatchDocument);

        /// <summary>
        /// Deleta um produto
        /// </summary>
        /// <param name="entityId">Id da entidade a ser excluida</param>        
        public Task Delete(int entityId);

        /// <summary>
        /// Deleta um produto
        /// </summary>
        /// <param name="entityId">Id da entidade a ser excluida</param>        
        public Task<Product> GetById(int entityId);
    }
}
