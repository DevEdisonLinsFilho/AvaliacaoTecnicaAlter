using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using AvaliacaoTecnica.DTO;
using Service.Contracts;
using AvaliacaoTecnica.DTO.Response;
using AvaliacaoTecnica.DTO.Request;

namespace AvaliacaoTecnica.Controllers
{

    /// <summary>
    /// Classe que expões os endpoints de produtos
    /// </summary>
    [ApiController]
    [Route("[Controller]")]
    public class ProductController : ControllerBase
    {

        private readonly IProductService _productService;        

        public ProductController(IProductService productService)
        {
            _productService = productService;            
        }


        /// <summary>
        /// Retorna lista de produtos
        /// </summary>
        /// <returns>Lista de produtos</returns>
        [ProducesResponseType(typeof(List<ProductResponseDTO>), 200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        [HttpGet]
        public async Task<IActionResult> GetProducts(int page = 1, int pageSize = 5)
        {          
            try
            {
                var products = await _productService.GetAll(page, pageSize);
                if (products == null)
                    throw new Exception("ErrorMessage getting products.");
                return StatusCode(StatusCodes.Status200OK, products);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        /// <summary>
        /// Inclui um produtos
        /// </summary>        
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        [HttpPost]
        public async Task<IActionResult> InsertProduct([FromBody] ProductCreateDTO product)
        {
            try
            {
                var result = await _productService.InsertProduct(product);
                
                if (result.Success)
                    return Ok(result);

                return StatusCode(StatusCodes.Status500InternalServerError, result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        /// <summary>
        /// Altera um produtos
        /// </summary>        
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        [HttpPut("{productId}")]
        public async Task<IActionResult> UpdateProduct([FromRoute] int productId, [FromBody] ProductCreateDTO product)
        {
            try
            {
                var result = await _productService.UpdateProduct(productId, product);

                if (result.Success)
                    return Ok(result);

                return StatusCode(StatusCodes.Status500InternalServerError, result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        /// <summary>
        /// Altera um produtos
        /// </summary>        
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        [HttpPatch("{productId}")]
        public async Task<IActionResult> PatchProduct([FromRoute] int productId, [FromBody] JsonPatchDocument product)
        {
            try
            {
                var result = await _productService.PatchProduct(productId, product);

                if (result.Success)
                    return Ok(result);

                return StatusCode(StatusCodes.Status500InternalServerError, result);                
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        /// <summary>
        /// Deleta um produto
        /// </summary>        
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        [HttpDelete("{productId}")]
        public async Task<IActionResult> DeleteProduct([FromRoute] int productId)
        {
            try
            {
                await _productService.DeleteProduct(productId);

                return StatusCode(StatusCodes.Status200OK);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
