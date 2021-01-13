using shopOnl.ViewModels.Catalog.Products;
using shopOnl.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace shopOnl.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        Task<PageResulf<ProductViewModel>> GetAllByCategoryId(GetPublicProductPagingRequest request);

        Task<List<ProductViewModel>> GetAll(string languageId);

    }
}
