using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class Field
    {
        public List<Cell> Cells;

        public Field(int collCells)
        {
            Cells = new List<Cell>();
            for (int i = 0; i < collCells * collCells; i++)
            {
                Cells.Add(new Cell(i));
            }
        }

        public void Clear()
        {
            foreach (var cell in Cells)
            {
                cell.Content = string.Empty;
            }
        }
    }
}
