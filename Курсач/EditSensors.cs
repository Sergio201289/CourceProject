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
    public partial class EditSensors : Form
    {
        public EditSensors(string serial, string purpose, string type, string volt, string station)
        {
            InitializeComponent();
            Serial.Text = serial;
            Purpose.Text = purpose;
            Type.Text = type;
            Volt.Text = volt;
            Station.Text = station;
        }
        SqlConnection con = new SqlConnection(@"Data Source=СЕРГЕЙ-ПК;Initial Catalog=rzd;Integrated Security=True");

        private void Сохранить_Click(object sender, EventArgs e)
        {
            string serial = Serial.Text;
            string purpose = Purpose.Text;
            string type = Type.Text;
            string volt = Volt.Text;
            string station = Station.Text;
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = $"UPDATE Sensors SET [Серийный номер] = N'{serial}', Назначение = N'{purpose}', Тип = N'{type}', Вольтаж = N'{volt}', Станция = N'{station}'WHERE [Серийный номер] = N'{serial}'";
            cmd.ExecuteNonQuery();
            con.Close();
            Sensors StartSensors = new Sensors();
            StartSensors.Show();
            this.Close();
        }
    }
}
