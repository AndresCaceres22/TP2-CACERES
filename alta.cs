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
    public partial class alta : Form
    {
        private productos productos = null;
        public alta()
        {
            InitializeComponent();
        }



        public alta(productos pro)
        {
            InitializeComponent();
            pro = productos;
        }

        private void ldescripcion_Click(object sender, EventArgs e)
        {

        }

        private void alta_Load(object sender, EventArgs e)
        {
            marcasnegocio mn = new marcasnegocio();
            categoriasnegocio cn = new categoriasnegocio();
            try
            {
                comboBox1.DataSource = mn.listarmarcas();
                comboBox1.DisplayMember = "descripcion";
                comboBox1.ValueMember = "codigo";
                comboBox2.DataSource = cn.listarcategorias();
                comboBox2.DisplayMember = "descripcion";
                comboBox2.ValueMember = "codigo";
                

                if (productos != null)
                {
                    tnombre.Text = productos.nombre;
                    comboBox1.SelectedValue = productos.marca.codigo;
                    comboBox2.SelectedValue = productos.categoria.codigo;
                }
            }
            catch (Exception )
            {

                throw;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            productosnegocio pn = new productosnegocio();

            try
            {
                if (productos == null)
                    productos = new productos(); 
                productos.nombre = tnombre.Text.Trim();
                productos.codigo = tcodigo.Text.Trim();
                productos.imagenurl = turl.Text.Trim();
                productos.marca = (marcas)comboBox1.SelectedItem;
                productos.descripcion = tdescripcion.Text.Trim();
                productos.categoria =(categorias)comboBox2.SelectedItem;
                productos.precio = decimal.Parse(tprecio.Text);

                if (productos.id == 0)
                    pn.agregar(productos);
                
                else
                    pn.modificar(productos);
                MessageBox.Show("modificado");

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lmarca_Click(object sender, EventArgs e)
        {

        }
    }
}
