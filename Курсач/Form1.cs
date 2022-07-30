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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=СЕРГЕЙ-ПК;Initial Catalog=rzd;Integrated Security=True");
        
        private void Form1_Load(object sender, EventArgs e)
        {
            con.Open();
            string cmd = "SELECT * FROM Station";
            SqlDataAdapter adapter = new SqlDataAdapter(cmd, con);
            DataSet db = new DataSet();
            adapter.Fill(db, "Станции");
            dataGridView1.DataSource = db.Tables["Станции"].DefaultView;
            con.Close();
            dataGridView1.Columns[0].HeaderText = "Станция";
            dataGridView1.Columns[1].HeaderText = "Участок";
            dataGridView1.Columns[2].HeaderText = "Коордиаты";
        }

        private void Add_Click(object sender, EventArgs e)
        {
            AddStation add = new AddStation();
            this.Hide();
            add.Show();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            string station, line, coordinates;
            station = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            line = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            coordinates = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            EditStation editStation = new EditStation(station, line, coordinates);
            editStation.Show();
            this.Hide();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string station = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = $"DELETE FROM Station WHERE Станция = N'{station}'";
            cmd.ExecuteNonQuery();
            con.Close();
            this.Close();
            Form1 StartForm = new Form1();
            StartForm.Show();
        }

        private void Open_Click(object sender, EventArgs e)
        {
            Sensors StartSensors = new Sensors();
            StartSensors.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = string.Format("CONVERT("+dataGridView1.Columns[0].DataPropertyName+",System.String) like '%"+textBox1.Text.Replace("'","''")+"%'");
            dataGridView1.DataSource = bs;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = string.Format("CONVERT(" + dataGridView1.Columns[1].DataPropertyName + ",System.String) like '%" + textBox2.Text.Replace("'", "''") + "%'");
            dataGridView1.DataSource = bs;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = string.Format("CONVERT(" + dataGridView1.Columns[2].DataPropertyName + ",System.String) like '%" + textBox3.Text.Replace("'", "''") + "%'");
            dataGridView1.DataSource = bs;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            General general = new General();
            general.Show();
            this.Hide();
        }
    }
}
