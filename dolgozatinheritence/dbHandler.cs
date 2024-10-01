using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace dolgozatinheritence
{
    
    class dbHandler
    {
        MySqlConnection connection;
        public dbHandler() {
            string server = "localhost";
            string database = "dolgozat2";
            string username = "root";
            string password = "";
            string connectionString = $"server={server};database={database};user={username};password={password}";
            connection = new MySqlConnection(connectionString);
        }
        public List<bakeryproduct> readAllData() {
            List<bakeryproduct> products = new List<bakeryproduct>();
            try
            {
                connection.Open();
                string query = "select * from products";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader read = command.ExecuteReader();
                while (read.Read())
                {
                    string username = read.GetString(read.GetOrdinal("productname"));
                    int quantity = read.GetInt32(read.GetOrdinal("quantity"));
                    int price = read.GetInt32(read.GetOrdinal("price"));
                    bakeryproduct product = new bakeryproduct(username, quantity, price);
                    products.Add(product);
                }
                read.Close();
                command.Dispose();
                connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
                throw;
            }
            return products;
        }
        public void registerProduct(bakeryproduct product)
        {
            try
            {
                connection.Open();
                string query = $"insert into products (productname,quantity,price) values ('{product.productname}','{product.quantity}','{product.price}')";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                command.Dispose();
                connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void deleteProduct(bakeryproduct product)
        {
            try
            {
               
                connection.Open();
                string query = $"Delete from products WHERE productname = '{product.productname}'";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                command.Dispose();
                connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        /*public void updateProduct(bakeryproduct user)
        {
            try
            {
                connection.Open();
                string query = $"UPDATE users SET points = '{user.id}' WHERE email = '{user.email}'";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                command.Dispose();
                connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }*/

    }
    class bakeryproduct {
        public string productname;
        public int quantity;
        public int price;
        public bakeryproduct(string ProductName, int Quantity, int Price) {
            productname = ProductName;
            quantity = Quantity;
            price = Price;
        }
    }
}
