using funsies.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funsies
{
    public class DataHandler : IDataHandler
    {
        public ILearnPaging _pagingHelper;
        public DataHandler(ILearnPaging paingHelper)
        {
            _pagingHelper = paingHelper;
            CurrentPage = 0;
            PageSize = 10;
        }
        private int CurrentPage { get; set; }
        private int PageSize { get; set; }

        public List<int> ChangePageSize(int newSize)
        {
            PageSize = newSize;
            return _pagingHelper.Paging(CurrentPage, PageSize);
        }

        public List<int> Next()
        {
            var returnResult = _pagingHelper.Paging(CurrentPage + 1, PageSize);
            if (returnResult.Count == 0) throw new Exception("No more pages to progress");
            CurrentPage += 1;
            return returnResult;

        }
        public List<int> Prev()
        {
            var returnResult = _pagingHelper.Paging(CurrentPage -1, PageSize);
            if (returnResult.Count == 0) throw new Exception("No more pages to progress");
            CurrentPage -= 1;
            return returnResult;
        }
    }
}
