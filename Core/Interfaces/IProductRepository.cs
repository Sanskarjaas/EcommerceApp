using Core.Entities;

namespace Core.Intefaces
{
    public interface IProductRepository
    {
        Task<Product> GetProductById(int id);
        Task<IReadOnlyList<Product>> GetProducts();
        Task<IReadOnlyList<ProductBrand>> GetProductBrands();
        Task<IReadOnlyList<ProductType>> GetProductTypes();
    }
}