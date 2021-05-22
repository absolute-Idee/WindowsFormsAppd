using MySql.Data.MySqlClient;
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


namespace WinFormsForDataBase_URBAEV
{
    public partial class AddOrderForm : Form
    {
        public AddOrderForm()
        {
            InitializeComponent();
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            int doc_num = Convert.ToInt32(textBox1.Text);
            string date = textBox2.Text;
            int contract = Convert.ToInt32(textBox3.Text);
            string provider = textBox4.Text;
            string place = textBox5.Text;

            MessageBox.Show("Getting Connection ...");
            MySqlConnection conn = DBUtils.GetDBConnection();

            conn.Open();
            MessageBox.Show("Connection successful!");

            string command = "INSERT INTO orders(order_id, date, contract_num, provider, place) VALUES(@id, @date, @contract, @provider, @place)";
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = command;

            cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = doc_num;
            cmd.Parameters.Add("@date", MySqlDbType.VarChar).Value = date;
            cmd.Parameters.Add("@contract", MySqlDbType.Int32).Value = contract;
            cmd.Parameters.Add("@provider", MySqlDbType.VarChar).Value = provider;
            cmd.Parameters.Add("@place", MySqlDbType.VarChar).Value = place;

            cmd.ExecuteNonQuery();

            conn.Clone();
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            int doc_num = Convert.ToInt32(textBox1.Text);
            int contract = Convert.ToInt32(textBox3.Text);
            

            if (doc_num == 0 || contract == null)
            {
                MessageBox.Show("Input Document number and Contract number");
            }
            MessageBox.Show("Getting Connection ...");
            MySqlConnection conn = DBUtils.GetDBConnection();

            conn.Open();
            MessageBox.Show("Connection successful!");

            string command = "DELETE FROM orders WHERE order_id = @id AND contract_num = @contract_num";

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = command;
            cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = doc_num;
            cmd.Parameters.Add("@contract_num", MySqlDbType.VarChar).Value = contract;
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        private void Show_button_Click(object sender, EventArgs e)
        {
            OrderTableForm table = new OrderTableForm();
            table.ShowDialog();

        }
    }
}
