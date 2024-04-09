using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funsies.Service
{
    public interface IDataHandler
    {
        List<int> Next();
        List<int> Prev();
        List<int> ChangePageSize( int newSize );
    }
}
