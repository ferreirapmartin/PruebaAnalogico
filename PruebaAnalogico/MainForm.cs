using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaAnalogico
{
    public partial class MainForm : Form
    {
        private SerialPort puerto;
        private delegate void LineaRecibidaEvent(string line);

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtBaudRate.Text = "9600";
            txtPuerto.Text = "COM4";
            txtLog.Text = "";
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            btnIniciar.Enabled = false;
            iniciarArduino(txtPuerto.Text,Convert.ToInt32(txtBaudRate.Text));

        }

        private void iniciarArduino(string nombrePuerto, int baudRate)
        {
            puerto = new SerialPort();
            puerto.PortName = nombrePuerto;  //sustituir por vuestro 
            puerto.BaudRate = baudRate;
            puerto.Open();

            puerto.DataReceived += Puerto_DataReceived;
        }

        private void Puerto_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string line = puerto.ReadLine();
            this.BeginInvoke(new LineaRecibidaEvent(onLineaRecibida), line);
        }

        private void onLineaRecibida(string line)
        {
            string[] values = line.Split(',');
            int x = Int32.Parse(values[0]);
            int y = Int32.Parse(values[1]);
            bool press = values[2] == "0";

            txtLog.Text += $"x: {x} | y: {y} | Botón presionado: {press}{Environment.NewLine}";

            txtLog.Text += "x:" + x + " | y: " + y + " | Botón presionado: " + press + " + Environment.NewLine;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (puerto.IsOpen) puerto.Close();
        }
    }
}
