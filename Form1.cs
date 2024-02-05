using System;
using System.Diagnostics;
using System.IO.Ports;
using System.Windows.Forms;

namespace İstasyon
{

    public partial class Form1 : Form
    {
        private SerialPort seriPort1;

        public Form1()
        {
            InitializeComponent();
            InitializeSerialPort();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (seriPort1.IsOpen)
                seriPort1.Close();
        }

        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string gelenVeri = seriPort1.ReadLine();
            UpdateUI(gelenVeri);
        }

        private void UpdateUI(string veri)
        {
            if (veri.Contains("Sicaklik") && veri.Contains("Nem"))
            {
                // Sicaklik ve Nem verisi içeriyorsa
                string[] degerler = veri.Split(' ');

                string sicaklik = degerler[1];
                string nem = degerler[4];

                this.Invoke((MethodInvoker)(() => labelSicaklik.Text = "Sıcaklık: " + sicaklik + " C"));
                this.Invoke((MethodInvoker)(() => labelNem.Text = "Nem: " + nem + " %"));
            }
            
            else if (veri.Contains("Isik Degeri"))
            {
                string[] degerler = veri.Split(':');
                if (degerler.Length == 2)
                {
                    string isikDegeri = degerler[1].Trim();
                    this.Invoke((MethodInvoker)(() => labelIsikDegeri.Text = "Işık Değeri: " + isikDegeri));
                }
            }
            else if (veri.Contains("Durum"))
            {
                string[] degerler = veri.Split(':');
                if (degerler.Length == 2)
                {
                    string havaDurumu = degerler[1].Trim();
                    this.Invoke((MethodInvoker)(() => labelDurum.Text = "Durum: " + havaDurumu));
                }
            }
        }
        private void InitializeSerialPort()
        {
            seriPort1 = new SerialPort
            {
                PortName = "COM3",
                BaudRate = 9600,
                DataBits = 8,
                Parity = Parity.None,
                StopBits = StopBits.One
            };

            seriPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort_DataReceived);

            try
            {
                seriPort1.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seri port açılırken hata oluştu: " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}