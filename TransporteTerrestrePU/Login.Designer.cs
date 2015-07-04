namespace TransporteTerrestrePU
{
    partial class Login
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
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.btnentrar = new MetroFramework.Controls.MetroButton();
            this.btnsalir = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(449, 231);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.Size = new System.Drawing.Size(155, 23);
            this.metroTextBox1.TabIndex = 0;
            this.metroTextBox1.UseSelectable = true;
            // 
            // metroTextBox2
            // 
            this.metroTextBox2.Lines = new string[0];
            this.metroTextBox2.Location = new System.Drawing.Point(449, 175);
            this.metroTextBox2.MaxLength = 32767;
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.PasswordChar = '\0';
            this.metroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox2.SelectedText = "";
            this.metroTextBox2.Size = new System.Drawing.Size(155, 23);
            this.metroTextBox2.TabIndex = 1;
            this.metroTextBox2.UseSelectable = true;
            // 
            // btnentrar
            // 
            this.btnentrar.BackColor = System.Drawing.Color.Black;
            this.btnentrar.Location = new System.Drawing.Point(419, 286);
            this.btnentrar.Name = "btnentrar";
            this.btnentrar.Size = new System.Drawing.Size(75, 23);
            this.btnentrar.TabIndex = 2;
            this.btnentrar.Text = "Entrar";
            this.btnentrar.UseSelectable = true;
            this.btnentrar.Click += new System.EventHandler(this.btnentrar_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(542, 286);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 3;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(290, 231);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(75, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Contrasena";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(290, 179);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(53, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Usuario";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 466);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnentrar);
            this.Controls.Add(this.metroTextBox2);
            this.Controls.Add(this.metroTextBox1);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private MetroFramework.Controls.MetroButton btnentrar;
        private MetroFramework.Controls.MetroButton btnsalir;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}