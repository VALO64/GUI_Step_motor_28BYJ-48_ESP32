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
            btnRUN.Click += btnRUN_Click;
            btnSTOP.Click += btnSTOP_Click;
            btnCLOCKWISE.Click += btnCLOCKWISE_Click; // Agregar evento Click para btnCLOCKWISE
            btnCOUNTERCLOCKWISE.Click += btnCOUNTERCLOCKWISE_Click; // Agregar evento Click para btnCOUNTERCLOCKWISE
            trackBarRPM.Scroll += trackBarRPM_Scroll; // Agregar evento Scroll para trackBarRPM
        }

        private void ConfiguracionInicial()
        {
            // Inicializar SerialPort
            serialPort = new SerialPort();
            serialPort.DataReceived += SerialPort_DataReceived; // Agregar evento para recibir datos

            // Configurar ComboBox de puertos COM
            CargarPuertosDisponibles();

            // Configurar ComboBox de velocidades
            CargarVelocidadesBaud();

            // Configurar estado inicial de los botones
            Desconectar.Enabled = false;

            // Configurar estado inicial de las imágenes
            imagenon.Visible = false;
            imagenoff.Visible = false;
            imagenhorario.Visible = false; // Ocultar imagenhorario inicialmente
            imagenantihorario.Visible = false; // Ocultar imagenantihorario inicialmente
        }

        // Evento para recibir datos del puerto serie
        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string data = serialPort.ReadLine().Trim(); // Lee hasta el salto de línea

            if (data.StartsWith("VELAY:"))
            {
                string delayValue = data.Substring(6).Trim(); // Extrae el valor después de "VELAY:"
                int delayTime = int.Parse(delayValue);

                // Actualizar la CircularProgressBar en el hilo principal
                this.Invoke(new Action(() =>
                {
                    circularProgressBar1.Value = delayTime; // Actualiza la CircularProgressBar
                }));
            }
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

                    // Ocultar todas las imágenes al desconectar
                    imagenon.Visible = false;
                    imagenoff.Visible = false;
                    imagenhorario.Visible = false;
                    imagenantihorario.Visible = false;

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
                    serialPort.WriteLine("ON");
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
                    serialPort.WriteLine("OFF");
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

        private void btnCLOCKWISE_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort.IsOpen)
                {
                    serialPort.WriteLine("CLOCKWISE");
                    imagenhorario.Visible = true;
                    imagenantihorario.Visible = false;
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
                MessageBox.Show($"Error al enviar comando CLOCKWISE: {ex.Message}",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btnCOUNTERCLOCKWISE_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort.IsOpen)
                {
                    serialPort.WriteLine("COUNTERCLOCKWISE");
                    imagenantihorario.Visible = true;
                    imagenhorario.Visible = false;
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
                MessageBox.Show($"Error al enviar comando COUNTERCLOCKWISE: {ex.Message}",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void trackBarRPM_Scroll(object sender, EventArgs e)
        {
            try
            {
                if (serialPort.IsOpen)
                {
                    int valor = trackBarRPM.Value;
                    serialPort.WriteLine($"DELAY {valor}");
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
                MessageBox.Show($"Error al enviar comando DELAY: {ex.Message}",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btn45_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort.IsOpen)
                {
                    serialPort.WriteLine("MOVE 7");
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
                MessageBox.Show($"Error al enviar comando MOVE: {ex.Message}",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btn90_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort.IsOpen)
                {
                    serialPort.WriteLine("MOVE 13");
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
                MessageBox.Show($"Error al enviar comando MOVE: {ex.Message}",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btn180_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort.IsOpen)
                {
                    serialPort.WriteLine("MOVE 25");
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
                MessageBox.Show($"Error al enviar comando MOVE: {ex.Message}",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btn360_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort.IsOpen)
                {
                    serialPort.WriteLine("MOVE 47");
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
                MessageBox.Show($"Error al enviar comando MOVE: {ex.Message}",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort.IsOpen)
                {
                    serialPort.WriteLine("MOVE -7");
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
                MessageBox.Show($"Error al enviar comando MOVE: {ex.Message}",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort.IsOpen)
                {
                    serialPort.WriteLine("MOVE -13");
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
                MessageBox.Show($"Error al enviar comando MOVE: {ex.Message}",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btnmenos180_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort.IsOpen)
                {
                    serialPort.WriteLine("MOVE -23");
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
                MessageBox.Show($"Error al enviar comando MOVE: {ex.Message}",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btnmenos360_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort.IsOpen)
                {
                    serialPort.WriteLine("MOVE -47");
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
                MessageBox.Show($"Error al enviar comando MOVE: {ex.Message}",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
    }
}
