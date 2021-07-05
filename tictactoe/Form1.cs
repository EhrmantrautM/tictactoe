using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictactoe
{
    public partial class TicTacToe : Form
    {
        public TicTacToe()
        {
            InitializeComponent();
        }
        public int player = 2;
        public int move = 0;                
        private void buttonClick(object sender, EventArgs e)
        {
        Button button = (Button)sender;
        if (button.Text == "")
           if (player % 2 == 0)
              {
                 button.Text = "X";
                 player++;
                 move++;
                }
           else
                {
                 button.Text = "O";
                 player++;
                 move++;
                }
                {
            if (drawgame() == true)
                {
                    MessageBox.Show("Draw");
                    DRAWcnt.Text = (Byte.Parse(DRAWcnt.Text) + 1).ToString();
                    Restart();
                }
            if (Wingame() == true)
                {
                if (button.Text == "O")
                {
                 MessageBox.Show("O WON");
                 OWINcnt.Text = (Byte.Parse(OWINcnt.Text) + 1).ToString();
                 Restart();
                }
                else
                {
                 MessageBox.Show("X WON");
                 XWINcnt.Text = (Byte.Parse(XWINcnt.Text) + 1).ToString();
                 Restart();
                    }
                }
            }
        }
        private void btnex_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank You for playing, Have a nice day ahead!");
            this.Close();
        }
        private void Restart()
        {
            player = 2;
            move = 0;
            btna1.Text = btna2.Text = btna3.Text = btnb1.Text = btnb2.Text = btnb3.Text = btnc1.Text = btnc2.Text = btnc3.Text = "";
        }
        private void btnnew_Click(object sender, EventArgs e)
        {
            Restart();
        }
        bool drawgame()
        {
            if (move == 9)
                return true;
            else
                return false;
        }
        private void btnreset_Click(object sender, EventArgs e)
        {
            OWINcnt.Text = "0".ToString();
            XWINcnt.Text = "0".ToString();
            DRAWcnt.Text = "0".ToString();
            Restart();
        }
        bool Wingame()
        {
            if ((btna1.Text == btna2.Text) && (btna2.Text == btna3.Text) && btna1.Text != "")
                return true;
            else if ((btnb1.Text == btnb2.Text) && (btnb2.Text == btnb3.Text) && btnb1.Text != "")
                return true;
            else if ((btnc1.Text == btnc2.Text) && (btnc2.Text == btnc3.Text) && btnc1.Text != "")
                return true;

            if ((btna1.Text == btnb1.Text) && (btnb1.Text == btnc1.Text) && btna1.Text != "")
                return true;
            else if ((btna2.Text == btnb2.Text) && (btnb2.Text == btnc2.Text) && btna2.Text != "")
                return true;
            else if ((btna3.Text == btnb3.Text) && (btnb3.Text == btnc3.Text) && btna3.Text != "")
                return true;

            if ((btna1.Text == btnb2.Text) && (btnb2.Text == btnc3.Text) && btna1.Text != "")
                return true;
            else if ((btnc1.Text == btnb2.Text) && (btnb2.Text == btna3.Text) && btnc1.Text != "")
                return true;
            else
                return false;        
        }
        private void btnhelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The player who is playing X always goes first. Players alternate placing Xs and Os on the board until either player has three in a row, horizontally, vertically, or diagonally or until all squares on the grid are filled. If a player is able to draw three Xs or three Os in a row, then that player wins. If all squares are filled and neither player has made a complete row of Xs or Os, then the game is a draw.");
        }       
    }
}