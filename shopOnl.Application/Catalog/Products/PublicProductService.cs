﻿using shopOnl.Application.Catalog.Products.Dtos;
using shopOnl.Application.Catalog.Products.Dtos.Public;
using shopOnl.Application.Dtos;
using shopOnl.Data.EF;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace shopOnl.Application.Catalog.Products
{
    public class PublicProductService : IPublicProductService
    {
        private readonly shopOnlDBcontext _context;
        public PublicProductService(shopOnlDBcontext context)
        {
            _context = context;
        }
        public async Task<PageResulf<ProductViewModel>> GetAllByCategoryId(GetProductPagingRequest request)
        {
            var query = from p in _context.Products
                        join pt in _context.ProductTranslations on p.Id equals pt.ProductId
                        join pic in _context.ProductInCategories on p.Id equals pic.ProductId
                        join c in _context.Categories on pic.CategoryId equals c.Id
                        select new { p, pt, pic };
            //filler

            if (request.CategoryId.HasValue && request.CategoryId.Value > 0)
            {
                query = query.Where(p => p.pic.CategoryId == request.CategoryId);
            }
            //paging
            int totalRow = await query.CountAsync();
            var data = await query.Skip((request.PageIndex - 1) * (request.PageSize))
                .Take(request.PageSize)
                .Select(x => new ProductViewModel()
                {
                    Id = x.p.Id,
                    Name = x.pt.Name,
                    DateCreated = x.p.DateCreated,
                    Description = x.pt.Description,
                    Details = x.pt.Details,
                    LanguageId = x.pt.LanguageId,
                    OriginalPrice = x.p.OriginalPrice,
                    Price = x.p.Price,
                    SeoAlias = x.pt.SeoAlias,
                    SeoTitle = x.pt.SeoTitle,
                    SeoDescription = x.pt.SeoDescription,
                    Stock = x.p.Stock,
                    ViewCount = x.p.ViewCount,
                }).ToListAsync();

            //Select and projection
            var pagedResulf = new PageResulf<ProductViewModel>()
            {
                TotalRecord = totalRow,
                Items = data
            };
            return pagedResulf;
        }
    }
}
