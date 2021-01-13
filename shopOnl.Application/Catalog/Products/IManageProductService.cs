using Microsoft.AspNetCore.Http;
using shopOnl.ViewModels.Catalog.Products;
using shopOnl.ViewModels.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace shopOnl.Application.Catalog.Products
{
    public interface IManageProductService
    {
        Task<int> Create(ProductCreateRequest request);

        Task<int> Update(ProductUpdateRequest request);

        Task<int> Delete(int productId);

        Task<ProductViewModel> GetById(int productId, string languageId);

        Task<bool> UpdatePrice(int productId, decimal newPrice);
        Task<bool> UpdateStock(int productId, int addedQuantity);

        Task AddViewcount(int productId);
        
        Task<PageResulf<ProductViewModel>> GetAllPaging(GetManageProductPagingRequest request);

        Task<int> AddImages(int productId, List<IFormFile> files);
        Task<int> RemoveImages(int imageId);
        Task<int> UpdateImage(int imageId, string Caption, bool isDefault);

        Task<List<ProductImageViewModel>> GetListImage(int productId);
        
    }
}
