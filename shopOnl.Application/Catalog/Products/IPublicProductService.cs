using shopOnl.Application.Catalog.Products.Dtos;
using shopOnl.Application.Catalog.Products.Dtos.Public;
using shopOnl.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace shopOnl.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        PageResulf<ProductViewModel> GetAllByCategoryId(GetProductPagingRequest request);
    }
}
