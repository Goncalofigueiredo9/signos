using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace signos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        signos dia = new signos();

        private void Button1_Click(object sender, EventArgs e)
        {
            dia.recebe = textBox1.Text;
            label1.Text = ("O dia da semana é " + dia.diadasemana);
            label2.Text = dia.envia;
            label3.Text = dia.signo;
        }
    }
}
