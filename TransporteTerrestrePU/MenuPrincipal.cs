using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
namespace TransporteTerrestrePU
{
    public partial class MenuPrincipal : FormBase
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            this.btnentrar.Click += new EventHandler(btn_show_Click);
            this.tabInicio.Click += new EventHandler(btn_show_Click);
            this.tabNosotros.Click += new EventHandler(btn_show_Click);
            this.tabServicios.Click += new EventHandler(btn_show_Click);

        }

        void btn_show_Click(object sender, EventArgs e)
        {
            Principal a = new Principal();
           a.metroPanel1.Controls.Clear();
            MenuMantenimiento frm1 = new MenuMantenimiento();
            frm1.FormBorderStyle = FormBorderStyle.None;
            frm1.Dock = DockStyle.Fill;
            frm1.WindowState = FormWindowState.Maximized;
            frm1.TopLevel = false;
            a.Controls.Add(frm1);
            frm1.Show();
            /*this.metroPanel1.Controls.Clear();
            int tag = Convert.ToInt32((sender as Button).Tag);
            MessageBox.Show(""+tag);
            switch (tag)
            {
                case 1:
                    Login frm1 = new Login();
                    frm1.FormBorderStyle = FormBorderStyle.None;
                    frm1.Dock = DockStyle.Fill;
                    frm1.WindowState = FormWindowState.Maximized;
                    frm1.TopLevel = false;
                    this.metroPanel1.Controls.Add(frm1);
                    frm1.Show();
                    break;
                case 2:

                    break;
                case 3:

                    break;
                case 4:

                    break;
            }*/
        }

        public void botones()
        {
          
            
        }

        private void btnentrar_Click(object sender, EventArgs e)
        {
            //Principal a = new Principal();
           // a.metroPanel1.Visible=false;
            MenuMantenimiento frm1 = new MenuMantenimiento();
            frm1.FormBorderStyle = FormBorderStyle.None;
            frm1.Dock = DockStyle.Fill;
            frm1.WindowState = FormWindowState.Maximized;
            frm1.TopLevel = false;
           
            txtContrasena.Visible = false;
            tabLogin.Controls.Clear();
            MetroTabPage a = new MetroTabPage();
            a.Text = "Mantenimientos";
            metroTabControl1.Controls.Add(a);
            a.Controls.Add(frm1);
            metroTabControl1.SelectedTab = a;
            frm1.Show();
           
        }
    }
}
