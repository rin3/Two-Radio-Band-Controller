using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace ZUYmaster
{
    public partial class frmSetup : Form
    {
        // Constants
        static readonly int[] COM_SPEED = { 300, 1200, 4800, 9600, 19200, 38400, 57600, 115200 };

        // Parameters of serial communication
        private byte bLExcParam;
        private byte bRExcParam;
        private byte bLAmpParam;
        private byte bRAmpParam;

        // Variables
        static bool boolLoaded = false;
        static bool boolChanged = false;

        // Constructor
        public frmSetup()
        {
            InitializeComponent();

            // set label color
            lblConStatus.ForeColor = Color.LightGray;
            
            // list COM ports
            foreach (string s in SerialPort.GetPortNames())
            {
                cbCOMPort.Items.Add(s);
            }

            // bulk event handlers for the detection of parameter changes
            rbLKenwood.CheckedChanged += new EventHandler(paramChanged);
            //rbLICOM.CheckedChanged += new EventHandler(paramChanged);
            rbRKenwood.CheckedChanged += new EventHandler(paramChanged);
            //rbRICOM.CheckedChanged += new EventHandler(paramChanged);
            cbZUYHex.TextChanged += new EventHandler(paramChanged);
            cbLExcHex.TextChanged += new EventHandler(paramChanged);
            cbRExcHex.TextChanged += new EventHandler(paramChanged);
            cbLAmpHex.TextChanged += new EventHandler(paramChanged);
            cbRAmpHex.TextChanged += new EventHandler(paramChanged);
            cbLExcSpeed.SelectedIndexChanged += new EventHandler(paramChanged);
            cbRExcSpeed.SelectedIndexChanged += new EventHandler(paramChanged);
            cbLAmpSpeed.SelectedIndexChanged += new EventHandler(paramChanged);
            cbRAmpSpeed.SelectedIndexChanged += new EventHandler(paramChanged);
            // detectino of change in serial communication parameters not implemented yet

            // text message
            txtMsgs.AppendText("Choose COM Port for Arduino Mega then press 'Connect'.\n");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbCOMPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.PortName = cbCOMPort.Text;
                    serialPort1.BaudRate = 38400;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                string strBuf;
                try
                {
                    // open serial port
                    serialPort1.Open();

                    // send a message to ZUYmaster
                    serialPort1.Write("ZUYdeVGX\0");    // send as null-terminated string
                    txtMsgs.AppendText("Connecting to Arduino Mega ... ");

                    // wait until reply
                    System.Threading.Thread.Sleep(100);

                    // check a reply
                    if (serialPort1.BytesToRead > 0)
                    {
                        strBuf = serialPort1.ReadLine();

                        // check token
                        if (strBuf.Substring(0, 9) == "ZUYmaster")
                        {
                            // token confirmed
                            txtMsgs.AppendText("success!\n");
                            txtMsgs.AppendText("Connected to ZUYmaster ver." + strBuf.Substring(9, 3) + ".\n");

                            // load current settings
                            updateFields(strBuf.Substring(12));
                            boolLoaded = true;
                            txtMsgs.AppendText("Current settings have been loaded.\n");

                            // turn the label to CONNECTED
                            lblConStatus.Text = "CONNECTED";
                            lblConStatus.ForeColor = Color.Blue;
                            lblConStatus.Refresh();

                            // message
                            txtMsgs.AppendText("Change items to your liking then press 'Save' to send them back to ZUYmaster.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                // parameter array
                byte[] bParam = new byte[15];

                // update parameters from fields
                updateParam(bParam);

                // send to ZUYmaster

                // message
                boolChanged = false;
                lblSaveStatus.Visible = true;
            }
        }

        // load current settings
        private void updateFields(string str)
        {
            // make of the radios
            if (str[0] == 0)
            {
                rbLKenwood.Checked = true;
            }
            else
            {
                rbLICOM.Checked = true;
            }
            if (str[1] == 0)
            {
                rbRKenwood.Checked = true;
            }
            else
            {
                rbRICOM.Checked = true;
            }

            // CI-V Hex codes
            cbZUYHex.Text = Convert.ToString(str[2], 16).ToUpper();
            cbLExcHex.Text = Convert.ToString(str[3], 16).ToUpper();
            cbRExcHex.Text = Convert.ToString(str[4], 16).ToUpper();
            cbLAmpHex.Text = Convert.ToString(str[5], 16).ToUpper();
            cbRAmpHex.Text = Convert.ToString(str[6], 16).ToUpper();

            // Speed of serial communication
            cbLExcSpeed.Text = COM_SPEED[(int)str[7]].ToString();
            cbRExcSpeed.Text = COM_SPEED[(int)str[8]].ToString();
            cbLAmpSpeed.Text = COM_SPEED[(int)str[9]].ToString();
            cbRAmpSpeed.Text = COM_SPEED[(int)str[10]].ToString();

            // Parameters of serial communication
            bLExcParam = (byte)str[11];
            bRExcParam = (byte)str[12];
            bLAmpParam = (byte)str[13];
            bRAmpParam = (byte)str[14];

            boolChanged = false;
        }

        // update parameters from fields into parameter array
        private void updateParam(byte[] bBuf)
        {
            // make of the radios
            if (rbLKenwood.Checked)
            {
                bBuf[0] = 0;
            }
            else
            {
                bBuf[0] = 1;
            }

            if (rbRKenwood.Checked)
            {
                bBuf[1] = 0;
            }
            else
            {
                bBuf[1] = 1;
            }

            // CI-V Hex codes
            bBuf[2] = Convert.ToByte(cbZUYHex.Text, 16);
            bBuf[3] = Convert.ToByte(cbLExcHex.Text, 16);
            bBuf[4] = Convert.ToByte(cbRExcHex.Text, 16);
            bBuf[5] = Convert.ToByte(cbLAmpHex.Text, 16);
            bBuf[6] = Convert.ToByte(cbRAmpHex.Text, 16);

            // Speed of serial communication
            bBuf[7] = (byte)cbLExcSpeed.SelectedIndex;
            bBuf[8] = (byte)cbRExcSpeed.SelectedIndex;
            bBuf[9] = (byte)cbLAmpSpeed.SelectedIndex;
            bBuf[10] = (byte)cbRAmpSpeed.SelectedIndex;

            // Parameters of serial communication
            bBuf[11] = bLExcParam;
            bBuf[12] = bRExcParam;
            bBuf[13] = bLAmpParam;
            bBuf[14] = bRAmpParam;
        }

        private void paramChanged(object sender, EventArgs e)
        {
            boolChanged = true;
            lblSaveStatus.Visible = false;
        }

        private void rbLICOM_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLICOM.Checked)
            {
                cbLExcHex.Visible = true;
            }
            else
            {
                cbLExcHex.Visible = false;
            }
        }

        private void rbRICOM_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRICOM.Checked)
            {
                cbRExcHex.Visible = true;
            }
            else
            {
                cbRExcHex.Visible = false;
            }
        }

        private void frmSetup_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (boolChanged == true)
            {
                DialogResult result = MessageBox.Show("Settings have not been saved.  Are you sure to quit?", "Oops!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }

            if (e.Cancel == false)
            {
                // close serial port
                serialPort1.Close();
                lblConStatus.Text = "DISCONNECTED";
                lblConStatus.ForeColor = Color.LightGray;
            }
        }
    }
}
