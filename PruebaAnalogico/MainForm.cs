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
        private Posicion posicionActual;
        private bool botonPresionado;

        public MainForm()
        {
            InitializeComponent();
        }

        private Posicion determinarPosicion(Estado estado)
        {
            // Izquierda
            if (estado.X > 700)
            {
                if (estado.Y < 300) return Posicion.AbajoIzquierda;
                if (estado.Y > 700) return Posicion.ArribaIzquierda;
                return Posicion.Izquierda;
            }
            // Derecha
            if (estado.X < 300)
            {
                if (estado.Y < 300) return Posicion.AbajoDerecha;
                if (estado.Y > 700) return Posicion.ArribaDerecha;
                return Posicion.Derecha;
            }

            if (estado.Y < 300) return Posicion.Abajo;
            if (estado.Y > 700) return Posicion.Arriba;

            return Posicion.Centro;
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
            iniciarArduino(txtPuerto.Text, Convert.ToInt32(txtBaudRate.Text));

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
            Estado estado = new Estado(Int32.Parse(values[0]), Int32.Parse(values[1]), values[2] == "0");

            Posicion nuevaPosicion = determinarPosicion(estado);

            if (posicionActual != nuevaPosicion)
            {
                posicionActual = nuevaPosicion;
                txtLog.Text = $"{toString(posicionActual)}{Environment.NewLine}{txtLog.Text}";
            }

            if(botonPresionado != estado.BotonPresionado)
            {
                botonPresionado = estado.BotonPresionado;
                if (estado.BotonPresionado)
                {
                    txtLog.Text = $"Se presionó el botón {Environment.NewLine}{txtLog.Text}";
                }
                else
                {
                    txtLog.Text = $"Se soltó el botón {Environment.NewLine}{txtLog.Text}";
                }
            }


        }
        private string toString(Posicion posicion)
        {
            switch (posicion)
            {
                case Posicion.Abajo:
                    return "Abajo";
                case Posicion.AbajoDerecha:
                    return "Abajo Derecha";
                case Posicion.AbajoIzquierda:
                    return "Abajo Izquierda";
                case Posicion.Arriba:
                    return "Arriba";
                case Posicion.ArribaDerecha:
                    return "Arriba Derecha";
                case Posicion.ArribaIzquierda:
                    return "Arriba Izquierda";
                case Posicion.Centro:
                    return "Centro";
                case Posicion.Derecha:
                    return "Derecha";
                case Posicion.Izquierda:
                    return "Izquierda";
            }
            return "No nonono";
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (puerto.IsOpen) puerto.Close();
        }
    }
}
