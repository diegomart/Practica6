using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Practica_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Facturar_Click(object sender, EventArgs e)
        {
            double producto1 = double.Parse(this.p1.Text);
            double producto2 = double.Parse(this.p2.Text);
            double producto3 = double.Parse(this.p3.Text);

            double subt = producto1 + producto2 + producto3;
            double IVA = subt * .15;
            double tot = subt + IVA;

            this.subtotal.Text=subt.ToString();
            this.iva.Text = IVA.ToString();
            this.total.Text =tot.ToString();




        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            this.p1.Text = "";
            this.p2.Text = "";
            this.p3.Text = "";
            this.subtotal.Text = "";
            this.iva.Text = "";
            this.total.Text = "";



        }

        
    }
}
