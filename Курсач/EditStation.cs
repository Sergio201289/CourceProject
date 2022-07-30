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
    public partial class EditStation : Form
    {
        public EditStation(string station, string line, string coordinates)
        {
            InitializeComponent();
            Station.Text = station;
            Line.Text = line;
            Coordinates.Text = coordinates;
        }
        SqlConnection con = new SqlConnection(@"Data Source=СЕРГЕЙ-ПК;Initial Catalog=rzd;Integrated Security=True");
        private void Edit_Click(object sender, EventArgs e)
        {
            string station = Station.Text;
            string line = Line.Text;
            string coordinates = Coordinates.Text;
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = $"UPDATE Station SET Станция = N'{station}', Участок = N'{line}', Координаты = N'{coordinates}' WHERE Станция = N'{station}'";
            cmd.ExecuteNonQuery();
            con.Close();
            Form1 StartForm = new Form1();
            StartForm.Show();
            this.Close();
        }
        
    }
}
