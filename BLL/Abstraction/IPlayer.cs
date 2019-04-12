using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Models;

namespace BLL.Abstraction
{
    public interface IPlayer
    {
        Cell Move(Field field, int index);      
    }
}
