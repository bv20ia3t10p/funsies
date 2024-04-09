using funsies.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funsies
{
    public class UiHandler : IUiHandler
    {
        private readonly IDataHandler _handler;
        public UiHandler(IDataHandler handler)
        {
            _handler = handler;
        }
        public void MoveToNextPage()
        {
            try
            {
                PrintResult(_handler.Next());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void MoveToPrevPage()
        {
            try
            {
                PrintResult(_handler.Prev());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void ChangeCurrentPageSize()
        {
            PrintResult(_handler.ChangePageSize(Prompt("Enter new size")));
        }
        public int Prompt(string message)
        {
            Console.WriteLine(message);
            return int.Parse(Console.ReadLine() ?? "-1");
        }



        public void PrintResult(List<int> result)
        {
            string res = "";
            foreach (int i in result) { res += $"{i} "; }
            Console.WriteLine(res);
        }
    }
}
