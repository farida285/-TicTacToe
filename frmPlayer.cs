using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class frmPlayer : Form
    {
        public frmPlayer()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmPlayer_Load(object sender, EventArgs e)
        {
            tbPlayer1.BackColor = Color.FromArgb(255, 250, 245, 255);
            tbPlayer2.BackColor = Color.FromArgb(255, 250, 245, 255);
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            frmGame frm = new frmGame(tbPlayer1.Text,tbPlayer2.Text);
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
