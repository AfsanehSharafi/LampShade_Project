﻿using _0_Framework.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.Application.Contracts.ProductCategory
{
    public interface IProductCategoryApplication
    {
        OperationResult Create(CreateProductCategory command);
        OperationResult Edit(EditProductCategory command);
        EditProductCategory GetDetails(long id);
        List<ProductCategoryViewModel> GetProductCategories();
        List<ProductCategoryViewModel> Search(ProductCategorySearchModel searchModel);

    }
}
