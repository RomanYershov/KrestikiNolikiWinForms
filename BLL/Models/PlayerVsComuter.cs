using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Abstraction;

namespace BLL.Models
{
  public  class PlayerVsComuter : GameBase
    {
        public int StepCount { get; private set; }

        public PlayerVsComuter() : base()
        {
            StepCount = 1;
        }
        public override void Start()
        {
            PlayerX = new PlayerX();
            PlayerO = new PlayerComp();
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
