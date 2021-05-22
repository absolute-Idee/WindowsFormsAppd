using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WinFormsForDataBase_URBAEV
{
    public partial class AddProductForm : Form
    {
        public AddProductForm()
        {
            InitializeComponent();
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            int id_in_order = Convert.ToInt32(id_in_orderTextBox.Text);
            string name = nameTextBox.Text;
            int amount = Convert.ToInt32(amountTextBox.Text);
            int price = Convert.ToInt32(priceTextBox.Text);
            int total_price = Convert.ToInt32(total_priceTextBox.Text);

            MessageBox.Show("Getting Connection ...");
            MySqlConnection conn = DBUtils.GetDBConnection();

            conn.Open();
            MessageBox.Show("Connection successful!");

            string command = "INSERT INTO product(id_in_order, name, amount, price, total_price) VALUES(@id, @name, @amount, @price, @total_price)";
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = command;

            cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = id_in_order;
            cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
            cmd.Parameters.Add("@amount", MySqlDbType.Int32).Value = amount;
            cmd.Parameters.Add("@price", MySqlDbType.Int32).Value = price;
            cmd.Parameters.Add("@total_price", MySqlDbType.Int32).Value = total_price;

            cmd.ExecuteNonQuery();

            conn.Clone();
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            int id_in_order = Convert.ToInt32(id_in_orderTextBox.Text);
            string name = nameTextBox.Text;

            if (id_in_order == 0 || name == null)
            {
                MessageBox.Show("Input ID and Name");
            }
            MessageBox.Show("Getting Connection ...");
            MySqlConnection conn = DBUtils.GetDBConnection();

            conn.Open();
            MessageBox.Show("Connection successful!");

            string command = "DELETE FROM product WHERE id_in_order = @id AND name = @name";

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = command;
            cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = id_in_order;
            cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        private void Show_button_Click(object sender, EventArgs e)
        {
            ProductTableForm table = new ProductTableForm();
            table.ShowDialog();
        }
    }
}
