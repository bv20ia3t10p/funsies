using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funsies.Service
{
    public interface IUiHandler
    {
        public void PrintResult(List<int> list);
        public int Prompt(string message);
        public void MoveToNextPage();
        public void MoveToPrevPage();
        public void ChangeCurrentPageSize();
    }
}
