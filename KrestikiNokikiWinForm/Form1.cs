using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Models;

namespace KrestikiNokikiWinForm
{
    public partial class Form1 : Form
    {
        private readonly Game _game;
        private readonly CheckWinnerBase _checkWinner;
        public Form1()
        {
            InitializeComponent();
            _game = new Game();
            _checkWinner = new CheckWinnerBase(_game.field);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var currentCell = ((Button)sender);
            var player = _game.CurrentStep(currentCell.TabIndex, currentCell.Text);
            currentCell.Text = player;

            var resultV = _checkWinner.Check(new CheckWinVertical());
            var resultH = _checkWinner.Check(new CheckWinHorisontal());
            var resultD = _checkWinner.Check(new CheckWinDiagonal());
            if (resultV || resultH || resultD)
            {
                label1.Text = $"Победили: {player}";
                _game.field.Clear();
                FieldHold(true);
               // ClearField();
                return;
            }
            label1.Text = $"ХОД: {_game.NextStep()}";
        }

        private void ClearField()
        {
            foreach (Control control in groupBox1.Controls)
            {
                if (control is Button)
                {
                    control.Text = string.Empty;
                }
            }
        }

        private void FieldHold(bool isHold)
        {
            groupBox1.Enabled = !isHold;
        }
    }
}
