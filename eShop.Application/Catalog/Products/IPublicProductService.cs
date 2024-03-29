﻿using eShop.ViewModels.Catalog.Products;
using eShop.ViewModels.Common;

namespace eShop.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        Task<PagedResult<ProductViewModel>> GetAllbyCategoryId(string languageId, GetPublicProductPagingRequest request);
    }
}
