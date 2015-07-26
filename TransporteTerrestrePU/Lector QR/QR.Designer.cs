namespace TransporteTerrestrePU.Lector_QR
{
    partial class QR
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QR));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.videoSourcePlayer1 = new AForge.Controls.VideoSourcePlayer();
            this.videoSourcePlayer2 = new AForge.Controls.VideoSourcePlayer();
            this.videoSourcePlayer3 = new AForge.Controls.VideoSourcePlayer();
            this.videoSourcePlayer4 = new AForge.Controls.VideoSourcePlayer();
            this.videoSourcePlayer5 = new AForge.Controls.VideoSourcePlayer();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(135, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(213, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Pase su Codigo frente a la Camara";
            // 
            // videoSourcePlayer1
            // 
            this.videoSourcePlayer1.Location = new System.Drawing.Point(0, 0);
            this.videoSourcePlayer1.Name = "videoSourcePlayer1";
            this.videoSourcePlayer1.TabIndex = 0;
            this.videoSourcePlayer1.VideoSource = null;
            // 
            // qrCodeImgControl1
            // 
           this.qrCodeImgControl1.Image = ((System.Drawing.Image)(resources.GetObject("qrCodeImgControl1.Image")));
            this.qrCodeImgControl1.Location = new System.Drawing.Point(350, 267);
            this.qrCodeImgControl1.Name = "qrCodeImgControl1";
            this.qrCodeImgControl1.Size = new System.Drawing.Size(100, 50);
            this.qrCodeImgControl1.TabIndex = 1;
            this.qrCodeImgControl1.TabStop = false;
            this.qrCodeImgControl1.Text = "qrCodeImgControl1";
            // 
            // videoSourcePlayer2
            // 
            this.videoSourcePlayer2.Location = new System.Drawing.Point(0, 0);
            this.videoSourcePlayer2.Name = "videoSourcePlayer2";
            this.videoSourcePlayer2.TabIndex = 0;
            this.videoSourcePlayer2.VideoSource = null;
            // 
            // videoSourcePlayer3
            // 
            this.videoSourcePlayer3.Location = new System.Drawing.Point(0, 0);
            this.videoSourcePlayer3.Name = "videoSourcePlayer3";
            this.videoSourcePlayer3.TabIndex = 0;
            this.videoSourcePlayer3.VideoSource = null;
            // 
            // videoSourcePlayer4
            // 
            this.videoSourcePlayer4.Location = new System.Drawing.Point(0, 0);
            this.videoSourcePlayer4.Name = "videoSourcePlayer4";
            this.videoSourcePlayer4.TabIndex = 0;
            this.videoSourcePlayer4.VideoSource = null;
            // 
            // videoSourcePlayer5
            // 
            this.videoSourcePlayer5.Location = new System.Drawing.Point(10, 95);
            this.videoSourcePlayer5.Name = "videoSourcePlayer5";
            this.videoSourcePlayer5.Size = new System.Drawing.Size(483, 241);
            this.videoSourcePlayer5.TabIndex = 1;
            this.videoSourcePlayer5.Text = "videoSourcePlayer5";
            this.videoSourcePlayer5.VideoSource = null;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(323, 342);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(170, 29);
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "Cancelar Lector del Codigo";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(75, 342);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(242, 29);
            this.metroComboBox1.TabIndex = 3;
            this.metroComboBox1.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(10, 346);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(59, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Camara:";
            // 
            // QR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 385);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.videoSourcePlayer5);
            this.Controls.Add(this.metroLabel1);
            this.Name = "QR";
            this.Text = "QR";
            this.Load += new System.EventHandler(this.QR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qrCodeImgControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer1;
        private Gma.QrCodeNet.Encoding.Windows.Forms.QrCodeImgControl qrCodeImgControl1;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer2;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer3;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer4;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer5;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}