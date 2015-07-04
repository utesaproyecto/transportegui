namespace TransporteTerrestrePU
{
    partial class Mantenimientos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.manteniMientosPersona = new MetroFramework.Controls.MetroTabPage();
            this.groupMantenimiento = new System.Windows.Forms.GroupBox();
            this.tabVehiculo = new MetroFramework.Controls.MetroTabPage();
            this.metroPanel1.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.manteniMientosPersona.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroTabControl1);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(884, 642);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.manteniMientosPersona);
            this.metroTabControl1.Controls.Add(this.tabVehiculo);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(0, 0);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(884, 642);
            this.metroTabControl1.TabIndex = 2;
            this.metroTabControl1.UseSelectable = true;
            this.metroTabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.metroTabControl1_Selected);
            // 
            // manteniMientosPersona
            // 
            this.manteniMientosPersona.BackColor = System.Drawing.SystemColors.Control;
            this.manteniMientosPersona.Controls.Add(this.groupMantenimiento);
            this.manteniMientosPersona.HorizontalScrollbarBarColor = true;
            this.manteniMientosPersona.HorizontalScrollbarHighlightOnWheel = false;
            this.manteniMientosPersona.HorizontalScrollbarSize = 10;
            this.manteniMientosPersona.Location = new System.Drawing.Point(4, 38);
            this.manteniMientosPersona.Name = "manteniMientosPersona";
            this.manteniMientosPersona.Size = new System.Drawing.Size(876, 600);
            this.manteniMientosPersona.TabIndex = 0;
            this.manteniMientosPersona.Text = "Departamentos";
            this.manteniMientosPersona.VerticalScrollbarBarColor = true;
            this.manteniMientosPersona.VerticalScrollbarHighlightOnWheel = false;
            this.manteniMientosPersona.VerticalScrollbarSize = 10;
            // 
            // groupMantenimiento
            // 
            this.groupMantenimiento.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupMantenimiento.Location = new System.Drawing.Point(0, 11);
            this.groupMantenimiento.Name = "groupMantenimiento";
            this.groupMantenimiento.Size = new System.Drawing.Size(1016, 580);
            this.groupMantenimiento.TabIndex = 1;
            this.groupMantenimiento.TabStop = false;
            // 
            // tabVehiculo
            // 
            this.tabVehiculo.HorizontalScrollbarBarColor = true;
            this.tabVehiculo.HorizontalScrollbarHighlightOnWheel = false;
            this.tabVehiculo.HorizontalScrollbarSize = 10;
            this.tabVehiculo.Location = new System.Drawing.Point(4, 38);
            this.tabVehiculo.Name = "tabVehiculo";
            this.tabVehiculo.Size = new System.Drawing.Size(876, 600);
            this.tabVehiculo.TabIndex = 1;
            this.tabVehiculo.Text = "Vehiculos";
            this.tabVehiculo.VerticalScrollbarBarColor = true;
            this.tabVehiculo.VerticalScrollbarHighlightOnWheel = false;
            this.tabVehiculo.VerticalScrollbarSize = 10;
            // 
            // Mantenimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 642);
            this.Controls.Add(this.metroPanel1);
            this.Name = "Mantenimientos";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Mantenimientos Menu";
            this.Load += new System.EventHandler(this.Mantenimientos_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroTabControl1.ResumeLayout(false);
            this.manteniMientosPersona.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        public MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage manteniMientosPersona;
        private MetroFramework.Controls.MetroTabPage tabVehiculo;
        public System.Windows.Forms.GroupBox groupMantenimiento;


    }
}