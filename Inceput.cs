using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ludo_Now
{
    public partial class Inceput : Form
    {
        Tabla form1;
        public Inceput()
        {
            InitializeComponent();
            form1 = new Tabla();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            this.Hide();
            form1.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
