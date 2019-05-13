using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class AddTkani : Form
    {
        String filename;
        SqlConnection connection = new SqlConnection(Properties.Settings.Default.dbConnectionSettings);

        public AddTkani()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { 

//kjbjhjhjh
            openFileDialog1.Filter = "JPEG images|*.jpg";
            openFileDialog1.InitialDirectory = "C:\\Users\\lickett2019\\Downloads";
            openFileDialog1.Title = "??????? ????????";
            if(openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                filename = openFileDialog1.FileName;
               // MessageBox.Show(filename);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            connection.Open();
            try
            {
                SqlCommand command = new SqlCommand("INSERT INTO tkani (????????,???????) VALUES (@name,'"+filename+"')", connection);
                command.Parameters.AddWithValue("@name", textBox1.Text);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("????? ??????? ?????????!\n");
            }
            catch
            {
                MessageBox.Show("?????? ??? ?????????? ?????!\n");

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
