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

        private Camaras camara = null; 

        public frmCamaras()
        {
            InitializeComponent();
        }

        public frmCamaras(Camaras camara)
        {
            InitializeComponent();
            this.camara = camara; 
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close(); 
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
           // Camaras nuevaCam = new Camaras();
            CamarasNegocio negocio = new CamarasNegocio();

            try
            {
                if (camara == null)
                    camara = new Camaras();
                camara.Codigo = txtCodigo.Text;
                camara.Nombre = txtNombre.Text;
                camara.Descripcion = txtDescripcion.Text;
                camara.ImagenUrl = txtImagenUrl.Text;
                camara.Precio = nudPrecio.DecimalPlaces; 


                camara.Marcas = (Producto)cboMarca.SelectedItem;
                camara.Categoria = (categorias)cboCategoria.SelectedItem; 

                if(camara.Id != 0)
                {
                    negocio.modificar(camara);
                    MessageBox.Show("Camara modificada exitosamente");

                }
                else
                {
                    negocio.agregar(camara);
                    MessageBox.Show("Camara agregada exitosamente");

                }
                


                

                
                Close(); 
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex. ToString()); 

            }






        }

        private void frmCamaras_Load(object sender, EventArgs e)
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

        private void cboMarca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblCodigo_Click(object sender, EventArgs e)
        {

        }
    }
}
