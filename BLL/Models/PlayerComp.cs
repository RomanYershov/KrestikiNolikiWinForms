using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Abstraction;

namespace BLL.Models
{
   public class PlayerComp : IPlayer
    {
        public Cell Move(Field field, int index)
        {
            Cell cell = null;
            foreach (var fieldCell in field.Cells)
            {
                if (string.IsNullOrEmpty(fieldCell.Content))        
                {
                    cell = new Cell(fieldCell.Index){Content = "O"};
                    fieldCell.Content = "O";
                    break;//todo добавить логику стратегии
                }
            }
            return cell;
        }
    }
}
