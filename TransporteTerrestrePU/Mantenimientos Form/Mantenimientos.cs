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
    public partial class Mantenimientos:FormBase
      {
        public Mantenimientos()
        {
            InitializeComponent();
        }
        

        private void metroTabControl1_Selected(object sender, TabControlEventArgs e)
        {
            //e.TabPage.Controls.Add(groupBox1);
            this.groupMantenimiento.Controls.Clear();
            Matenimiento frm1 = new Matenimiento();
            frm1.FormBorderStyle = FormBorderStyle.None;
            frm1.Dock = DockStyle.None;
           // frm1.WindowState = FormWindowState.Maximized;
            frm1.TopLevel = false;
            this.groupMantenimiento.Controls.Add(frm1);
            frm1.Show();
            this.groupMantenimiento.Refresh();
        }

        private void Mantenimientos_Load(object sender, EventArgs e)
        {
            Matenimiento frm1 = new Matenimiento();
            frm1.FormBorderStyle = FormBorderStyle.None;
            frm1.Dock = DockStyle.None;
            // frm1.WindowState = FormWindowState.Maximized;
            frm1.TopLevel = false;
            this.groupMantenimiento.Controls.Add(frm1);
            frm1.Show();
            this.groupMantenimiento.Refresh();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

         

            
        }

        private void groupMantenimiento_Enter(object sender, EventArgs e)
        {

        }
    }
}
