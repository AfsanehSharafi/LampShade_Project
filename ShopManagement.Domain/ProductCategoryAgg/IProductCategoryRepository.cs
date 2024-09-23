using ShopManagement.Domain.ProductCategoryAgg;

namespace _0_Framework.Domain
{
    public interface IProductCategoryRepository
    {
        void Create(ProductCategory entity);

        ProductCategory Get(long id);
        List<ProductCategory> GetAll();
    }
}
