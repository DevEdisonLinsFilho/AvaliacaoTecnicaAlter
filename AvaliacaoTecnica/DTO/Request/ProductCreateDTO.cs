using System.ComponentModel.DataAnnotations;

namespace AvaliacaoTecnica.DTO.Request
{
    /// <summary>
    /// DTO de criação e atualização de produto
    /// </summary>
    public class ProductCreateDTO
    {

        /// <summary>
        /// Descrição do produto
        /// </summary>
        [Required(ErrorMessage = "A descrição do produto é obrigatória")]
        public string Description { get; set; }

        /// <summary>
        /// Dimensão do produto
        /// </summary>        
        public string? Dimensions { get; set; }

        /// <summary>
        /// Código do produto
        /// </summary>     
        public long Code { get; set; }

        /// <summary>
        /// Referência do produto
        /// </summary>
        public long? Reference { get; set; }

        /// <summary>
        /// Saldo de estoque do produto
        /// </summary>        
        public long? Stockbalance { get; set; }

        /// <summary>
        /// Preço do produto
        /// </summary>       
        public decimal Price { get; set; }

        /// <summary>
        /// Marcação de ativo ou inativo do produto.
        /// </summary>
        public bool Active { get; set; }

        /// <summary>
        /// Id da Categoria
        /// </summary>
        public int CategoryId { get; set; }
    }
}