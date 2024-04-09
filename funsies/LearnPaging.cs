using funsies.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funsies
{
    public class LearnPaging : ILearnPaging
    {
        private List<int> data;

        // collection từ phần tử 0 -> 49
        public LearnPaging() => data = Enumerable.Range(0, 50).ToList();

        public List<int> Paging(int pageIndex = 0, int pageSize = 10)
        {
            // Triển khai phân trang dữ liệu
            int pageNo = (int)Math.Ceiling(data.Count * 1.0 / pageSize);
            if (pageIndex < 0 || pageIndex >= pageNo - 1) return data.Take(0).ToList();
            return data.Skip(pageIndex * pageSize).Take(pageSize).ToList();
        }
    }
}
