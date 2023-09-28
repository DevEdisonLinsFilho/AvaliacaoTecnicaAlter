using System.ComponentModel.DataAnnotations;

namespace AvaliacaoTecnica.DTO.Response
{
    /// <summary>
    /// Classe de retorno de endpoints não GET
    /// </summary>
    public class GenericResponseDTO
    {
        /// <summary>
        /// Verdadeiro ou falso para sucesso do fluxo
        /// </summary>        
        public bool Success { get; set; }

        /// <summary>
        /// Mensagem de erro encontrado no fluxo
        /// </summary>        
        public string ErrorMessage { get; set; }


        public GenericResponseDTO(bool success, string msg)
        {
            this.ErrorMessage = msg;
            this.Success= success;
        }

        public GenericResponseDTO(bool success = true)
        {
            this.Success = success;
        }
    }
}
