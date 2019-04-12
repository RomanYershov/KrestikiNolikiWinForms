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
        public Cell Move(Field field, int index)
        {
            field.Cells[index].Content = "O";
            return new Cell(index) { Content = "O" };
        }
    }
}
