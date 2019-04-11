using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Abstraction;

namespace BLL.Models
{
    public class CheckWinnerBase
    {
        private readonly Field _field;

        public CheckWinnerBase(Field field)
        {
            _field = field;
        }

        public bool Check(WinnerCheck checker)
        {
            return checker.IsWinner(_field);
        }
    }
}
