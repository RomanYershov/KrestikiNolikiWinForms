using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Abstraction;
using BLL.Models;

namespace KrestikiNokikiWinForm
{
    public partial class Form1 : Form
    {
        private  GameBase _game;
        public delegate void buttonDelegate();

        public delegate bool groupBoxDelegate(bool hold);
        public Form1()
        {
            InitializeComponent();
            if (radioButton1.Checked)
            {
                _game = new PlayerVsPlayer();
                FieldHold(true);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var currentCell = ((Button)sender);
            if(!string.IsNullOrEmpty(currentCell.Text))return;
            var player = _game.Step(currentCell.TabIndex);
            currentCell.Text = player.Content;
            Task.Run(() =>
            {
                if (!radioButton1.Checked)
                {
                    Thread.Sleep(500);
                    var result = _game.Step(currentCell.TabIndex);
                    if (result == null)
                    {
                        label1.Text = "НИЧЬЯ";
                        FieldHold(true);
                        return;
                    }
                    foreach (Control cell in groupBox1.Controls)
                    {
                        if (cell.TabIndex == result.Index)
                        {
                            var setTextAction = new Action(() => cell.Text = result.Content);
                            cell.Invoke(setTextAction);
                        }
                    }
                    if (_game.CheckWinner())
                    {
                        var setTextAction = new Action(()=> label1.Text = "ПОБЕДИТЕЛЬ: O!!!");
                        label1.Invoke(setTextAction);
                        _game.ClearField();
                         var setFieldHold = new Action(()=> FieldHold(true));
                        groupBox1.Invoke(setFieldHold);
                        // ClearField();
                        return;
                    }
                }
            });
            
           
           
            if (_game.CheckWinner())
            {
                label1.Text = $"Победили: {player.Content}";
                _game.ClearField();
                FieldHold(true);
               // ClearField();
                return;
            }
            //label1.Text = $"ХОД: {((PlayerVsPlayer)_game).NextStep()}";
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            _game = radioButton1.Checked ? (GameBase) new PlayerVsPlayer() : new PlayerVsComuter();
            FieldHold(true);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            _game.Start();
            FieldHold(false);
        }
    }
}
