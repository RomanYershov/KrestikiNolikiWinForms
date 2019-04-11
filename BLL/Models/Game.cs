using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class Game
    {
        public PlayerX X { get; set; }   
        public PlayerO O { get; set; }
        public Field field;
        public int StepCount { get; private set; }

        public Game()
        {
            StepCount = 1;
            X = new PlayerX();
            O = new PlayerO();
            field = new Field(3);
        }
        public void Start()
        {

        }

        public string CurrentStep(int currentCell, string content)
        {
            if (!string.IsNullOrEmpty(content)) return content;
            var result = StepCount % 2 == 0 ? O.Move() : X.Move();
            field.Cells[currentCell].Content = result;
            ++StepCount;
            return result;  
        }

        public string NextStep()
        {
            return StepCount % 2 == 0 ? O.Move() : X.Move();
        }
    }
}
