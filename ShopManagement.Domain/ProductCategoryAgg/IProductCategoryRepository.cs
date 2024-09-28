using ShopManagement.Application.Contracts.ProductCategory;
using ShopManagement.Domain.ProductCategoryAgg;

namespace _0_Framework.Domain
{
    public interface IProductCategoryRepository:IRepository<long, ProductCategory>
    {

        EditProductCategory GetDetails(long id);
        List<ProductCategoryViewModel> search(ProductCategorySearchModel searchModel);
    }
}
