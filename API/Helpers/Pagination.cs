using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Helpers
{
    public class Pagination<T> where T : class
    {

        public Pagination(int pageIndex, int pageSize, int count, IReadOnlyList<T> data)
        {
            this.PageIndex = pageIndex;
            PageSize = pageSize;
            this.Count = count;
            Data = data;

        }
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public int Count { get; set; }
        public IReadOnlyList<T> Data { get; set; }
    }
}