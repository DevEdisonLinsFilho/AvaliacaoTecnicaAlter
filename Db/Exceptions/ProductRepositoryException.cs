namespace Db.Exceptions
{
    public class ProductRepositoryException : Exception
    {
        public ProductRepositoryException(string msg)
            : base("ProductRepositoryException: " + msg) { }
    }
}
