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
    public partial class Principal : MetroFramework.Forms.MetroForm
    {
        public  Principal()
        {
            InitializeComponent();
           

        }
        
        private void btnlogin_Click(object sender, EventArgs e)
        {
           
        }

       

         void btnSalir_Click(object sender, EventArgs e)
        {
           
        }

         private void Principal_Load(object sender, EventArgs e)
         {










       
             this.Style = (MetroFramework.MetroColorStyle.Black);
             this.metroPanel1.Controls.Clear();
             MenuPrincipal frm1 = new MenuPrincipal();
             frm1.FormBorderStyle = FormBorderStyle.None;
             frm1.Dock = DockStyle.Fill;
             frm1.WindowState = FormWindowState.Maximized;
             frm1.TopLevel = false;
             this.metroPanel1.Controls.Add(frm1);
             this.metroPanel1.Theme = (MetroFramework.MetroThemeStyle.Dark);
             frm1.Show();
         }
    }
}
