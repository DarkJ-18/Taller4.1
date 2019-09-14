using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller4._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void Btnregistrar_Click(object sender, EventArgs e)
        {
            int numero, total, contador;
            numero = int.Parse(txtnumeros.Text);
            contador = 0;
            int limite = 10;
            for (int i = 1; i <= limite; i++)
            {

                contador += 1;

                total = numero * contador;


                dataGridView1.Rows.Add(numero, contador.ToString(), total.ToString());


            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            txtnumeros.Text = "";
            txtnumeros.Focus();
        }
    }
}

