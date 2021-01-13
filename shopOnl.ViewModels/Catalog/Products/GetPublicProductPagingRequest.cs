﻿using shopOnl.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace shopOnl.ViewModels.Catalog.Products
{
    public class GetPublicProductPagingRequest : PagingRequestBase
    {
        public string LanguageId { get; set; }
        public int? CategoryId { get; set; }
    }
}
