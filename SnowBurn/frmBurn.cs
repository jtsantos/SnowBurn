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
using System.IO;
using System.Diagnostics;

namespace SnowBurn
{
    public partial class frmBurn : Form
    {
        private string avrdudeDirectory;
        private string avrdudeConfigDirectory;
        private string hexFileName;

        public frmBurn()
        {
            InitializeComponent();

            avrdudeDirectory = "C:\\Program Files (x86)\\Arduino\\hardware\\tools\\avr\\bin\\";
            avrdudeConfigDirectory = "C:\\Program Files (x86)\\Arduino\\hardware\\tools\\avr\\etc\\avrdude.conf";
            hexFileName = "";

            ScanSerialPorts();
            LoadMCUModels();
        }

        private void ScanSerialPorts()
        {
            string errorMessage = "";

            try
            {
                foreach (string portName in SerialPort.GetPortNames())
                {
                    cboPortaSerial.Items.Add(portName);
                }
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }
        }

        private string CommandBuilder()
        {
            string portName = spBurn.PortName;
            string portBaud = spBurn.BaudRate.ToString();
            string mcuModel = cboModeloMCU.Text;
            string programmer = "stk500v1";
            mcuModel = mcuModel.ToLower();

            string commandString = "avrdude.exe -C \"" + avrdudeConfigDirectory + "\" -v " + " -p " + mcuModel + " -c " + programmer + " -P " + portName + " -b " + portBaud + " -U flash:w:\"" + hexFileName + "\":i ";

            return commandString;
        }

        private void LoadMCUModels()
        {
            cboModeloMCU.Items.Add("ATTiny80");
            cboModeloMCU.Items.Add("ATTiny85");
        }

        private void SelecionarHex_Click(object sender, EventArgs e)
        {
            ofdHexFile.InitialDirectory = "C:\\";
            ofdHexFile.FileName = "";
            ofdHexFile.Filter = "Hex Files (*.hex) | *.hex";

            if (ofdHexFile.ShowDialog() == DialogResult.OK)
            {
                txtHex.Text = ofdHexFile.FileName;
                hexFileName = ofdHexFile.FileName;
            }
        }

        private void Burn_Click(object sender, EventArgs e)
        {
            StreamReader avrdudeOut, avrdudeErr;
            StreamWriter avrdudeIn;
            string command = CommandBuilder();

            //"avrdude_diretorio -C avrdudeconf_diretorio -v -pattiny85 -cstk500v1 -PCOM3 -b19200 -Uflash:w:\hex_diretorio:i ";

            try
            {
                ProcessStartInfo procStartInfo = new ProcessStartInfo("cmd");
                procStartInfo.WorkingDirectory = avrdudeDirectory;
                procStartInfo.RedirectStandardOutput = true;
                procStartInfo.RedirectStandardInput = true;
                procStartInfo.RedirectStandardError = true;
                procStartInfo.UseShellExecute = false;
                procStartInfo.CreateNoWindow = true;

                Process procBurn = new Process();
                procBurn.StartInfo = procStartInfo;
                procBurn.Start();
                avrdudeIn = procBurn.StandardInput;
                avrdudeOut = procBurn.StandardOutput;
                avrdudeErr = procBurn.StandardError;
                avrdudeIn.AutoFlush = true;
                avrdudeIn.WriteLine(command);
                avrdudeIn.Close();
                procBurn.Close();

                string result = avrdudeOut.ReadToEnd();
                result += avrdudeErr.ReadToEnd();


                txtOutput.Text = result;
            }
            catch (Exception ex)
            {
                string mensagemErro = ex.Message;
                txtOutput.Text = mensagemErro;
            }
        }
    }
}
