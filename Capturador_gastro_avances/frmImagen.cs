using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
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
