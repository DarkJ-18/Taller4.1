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

        int num=1;

        private void Btnregistrar_Click(object sender, EventArgs e)
        {
            int tabla = int.Parse(txtnumeros.Text);
           // string total;
            

            dataGridView1.Rows.Add(tabla, num+"");

            num++;


            for (int i = tabla; i <= 10; i++)
            {

                for (int j = tabla; j <= 10; j++)
                {

                }

            }

           

        }
    }
}
