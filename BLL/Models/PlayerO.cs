using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using BLL.Abstraction;

namespace BLL.Models
{
    public class PlayerO : IPlayer
    {
        public string Move()
        {
            return "O";
        }
    }
}
