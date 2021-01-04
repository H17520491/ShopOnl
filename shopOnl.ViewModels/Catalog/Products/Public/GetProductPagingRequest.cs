using shopOnl.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace shopOnl.ViewModels.Catalog.Products.Public
{
    public class GetProductPagingRequest : PagingRequestBase
    {
        public int? CategoryId { get; set; }
    }
}
