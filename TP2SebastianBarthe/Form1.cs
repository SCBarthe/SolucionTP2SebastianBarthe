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
    public partial class Form1 : Form
    {
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
            //Cargar la planilla desde la DB

            CamarasNegocio negocio = new CamarasNegocio();
            try
            {

                List<Camaras> listaObtenida = negocio.listado();
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
            Camaras Cam = (Camaras)dgvCamaras.CurrentRow.DataBoundItem;
            pbxCamaras.Load(Cam.ImagenUrl); 
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmCamaras nuevaVentana = new frmCamaras();
            nuevaVentana.ShowDialog();
            Cargar(); 
        }
    }
}
