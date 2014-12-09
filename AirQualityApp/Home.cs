using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SnmpSharpNet;


namespace AirQualityApp
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        public void setUp() { }

        public void showData() {

            Dictionary<String, String> data = SnmpUtil.getData();

            lblCurrentDateTime.Text = data["CurrentDateTime"];
            lblComputerName.Text = data["ComputerName"];
            lblUpTime.Text = data["SystemUpTime"];
        }

        private void btnMeasure_Click(object sender, EventArgs e)
        {
            showData();
        }
    }
}
