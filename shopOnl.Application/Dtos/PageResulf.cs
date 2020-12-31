using System;
using System.Collections.Generic;
using System.Text;

namespace shopOnl.Application.Dtos
{
    public class PageResulf<T>
    {
        public List<T> Items { get; set; }
        public int TotalRecord { get; set; }
    }
}
