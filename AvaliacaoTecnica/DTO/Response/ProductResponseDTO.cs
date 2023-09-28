using Db.Entitites;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace AvaliacaoTecnica.DTO.Response
{
    /// <summary>
    /// classe exposta de produto
    /// </summary>
    public class ProductResponseDTO
    {

        /// <summary>
        /// Identificador
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Descrição do produto
        /// </summary>
        [Required(ErrorMessage = "A descrição do produto é obrigatória")]
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Dimensão do produto
        /// </summary>
        [JsonProperty("dimensions")]
        public string? Dimensions { get; set; }

        /// <summary>
        /// Código do produto
        /// </summary>
        [Required(ErrorMessage = "O código do produto é obrigatório.")]
        [JsonProperty("code")]
        public long Code { get; set; }

        /// <summary>
        /// Referência do produto
        /// </summary>
        [JsonProperty("reference")]
        public long? Reference { get; set; }

        /// <summary>
        /// Saldo de estoque do produto
        /// </summary>
        [JsonProperty("stockbalance")]
        public long? Stockbalance { get; set; }

        /// <summary>
        /// Preço do produto
        /// </summary>
        [Required(ErrorMessage = "O preço do produto é obrigatório.")]
        [JsonProperty("price")]
        public decimal Price { get; set; }

        /// <summary>
        /// Marcação de ativo ou inativo do produto.
        /// </summary>
        [Required(ErrorMessage = "Status de ativo ou inativo é obrigatório.")]
        [JsonProperty("active")]
        public bool Active { get; set; }

        /// <summary>
        /// Id da Categoria
        /// </summary>
        [Required(ErrorMessage = "O id da categoria é obrigatório.")]
        [JsonProperty("categoryId")]
        public int CategoryId { get; set; }

        /// <summary>
        /// Categoria do produto
        /// </summary>
        [JsonProperty("category")]
        public CategoryDTO Category { get; set; }
    }
}