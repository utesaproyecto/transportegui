using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using BarcodeLib.BarcodeReader;

namespace TransporteTerrestrePU.Lector_QR
{
    public partial class QR : MetroFramework.Forms.MetroForm
    {
        public QR()
        {
            InitializeComponent();
        }

        private FilterInfoCollection dispositivos;        
        public VideoCaptureDevice fuenteVideo;

        private void QR_Load(object sender, EventArgs e)
        {
         
            dispositivos = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            
            foreach (FilterInfo X in dispositivos)
            {
                metroComboBox1.Items.Add(X.Name);
            }
           metroComboBox1.SelectedIndex = 0;

           timer1.Enabled = true;
         
           fuenteVideo = new VideoCaptureDevice(dispositivos[metroComboBox1.SelectedIndex].MonikerString);
           videoSourcePlayer1.VideoSource = fuenteVideo;
           videoSourcePlayer1.Start();

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            videoSourcePlayer1.SignalToStop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string Codificador="";

            if (videoSourcePlayer1.GetCurrentVideoFrame() != null)
            {
       
                Bitmap img = new Bitmap(videoSourcePlayer1.GetCurrentVideoFrame());
                
                string[] resultados = BarcodeReader.read(img, BarcodeReader.QRCODE);
                
                img.Dispose();
                

                if (resultados != null && resultados.Count() > 0)
                {
                    
                    if (resultados[0].IndexOf("1111") != -1)
                    {
                        resultados[0] = resultados[0].Replace("1111", "");
                        MessageBox.Show("Codigo QR: " + resultados[0]);
                    }
                }
            }
        }
    }
}
