namespace AvaliacaoTecnica.Exceptions
{
    public class ProductServiceException : Exception
    {
        public ProductServiceException(string msg)
            : base("ProductServiceException: " + msg) { }
    }
}
