using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсач
{
    public partial class General : Form
    {
        public General()
        {
            InitializeComponent();
        }

        private void Станции_Click(object sender, EventArgs e)
        {
            Form1 station = new Form1();
            station.Show();
            this.Hide();
        }

        private void sensor_Click(object sender, EventArgs e)
        {
            Sensors sensors = new Sensors();
            sensors.Show();
            this.Hide();
        }
    }
}
