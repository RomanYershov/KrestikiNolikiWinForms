using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Abstraction;

namespace BLL.Models
{
   public  class PlayerVsPlayer : GameBase
    {
        public int StepCount { get; private set; }

        public PlayerVsPlayer() : base()
        {
            StepCount = 1;
        }
       
        public override void Start()
        {
            PlayerX = new PlayerX();
            PlayerO = new PlayerO();
        }
            
        public override Cell Step(int currentCell)
        {
            if (StepCount++ % 2 != 0)
            {
                return PlayerX.Move(Field, currentCell);
            }   
            return PlayerO.Move(Field, currentCell);
        }

        public string NextStep()
        {
            return StepCount % 2 == 0 ? "O" : "X";
        }
     
    }
}
