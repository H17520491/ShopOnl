using shopOnl.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace shopOnl.Application.Catalog.Products.Dtos.Public
{
    public class GetProductPagingRequest : PagingRequestBase
    {
        public int CategoryId { get; set; }
    }
}
