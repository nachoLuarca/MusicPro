using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class vAdmin : Form
    {
        public vAdmin()
        {
            InitializeComponent();
        }

        private void btn_proveedor_Click(object sender, EventArgs e)
        {
            FrmProveedorcs CL = new FrmProveedorcs();
            CL.ShowDialog();
        }
    }
}
