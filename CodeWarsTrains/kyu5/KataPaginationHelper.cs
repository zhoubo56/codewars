using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu5
{
    /// <summary>
    /// PaginationHelper
    /// https://www.codewars.com/kata/515bb423de843ea99400000a
    /// </summary>
    public class KataPaginationHelper<T>
    {
        public KataPaginationHelper(IList<T> collection, int itemsPerPage)
        {
            this.Source = collection;
            this.PageSize = itemsPerPage;
        }

        public IList<T> Source { get; set; }

        public int PageSize { get; set; }

        public int PageCount
        {
            get
            {
                return this.ItemCount / this.PageSize + 1;
            }
        }

        public int ItemCount
        {
            get
            {
                return this.Source.Count;
            }
        }

        public int PageItemCount(int pageIndex)
        {
            if (pageIndex < 0 || this.PageSize * pageIndex > ItemCount)
            {
                return -1;
            }
            return this.Source
                .Skip(this.PageSize * pageIndex)
                .Take(this.PageSize)
                .Count();
        }

        public int PageIndex(int itemIndex)
        {
            if (itemIndex < 0 || itemIndex >= this.ItemCount)
            {
                return -1;
            }

            return itemIndex / this.PageSize;
        }
    }
}
