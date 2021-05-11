using System;
using System.Collections.Generic;
using System.Text;

namespace Milap.Model.DTO
{
    public class PaginationModelDTO
    {
        public object List { get; set; }
        public string Searchtext { get; set; }
        public string SortField { get; set; }
        public int SortType { get; set; }
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public long TotalPages { get; set; }
        public long TotalRows { get; set; }
    }
}
