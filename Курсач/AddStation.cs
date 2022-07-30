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
    public partial class AddStation : Form
    {
        public AddStation()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=СЕРГЕЙ-ПК;Initial Catalog=rzd;Integrated Security=True");

        private void Add_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            string station = Station.Text;
            string line = Line.Text;
            string coordinates = Coordinates.Text;
            cmd.CommandText = $"INSERT INTO Station (Станция, Участок, Координаты) VALUES (N'{station}', N'{line}', N'{coordinates}')";
            cmd.ExecuteNonQuery();
            con.Close();
            Form1 StartForm = new Form1();
            StartForm.Show();
            this.Close();
        }
    }
}
