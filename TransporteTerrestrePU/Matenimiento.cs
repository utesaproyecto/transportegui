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
    public partial class Matenimiento : FormBase
    {
        public Matenimiento()
        {
            InitializeComponent();
        }
        public virtual void Prueba()
        {
            MessageBox.Show("Se esta imprimiendo el mantenimiento");
        }
        private void metroButton1_Click(object sender, EventArgs e)
        {
            Prueba();
        }
    }
}
