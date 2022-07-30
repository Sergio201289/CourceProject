using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Курсач
{
    public partial class CreateSensor : Form
    {
        public CreateSensor()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=СЕРГЕЙ-ПК;Initial Catalog=rzd;Integrated Security=True");

        private void Save_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            string serial = Serial.Text;
            string purpose = Purpose.Text;
            string type = Type.Text;
            string volt = Volt.Text;
            string station = Station.Text;
            cmd.CommandText = $"INSERT INTO Sensors ([Серийный номер], Назначение, Тип, Вольтаж, Станция) VALUES (N'{serial}', N'{purpose}', N'{type}', N'{volt}', N'{station}')";
            cmd.ExecuteNonQuery();
            con.Close();
            Sensors StartSensors = new Sensors();
            StartSensors.Show();
            this.Close();
        }
    }
}
