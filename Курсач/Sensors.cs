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
    public partial class Sensors : Form
    {
        public Sensors()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=СЕРГЕЙ-ПК;Initial Catalog=rzd;Integrated Security=True");
        private void Sensors_Load(object sender, EventArgs e)
        {
            con.Open();
            string cmd = "SELECT * FROM Sensors";
            SqlDataAdapter adapter = new SqlDataAdapter(cmd, con);
            DataSet db = new DataSet();
            adapter.Fill(db, "Датчики");
            dataGridView1.DataSource = db.Tables["Датчики"].DefaultView;
            con.Close();
            dataGridView1.Columns[0].HeaderText = "Серийный номер";
            dataGridView1.Columns[1].HeaderText = "Назначение";
            dataGridView1.Columns[2].HeaderText = "Тип";
            dataGridView1.Columns[3].HeaderText = "Вольтаж";
            dataGridView1.Columns[4].HeaderText = "Станция";
        }

        private void Create_Click(object sender, EventArgs e)
        {
            CreateSensor create = new CreateSensor();
            this.Hide();
            create.Show();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            string serial, purpose, type, volt, station;
            serial = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            purpose = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            type = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            volt = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            station = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            EditSensors editsensors = new EditSensors(serial, purpose, type, volt, station);
            editsensors.Show();
            this.Hide();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string serial = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = $"DELETE FROM Sensors WHERE [Серийный номер] = N'{serial}'";
            cmd.ExecuteNonQuery();
            con.Close();
            this.Close();
            Sensors StartSensors = new Sensors();
            StartSensors.Show();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Form1 StartForm = new Form1();
            StartForm.Show();
            this.Hide(); 
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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = string.Format("CONVERT(" + dataGridView1.Columns[3].DataPropertyName + ",System.String) like '%" + textBox4.Text.Replace("'", "''") + "%'");
            dataGridView1.DataSource = bs;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = string.Format("CONVERT(" + dataGridView1.Columns[4].DataPropertyName + ",System.String) like '%" + textBox5.Text.Replace("'", "''") + "%'");
            dataGridView1.DataSource = bs;
        }
    }
}
