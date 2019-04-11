using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
   public  class Cell
   {
       private int _index;
        public string Content { get; set; }

        public Cell(int index)
        {
            _index = index;
            Content = string.Empty;
        } 
    }
}
