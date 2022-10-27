using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using producto;
using negocios; 

namespace TP2SebastianBarthe
{
    public partial class frmDetalle : Form
    {
        private Camaras camara = null; 


        public frmDetalle()
        {
            InitializeComponent();
        }

        public frmDetalle(Camaras camara)
        {
            InitializeComponent();
            this.camara = camara; 
        }




        private void frmDetalle_Load(object sender, EventArgs e)
        {
            MarcasNegocios marcasNegocios = new MarcasNegocios();

            try
            {


                cboMarca.DataSource = marcasNegocios.listado();
                cboMarca.ValueMember = "Id";
                cboMarca.DisplayMember = "Descripcion";


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


            categoriasNegocio CategoriasNegocio = new categoriasNegocio();
            try
            {
                cboCategoria.DataSource = CategoriasNegocio.listado();
                cboCategoria.ValueMember = "Id";
                cboCategoria.DisplayMember = "Descripcion";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            try
            {

                if (camara != null)
                {

                    txtCodigo.Text = camara.Codigo;
                    txtNombre.Text = camara.Nombre;
                    txtDescripcion.Text = camara.Descripcion;
                    txtImagenUrl.Text = camara.ImagenUrl;
                    nudPrecio.DecimalPlaces = (int)camara.Precio;
                    cboMarca.SelectedValue = camara.Marcas.Id;
                    cboCategoria.SelectedValue = camara.Categoria.Id;


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }
    }
}
