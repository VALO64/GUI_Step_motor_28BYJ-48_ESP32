using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace GUI_Step_motor_ESP32
{
    public partial class Form1 : Form
    {
        private SerialPort serialPort;

        public Form1()
        {
            InitializeComponent();
            ConfiguracionInicial();

            // Asegurar que los eventos de los botones estén enlazados
            btnON.Click += btnON_Click;
            btnOFF.Click += btnOFF_Click;
            btnRUN.Click += btnRUN_Click; // Agregar evento Click para btnRUN
            btnSTOP.Click += btnSTOP_Click; // Agregar evento Click para btnSTOP
        }

        private void ConfiguracionInicial()
        {
            // Inicializar SerialPort
            serialPort = new SerialPort();

            // Configurar ComboBox de puertos COM
            CargarPuertosDisponibles();

            // Configurar ComboBox de velocidades
            CargarVelocidadesBaud();

            // Configurar estado inicial de los botones
            Desconectar.Enabled = false;

            // Configurar estado inicial de las imágenes
            imagenon.Visible = false;
            imagenoff.Visible = false;
        }

        private void CargarPuertosDisponibles()
        {
            comshow.Items.Clear();
            string[] puertos = SerialPort.GetPortNames();
            if (puertos.Length > 0)
            {
                comshow.Items.AddRange(puertos);
                comshow.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("No se encontraron puertos COM disponibles",
                                "Advertencia",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }

        private void CargarVelocidadesBaud()
        {
            baudshow.Items.Clear();
            int[] velocidades = new int[] { 9600, 19200, 38400, 57600, 115200 };
            foreach (int velocidad in velocidades)
            {
                baudshow.Items.Add(velocidad);
            }
            baudshow.SelectedIndex = 0; // Selecciona 9600 por defecto
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Si necesitas agregar algo adicional al cargar el formulario
        }

        private void Conectar_Click(object sender, EventArgs e)
        {
            if (comshow.SelectedItem == null)
            {
                MessageBox.Show("Por favor seleccione un puerto COM",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (!serialPort.IsOpen)
                {
                    serialPort.PortName = comshow.SelectedItem.ToString();
                    serialPort.BaudRate = Convert.ToInt32(baudshow.SelectedItem);
                    serialPort.Open();

                    // Cambiar estado de los controles
                    Conectar.Enabled = false;
                    Desconectar.Enabled = true;
                    comshow.Enabled = false;
                    baudshow.Enabled = false;

                    MessageBox.Show("Conexión establecida correctamente",
                                    "Éxito",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en la conexión: {ex.Message}",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void Desconectar_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort.IsOpen)
                {
                    serialPort.Close();

                    // Restaurar estado de los controles
                    Conectar.Enabled = true;
                    Desconectar.Enabled = false;
                    comshow.Enabled = true;
                    baudshow.Enabled = true;

                    // Ocultar ambas imágenes al desconectar
                    imagenon.Visible = false;
                    imagenoff.Visible = false;

                    MessageBox.Show("Dispositivo desconectado correctamente",
                                    "Éxito",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al desconectar: {ex.Message}",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btnON_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort.IsOpen)
                {
                    // Enviar comando ON
                    serialPort.WriteLine("ON");

                    // Mostrar imagen de encendido y ocultar la de apagado
                    imagenon.Visible = true;
                    imagenoff.Visible = false;
                }
                else
                {
                    MessageBox.Show("El puerto serial no está abierto",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al enviar comando ON: {ex.Message}",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btnOFF_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort.IsOpen)
                {
                    // Enviar comando OFF
                    serialPort.WriteLine("OFF");

                    // Mostrar imagen de apagado y ocultar la de encendido
                    imagenoff.Visible = true;
                    imagenon.Visible = false;
                }
                else
                {
                    MessageBox.Show("El puerto serial no está abierto",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al enviar comando OFF: {ex.Message}",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btnRUN_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort.IsOpen)
                {
                    // Enviar comando RUN
                    serialPort.WriteLine("RUN");
                }
                else
                {
                    MessageBox.Show("El puerto serial no está abierto",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al enviar comando RUN: {ex.Message}",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btnSTOP_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort.IsOpen)
                {
                    // Enviar comando STOP
                    serialPort.WriteLine("STOP");
                }
                else
                {
                    MessageBox.Show("El puerto serial no está abierto",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al enviar comando STOP: {ex.Message}",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                serialPort.Close();
            }
            base.OnFormClosing(e);
        }
    }
}
