using System;
using System.Data.SqlClient;
using System.Windows.Forms;

using System.Configuration;
using System.Data;

namespace CapaPresentacion
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }


        public void logins(string usuario, string contraseña)
        {
            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cnn))
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT Nombre, Tipo_usuario FROM Usuarios WHERE Usuario= @usuario AND Contraseña= @contraseña", conexion))
                    {
                        cmd.Parameters.AddWithValue("usuario", usuario);
                        cmd.Parameters.AddWithValue("contraseña", contraseña);
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                        if (dt.Rows.Count == 1)
                        {
                            this.Hide();
                            if (dt.Rows[0][1].ToString() == "Admin")
                            {
                                vAdmin AD = new vAdmin();
                                AD.ShowDialog();

                            }
                            if (dt.Rows[0][1].ToString() == "Vendedor")
                            {
                                VVendedor VR = new VVendedor();
                                VR.ShowDialog();
                            }
                            if (dt.Rows[0][1].ToString() == "Bodeguero")
                            {
                                VBodegero BO = new VBodegero();
                                BO.ShowDialog();
                            }
                            if (dt.Rows[0][1].ToString() == "Contador")
                            {
                                VContador C = new VContador();
                                C.ShowDialog();
                            }
                            else if (dt.Rows[0][1].ToString() == "Cliente")
                            {
                                VCliente CL = new VCliente();
                                CL.ShowDialog();
                            }
                            this.Show();
                        }
                        else
                        {
                            MessageBox.Show("Usuario y/o Contraseña Incorrectos");
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btnInicio_Click(object sender, EventArgs e)
        {
            logins(this.txtUsuario.Text, this.txtContraseña.Text);
        }
    }
}
