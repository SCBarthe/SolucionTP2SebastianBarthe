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
using System.IO; 

namespace TP2SebastianBarthe
{
    public partial class Form1 : Form
    {
        private List<Camaras> listaObtenida;
        public Form1()
        {
            InitializeComponent();
        }

        private void dgvCamaras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Cargar();

        }

        private void Cargar()
        {
            

            CamarasNegocio negocio = new CamarasNegocio();
            
            try
            {

                listaObtenida= negocio.listado();
                
                dgvCamaras.DataSource = listaObtenida;
               
                dgvCamaras.Columns[0].Visible = false;


                
                pbxCamaras.Load(listaObtenida[0].ImagenUrl);
                
              

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString()); 
            }
        }

        private void dgvCamaras_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if(dgvCamaras.SelectedRows.Count != 0)
                {
                    Camaras Cam = (Camaras)dgvCamaras.CurrentRow.DataBoundItem;

                    pbxCamaras.Load(Cam.ImagenUrl);
                }
               
                

            }
            catch (FileNotFoundException ex)
            {
                pbxCamaras.Load("https://www.wddonline.com/content/uploads/2020/08/placeholder-image.png" ); 

            }
        }


        

        

        

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            CamarasNegocio negocio = new CamarasNegocio();
            Camaras seleccion = (Camaras)dgvCamaras.CurrentRow.DataBoundItem;
                       
           
            try
            {
                if (MessageBox.Show("Confirma la baja definitiva ?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)  
                {
                    negocio.eliminarCam(seleccion.Id);
                    Cargar();

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo Eliminar" + ex.ToString()); 
            }

        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            filtro();

        }

        private void txbFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            filtro();
        }

        private void filtro()
        {
            string filtro = txbFiltro.Text;

            if (filtro == "" || filtro.Length <=2)
            {
                dgvCamaras.DataSource = null;
                dgvCamaras.DataSource = listaObtenida;
            }
            else 
            {
                List<Camaras> listaFiltrada = listaObtenida.FindAll(xxx => xxx.Descripcion.ToUpper().Contains(filtro.ToUpper()) || xxx.Nombre.ToUpper().Contains(filtro.ToUpper()));
                dgvCamaras.DataSource = null;
                dgvCamaras.DataSource = listaFiltrada;
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            Camaras seleccion = (Camaras)dgvCamaras.CurrentRow.DataBoundItem;
            frmCamaras nuevaVentana = new frmCamaras(seleccion);
            nuevaVentana.ShowDialog();
            Cargar();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmCamaras nuevaVentana = new frmCamaras();
            nuevaVentana.ShowDialog();
            Cargar();
        }



        private void btnDetalle_Click(object sender, EventArgs e)
        {
            Camaras seleccion = (Camaras)dgvCamaras.CurrentRow.DataBoundItem;
            frmDetalle nuevaVentana = new frmDetalle(seleccion);
            nuevaVentana.ShowDialog();
            Cargar();



        }
    }
}
