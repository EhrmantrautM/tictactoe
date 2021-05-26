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

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeComponent();
        }
        private int player = 2;
        private int turns = 0;
    
        private void labx_Click(object sender, EventArgs e)
        {

        }

        private void button_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (player % 2 == 0);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
