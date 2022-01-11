using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capturador_gastro_avances
{
    public partial class frmImagen : Form
    {
        int brillo, contraste, saturacion = 0;
        frmSesion sesion = null;
        public frmImagen(frmSesion sesion)
        {
            this.sesion = sesion;
            InitializeComponent();
        }

        private void trkBrillo_Scroll(object sender, EventArgs e)
        {
            int n = trkBrillo.Value;
            sesion.setBrillo(n);
            
        }

        private void trkContraste_Scroll(object sender, EventArgs e)
        {
            int n = trkContraste.Value;
            sesion.setContraste(n);
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            trkBrillo.Value = 0;
            trkContraste.Value = 0;
            trkSaturacion.Value = 0;
            sesion.setBrillo(0);
            sesion.setContraste(0);
            sesion.setSaturaction(0);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void trkSaturacion_Scroll(object sender, EventArgs e)
        {
            int n = trkSaturacion.Value;
            float sat = (float)n / 100;
            sesion.setSaturaction(sat);
        }

        private void frmImagen_Load(object sender, EventArgs e)
        {

        }
    }
}
