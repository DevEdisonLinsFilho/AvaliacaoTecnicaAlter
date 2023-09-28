using Db.Context;
using Db.Entitites;
using Db.Repositories.Contracts;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.EntityFrameworkCore;

namespace Db.Repositories.Implementations
{
    /// <summary>
    /// Repositório pertinente aos produtos
    /// </summary>
    public class ProductRepository : IProductRepository
    {
        private readonly AvaliacaoTecnicaContext _context;

        public ProductRepository(AvaliacaoTecnicaContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Product>> GetAll(int page, int pageSize)
        {
            return await _context.Products
                .Include(p => p.Category)
                .OrderBy(a => a.Id)
                .Skip((page -1) * pageSize)
                .Take(pageSize)
                .ToListAsync();
        }

        public async Task Insert(Product entity)
        {
            await _context.Products.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Update(int entityId, Product entity)
        {
            var product = await _context.Products.FirstOrDefaultAsync(x => x.Id == entityId);
            
            product.Description = entity.Description;
            product.Dimensions = entity.Dimensions;
            product.Code = entity.Code;
            product.Reference = entity.Reference;
            product.Stockbalance = entity.Stockbalance;
            product.Price = entity.Price;
            product.Active = entity.Active;
            product.CategoryId = entity.CategoryId;

            _context.Products.Update(product);
            await _context.SaveChangesAsync();
        }

        public async Task Patch(int entityId, JsonPatchDocument entity)
        {
            var product = await _context.Products.FindAsync(entityId);
            
            entity.ApplyTo(product);
           
            await _context.SaveChangesAsync();            
        }

        public async Task Delete(int entityId)
        {
            var product = await _context.Products.FirstOrDefaultAsync(x => x.Id == entityId);

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
        }
                
        public async Task<Product> GetById(int entityId)
        {            
            return await _context.Products.FirstOrDefaultAsync(x => x.Id == entityId);            
        }
    }
}
