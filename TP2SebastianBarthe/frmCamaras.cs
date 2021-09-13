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
    public partial class frmCamaras : Form
    {
        public frmCamaras()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close(); 
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Camaras nuevaCam = new Camaras();
            CamarasNegocio negocio = new CamarasNegocio();

            try
            {
                nuevaCam.Codigo = txtCodigo.Text;
                nuevaCam.Nombre = txtNombre.Text;
                nuevaCam.Descripcion = txtDescripcion.Text;
                nuevaCam.ImagenUrl = txtImagenUrl.Text;

                negocio.agregar(nuevaCam);

                MessageBox.Show("Camara agregada exitosamente");
                Close(); 
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex. ToString()); 

            }






        }

        private void frmCamaras_Load(object sender, EventArgs e)
        {

        }
    }
}
