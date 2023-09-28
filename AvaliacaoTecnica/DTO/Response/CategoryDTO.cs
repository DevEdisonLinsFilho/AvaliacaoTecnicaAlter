using System.ComponentModel.DataAnnotations;

namespace AvaliacaoTecnica.DTO.Response
{
    /// <summary>
    /// classe exposta de produto
    /// </summary>
    public class CategoryDTO
    {
        /// <summary>
        /// Identificador
        /// </summary>        
        public int Id { get; set; }

        /// <summary>
        /// Descrição do produto
        /// </summary>        
        public string Description { get; set; }

        /// <summary>
        /// Marcação de ativo ou inativo do produto.
        /// </summary>
        public bool Active { get; set; }

    }
}
