using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
   public  class Cell
   {
       public int Index { get; private set; }   
        public string Content { get; set; }

        public Cell(int index)
        {
            Index = index;
            Content = string.Empty;
        } 
    }
}
