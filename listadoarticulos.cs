using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace articulos
{
    public partial class listadoarticulos : Form
    {
        public listadoarticulos()
        {
            InitializeComponent();
        }

        private void listadoarticulos_Load(object sender, EventArgs e)
        {
            productosnegocio negocio = new productosnegocio();
            dgvlistado.DataSource = negocio.listar();

        }

        private void beditar_Click(object sender, EventArgs e)
        {
            productos modi = (productos)dgvlistado.CurrentRow.DataBoundItem;
            alta al = new alta(modi);
            al.ShowDialog();
            

        }
    }
}
