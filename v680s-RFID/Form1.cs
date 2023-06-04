using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace v680s_RFID
{
    public partial class Form1 : Form
    {
        public EasyModbus.ModbusClient modbusCliente = new EasyModbus.ModbusClient();

        private bool datosLectura = false;

        public Form1()
        {
            InitializeComponent();

            botonDesconectar.Enabled = false;

            IP_LABEL.Text = "192.168.1.200";
            PORT_LABEL.Text = "502";

            leer.Enabled = false;
            escribir.Enabled = false;

            textBox.ReadOnly = true;

            modbusCliente.UnitIdentifier = 255;
            modbusCliente.ConnectedChanged += new EasyModbus.ModbusClient.ConnectedChangedHandler(UpdateConnectedChanged);
            modbusCliente.SendDataChanged += new EasyModbus.ModbusClient.SendDataChangedHandler(UpdateSendDataChanged);
            modbusCliente.ReceiveDataChanged += new EasyModbus.ModbusClient.ReceiveDataChangedHandler(UpdateReceiveDataChanged);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void botonConectar_Click(object sender, EventArgs e)
        {
            if (modbusCliente.Connected == false)
            {
                modbusCliente.IPAddress = IP_LABEL.Text;
                modbusCliente.Port = Convert.ToInt32(PORT_LABEL.Text);

                try { modbusCliente.Connect(); } catch(Exception exception) {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void botonDesconectar_Click(object sender, EventArgs e)
        {
            if (modbusCliente.Connected == true)
            {
                modbusCliente.Disconnect();

                IP_LABEL.ReadOnly = false;
                PORT_LABEL.ReadOnly = false;
            }
        }

        void UpdateConnectedChanged(object sender)
        {
            if (modbusCliente.Connected == true)
            {
                IP_LABEL.ReadOnly = true;
                PORT_LABEL.ReadOnly = true;

                botonConectar.Enabled = false;
                botonDesconectar.Enabled = true;

                leer.Enabled = true;
                escribir.Enabled = true;

                Estado.Text = "Conectado";
                Estado.ForeColor = Color.Green;
            } else
            {
                IP_LABEL.ReadOnly = false;
                PORT_LABEL.ReadOnly = false;

                botonConectar.Enabled = true;
                botonDesconectar.Enabled = false;

                leer.Enabled = false;
                escribir.Enabled = false;

                Estado.Text = "Desconectado";
                Estado.ForeColor = Color.Red;
            }
        }

        void UpdateReceiveDataChanged(object sender)
        {
            if (modbusCliente.receiveData == null) return;
            
            string responde = BitConverter.ToString(modbusCliente.receiveData);
            
            textBox.AppendText($"Rx: {BitConverter.ToString(modbusCliente.receiveData).Replace("-", " ")}");

            if (datosLectura)
            {
                datosLectura = false;

                string payload = responde.Substring(27);
                byte[] data = FromHex(payload);
                string payloadString = Encoding.ASCII.GetString(data);

                textBox.AppendText(Environment.NewLine);
                textBox.AppendText($"Rx payload (Hex): {payload}");
                textBox.AppendText(Environment.NewLine);
                textBox.AppendText($"Rx payload (ASCII): {payloadString}");
            }

            textBox.AppendText(Environment.NewLine);
        }

        void UpdateSendDataChanged(object sender)
        {
            if (modbusCliente.sendData == null) return;

            textBox.Text = String.Empty;

            textBox.AppendText($"Tx: {BitConverter.ToString(modbusCliente.sendData).Replace("-", " ")}");
            textBox.AppendText(Environment.NewLine);
        }

        private void leer_Click(object sender, EventArgs e)
        {
            int inicio = Convert.ToInt32(INICIO_LEER.Text);
            int cantidad = Convert.ToInt32(CANTIDAD_LEER.Text);

            if(cantidad > 123)
            {
                cantidad = 123;
                CANTIDAD_LEER.Text = "123";
            }

            datosLectura = true;

            modbusCliente.ReadHoldingRegisters(inicio, cantidad);
        }

        private static byte[] FromHex(string hex)
        {
            hex = hex.Replace("-", "");
            byte[] raw = new byte[hex.Length / 2];
            for (int i = 0; i < raw.Length; i++)
            {
                raw[i] = Convert.ToByte(hex.Substring(i * 2, 2), 16);
            }
            return raw;
        }

        private void escribir_Click(object sender, EventArgs e)
        {
            int inicio = Convert.ToInt32(INICIO_ESCRIBIR.Text);
            string informacion = INFORMACION.Text;

            if (informacion.Length == 0) return;

            byte[] ba = Encoding.Default.GetBytes(INFORMACION.Text);
            string hexString = BitConverter.ToString(ba).Replace("-", "");
            IEnumerable<string> hexChunks = Split(hexString, 4);

            List<int> list = new List<int>();

            foreach (string chunk in hexChunks) {
                list.Add(Convert.ToInt32(chunk, 16));
            }

            modbusCliente.WriteMultipleRegisters(inicio, list.ToArray());
        }

        static IEnumerable<string> Split(string str, int chunkSize)
        {
            return Enumerable.Range(0, str.Length / chunkSize)
                .Select(i => str.Substring(i * chunkSize, chunkSize));
        }
    }
}
