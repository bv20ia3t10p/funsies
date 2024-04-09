using funsies.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funsies
{
    public class View : IView
    {
        IUiHandler _handler;
        public View(IUiHandler handler)
        {
            this._handler = handler;
        }
        public void Start()
        {
            while (true)
            {
                PrintMenu();
                int sel = _handler.Prompt("Enter your selection");
                try
                {
                    switch (sel)
                    {
                        case 1:
                            _handler.ChangeCurrentPageSize();
                            break;
                        case 2:
                            _handler.MoveToNextPage();
                            break;
                        case 3:
                            _handler.MoveToPrevPage();
                            break;
                        default: throw new Exception("Exiting");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    break;
                }
            }
        }
        public void PrintMenu()
        {
            Console.WriteLine("1. Change page size");
            Console.WriteLine("2. Next");
            Console.WriteLine("3. Prev");
            Console.WriteLine("4. Exit");
        }

    }
}
