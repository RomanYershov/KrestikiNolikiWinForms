using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Models;

namespace BLL.Abstraction
{
    public abstract class GameBase
    {
        public IPlayer PlayerX { get; set; }
        public IPlayer PlayerO { get; set; }
        public Field Field { get; set; }
        private readonly CheckWinnerBase _checkWinner;

        protected GameBase()
        {
            Field = new Field(3);
            _checkWinner = new CheckWinnerBase(Field);
        }
        public virtual bool CheckWinner()
        {
            return _checkWinner.Check(new CheckWinVertical())
                   || _checkWinner.Check(new CheckWinHorisontal())
                   || _checkWinner.Check(new CheckWinDiagonal());
        }
        public void ClearField()
        {
            foreach (var cell in Field.Cells)
            {
                cell.Content = string.Empty;
            }
        }

        public abstract void Start();
        public abstract Cell Step(int currentCell);
    }
}
