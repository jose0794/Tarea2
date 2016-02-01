using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnProyecto_Click(object sender, EventArgs e)
        {
            int [] myInts = {5,7,9};

            foreach (int i in myInts)
                {

                value = value + i +"";

            }
             
            bool Content = true;
            bool noContent = false;
            txtProyecto.Text = Convert.ToString(Content);
            txtProyecto.Text = Convert.ToString(noContent);


        }

        private void txtProyecto2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
