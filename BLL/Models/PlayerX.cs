using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Abstraction;

namespace BLL.Models
{
    public class PlayerX : IPlayer
    {
        public string Move()
        {
            return "X";
        }
    }
}
