using shopOnl.Application.Catalog.Products.Dtos;
using shopOnl.Application.Catalog.Products.Dtos.Public;
using shopOnl.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace shopOnl.Application.Catalog.Products
{
    public interface IPublicProductService
    {
       Task<PageResulf<ProductViewModel>> GetAllByCategoryId(GetProductPagingRequest request);
    }
}
