using CapaNegocio;
using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmProveedorcs : Form
    {
        Proveedor p;
        public FrmProveedorcs()
        {
            InitializeComponent();
        }

     

        private void btnListar_Click(object sender, EventArgs e)
        {
            ColeccionesMusic vc = new ColeccionesMusic();
            dgvListado.DataSource = null;
            dgvListado.DataSource = vc.ReadAll();
            dgvListado.Refresh();
        }

        private void DgvListado_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0)
                return;
            p = (Proveedor)dgvListado.Rows[e.RowIndex].DataBoundItem;

            txtNombre.Text = p.Nombre;
            txtContacto.Text = p.Contacto;
            txtDireccion.Text = p.Direccion;
            txtNombreE.Text = p.NombreEmpresa;
          
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim().Length > 1)
            {
                p.Nombre = txtNombre.Text;
                txtNombre.Focus();
                
            }
            else
                MessageBox.Show("La descripcioón no es válida, vuelva a intentar");
           

            if (txtContacto.Text.Trim().Length > 1)
            {
                p.Contacto = txtContacto.Text;
                txtContacto.Focus();
               
            }
            else
                MessageBox.Show("La descripcioón no es válida, vuelva a intentar");
            

            if (txtDireccion.Text.Trim().Length > 1)
            {
                p.Direccion = txtDireccion.Text;
                txtDireccion.Focus();
              
            }
            else
                MessageBox.Show("La descripcioón no es válida, vuelva a intentar");

       

            if (txtNombreE.Text.Trim().Length > 1)
            {
                p.NombreEmpresa = txtNombreE.Text;
                txtNombreE.Focus();
              
            }
            else
                MessageBox.Show("La descripcioón no es válida, vuelva a intentar");
         


            int resultado = 0;
            if (p.Id == 0)
                resultado = p.Create();
            else
                resultado = p.Update();

            if (resultado == 1)
            {
                MessageBox.Show("Los datos fueron guardados");
                btnLimpiar_Click(null, null);
                btnListar_Click(null, null);
            }
            else
                MessageBox.Show("Los datos NO fueron guardados");

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtContacto.Text = "";
            txtDireccion.Text = "";
            txtNombreE.Text = "";
            txtNombre.Focus();

            p = new Proveedor(); ;
        }

      
    }
}
