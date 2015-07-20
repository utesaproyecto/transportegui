using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransporteTerrestrePU
{
    public partial class Formulario_de_Registro_de_Rutas : MetroFramework.Forms.MetroForm
    {
        public Formulario_de_Registro_de_Rutas()
        {
            InitializeComponent();
        }

        private void metroLabel11_Click(object sender, EventArgs e)
        {

        }

        private void Formulario_de_Registro_de_Rutas_Load(object sender, EventArgs e)
        {
            Fecha.Text += DateTime.Now.ToString();
        }

        private void metroLabel9_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
