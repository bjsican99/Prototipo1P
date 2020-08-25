using BodegasAgricolas.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BodegasAgricolas
{
    public partial class frmmenu : Form
    {
        public frmmenu()
        {
            InitializeComponent();
            
        }

        private void mantenimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void generarOrdenCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCompras com = new frmCompras();
            com.Show();
            
        }

        private void procesosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ventasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Ventas ven = new Ventas();
            ven.Show();
        }

        private void mostradorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Cotizacion cot = new Cotizacion();
            cot.Show();
        }
    }
}
