using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace Db.Entitites
{
    /// <summary>
    /// Entidade Produto
    /// </summary>
    public class Product
    {

        /// <summary>
        /// Identificador
        /// </summary>
        [Key]
        public int Id { get; set; }

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
        [Required(ErrorMessage = "O código do produto é obrigatório.")]
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
        [Required(ErrorMessage = "O preço do produto é obrigatório.")]
        public decimal Price { get; set; }

        /// <summary>
        /// Marcação de ativo ou inativo do produto.
        /// </summary>
        [Required(ErrorMessage = "Status de ativo ou inativo é obrigatório.")]
        public bool Active { get; set; }

        /// <summary>
        /// Id da Categoria
        /// </summary>
        [Required(ErrorMessage = "O id da categoria é obrigatório.")]
        public int CategoryId { get; set; }

        /// <summary>
        /// Categoria do produto
        /// </summary>        
        public virtual Category Category { get; set; }
    }
}
