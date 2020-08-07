using Login.Apresentacao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {

        public object CadastreSe { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastreSe_Click(object sender, EventArgs e)
        
            {
                CadastreSe cad = new CadastreSe();
                cad.Show();
            }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}