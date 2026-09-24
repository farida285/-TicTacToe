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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            btnStart.BackColor = Color.FromArgb(100, 77,58, 57);
            Form frm = new frmPlayer();
            this.Hide();
            frm.ShowDialog();
            this.Show();

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
           
          
       

        }
    }
}
