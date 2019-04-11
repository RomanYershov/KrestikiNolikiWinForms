using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Abstraction;
        
namespace BLL.Models
{
   public sealed class CheckWinVertical : WinnerCheck
    {
        public override bool IsWinner(Field field)
        {
            if ((field.Cells[0].Content.Contains("X") && field.Cells[3].Content.Contains("X") &&
                field.Cells[6].Content.Contains("X")) || (field.Cells[0].Content.Contains("O") && field.Cells[3].Content.Contains("O") &&
                                                          field.Cells[6].Content.Contains("O")))
            {
                return true;
            }
            if ((field.Cells[1].Content.Contains("X") && field.Cells[4].Content.Contains("X") &&
                 field.Cells[7].Content.Contains("X")) || (field.Cells[1].Content.Contains("O") && field.Cells[4].Content.Contains("O") &&
                                                           field.Cells[7].Content.Contains("O")))
            {
                return true;
            }
            if ((field.Cells[2].Content.Contains("X") && field.Cells[5].Content.Contains("X") &&
                 field.Cells[8].Content.Contains("X")) || (field.Cells[2].Content.Contains("O") && field.Cells[5].Content.Contains("O") &&
                                                           field.Cells[8].Content.Contains("O")))
            {
                return true;
            }
            return false;
        }
    }
}
