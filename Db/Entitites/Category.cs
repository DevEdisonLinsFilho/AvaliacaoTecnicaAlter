using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Db.Entitites
{
    /// <summary>
    /// Entidade Categoria
    /// </summary>
    public class Category
    {
        
        /// <summary>
        /// Identificador
        /// </summary>
        [ForeignKey("Product")]
        public int Id { get; set; }

        /// <summary>
        /// Descrição da categoria
        /// </summary>
        [Required(ErrorMessage = "A descrição da categoria é obrigatória")]
        public string Description { get; set; }
      
        /// <summary>
        /// Marcação de ativo ou inativo da categoria.
        /// </summary>
        public bool Active { get; set; }

        /// <summary>
        /// produto
        /// </summary>
        public virtual ICollection<Product> Products { get; set; }

    }
}
