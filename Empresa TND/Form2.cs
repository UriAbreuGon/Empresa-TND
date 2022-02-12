using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empresa_TND
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 Visible = new Form3();
            Visible.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clientescs Visible = new Clientescs();
            Visible.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
     Boletos Visible = new Boletos();
            Visible.Show();
            this.Hide();
        }
    }
}
