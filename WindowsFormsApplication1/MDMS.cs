using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using BO;

namespace WindowsFormsApplication1
{
    public partial class MDMS : Form
    {
        public MDMS()
        {
            InitializeComponent();
            Rating_textBox1.PasswordChar = '*';
        }

        Operation op = new Operation();
        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Category_comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Sell_Price_textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Buy_Price_textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Quantity_textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void ID_textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Save_button1_Click(object sender, EventArgs e)
        {
            try
            {
                string title = title_textBox1.Text;
                string director =director_textBox2.Text;
                string producer = producer_textBox3.Text;
                string p_house = p_h_textBox4.Text;
                string actress = actress_textBox5.Text;
                string type = type_comboBox1.Text;
                string release_date = dateTimePicker1.Text;
                string year = year_comboBox2.Text;
                string length = length_textBox1.Text;
                string format = format_comboBox3.Text;
                string size = size_textBox2.Text;
                string rating = Rating_textBox1.Text;

                String query = "INSERT INTO movies(Title,Director,Producer,Production_House,Actress,Type,Release_Date,Year,Length,Format,Size,Rating) VALUES('" + title + "','" + director + "','" + producer + "','" + p_house + "','" + actress + "','" + type + "','" + release_date + "','" + year + "','" + length + "','" + format + "','" + size + "','" + rating + "')";

                op.SaveInformation(query);

                title_textBox1.Text = "";
                director_textBox2.Text = "";
                producer_textBox3.Text = "";
                p_h_textBox4.Text = "";
                actress_textBox5.Text = "";
                type_comboBox1.Text = "";
                dateTimePicker1.Text = "";
                year_comboBox2.Text = "";
                length_textBox1.Text = "";
                format_comboBox3.Text = "";
                size_textBox2.Text = "";
                Rating_textBox1.Text = "";
                Load_Table1(dataGridView1);
                /*op.Load_Table1(dataGridView4);

                ID_textBox1.Text = "";
                Name_textBox2.Text = "";
                Description_textBox3.Text = "";
                Catagory_comboBox1.Text = "";
                Quantity_textBox4.Text = "";
                Buy_Price_textBox5.Text = "";
                Sell_Price_textBox6.Text = "";*/
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Load_Table1(DataGridView dv)
        {
            string query = "SELECT * FROM movies";
            SqlConnection Conn = op.create_connection();
            SqlCommand cmd = new SqlCommand(query, Conn);
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dataset = new DataTable();
                sda.Fill(dataset);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = dataset;
                dv.DataSource = bSource;
                sda.Update(dataset);

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Cancel_button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
