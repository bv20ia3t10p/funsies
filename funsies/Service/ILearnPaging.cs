using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funsies.Service
{
    public interface ILearnPaging
    {
        List<int> Paging(int pageIndex, int pageSize);
    }
}
