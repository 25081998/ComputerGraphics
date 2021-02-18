using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CGLabPlatform;

namespace Lab_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var gdiDevice = new GDIDevice();
            gdiDevice.Dock = DockStyle.Fill;
            gdiDevice.BackColor = Color.LightSteelBlue;
            this.panel1.Controls.Add(gdiDevice);
            gdiDevice.DeviceUpdate += GdiDevice_DeviceUpdate;

        }

        private void GdiDevice_DeviceUpdate(object sender, GDIDeviceUpdateArgs e)
        {
            e.Surface.DrawLine(9, 0, 0, 200, 300);
        }
    }
}
