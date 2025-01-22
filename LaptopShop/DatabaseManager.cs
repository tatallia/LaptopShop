using LaptopShop.LaptopShopDataSetTableAdapters;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace LaptopShop.Forms
{
    internal class DatabaseManager
    {
        public static string ConnectionString = "Data Source=DESKTOP-J80OE19;Initial Catalog=LaptopShop;Integrated Security=True";
        public static int UserID;
        public static int ShopGuarantee = 1;

        public static void UpdateInfo()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string queryForSales = $"DELETE FROM Sales WHERE DATEDIFF(YEAR, date_, GETDATE()) > {ShopGuarantee}";
                string queryForLaptops = " DELETE FROM Laptops WHERE num_available = 0 AND laptop_id NOT IN (SELECT laptop_id FROM Checks)";
                string quaryForDisplays = " DELETE FROM Displays WHERE display_id NOT IN (SELECT display_id FROM Laptops)";

                using (SqlCommand command = new SqlCommand(queryForSales, connection))
                {
                    command.ExecuteNonQuery();
                }

                using (SqlCommand command = new SqlCommand(queryForLaptops, connection))
                {
                    command.ExecuteNonQuery();
                }

                using (SqlCommand command = new SqlCommand(quaryForDisplays, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public static object GetDataTable(string s)
        {
            try
            {
                SqlConnection sqlconn = new SqlConnection(ConnectionString);
                sqlconn.Open();
                SqlDataAdapter oda = new SqlDataAdapter(s, sqlconn);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                sqlconn.Close();
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);
                return null;
            }
        }
        public static string GetDiscount(double sum, int num_laptops, int bonuses, string email)
        {
            int n = (bonuses + num_laptops);
            int bonusBalance = n % 3;

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                
                string updateQuery = "UPDATE Clients SET Num_bonuses = @BonusBalance WHERE Email = @Email";

                using (SqlCommand cmd = new SqlCommand(updateQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@BonusBalance", bonusBalance);
                    cmd.Parameters.AddWithValue("@Email", email);

                    cmd.ExecuteNonQuery();
                }
            }

            return (sum - 0.3 * (sum / num_laptops) * (n - bonusBalance) / 3).ToString("0.00");
        }

        public static int GetNewSaleID(salesTableAdapter sales, string email)
        {
            using (SqlConnection connection = new SqlConnection(DatabaseManager.ConnectionString))
            {
                connection.Open();

                sales.InsertQuery(DateTime.Now, UserID, email);

                SqlCommand cmd = new SqlCommand("SELECT TOP 1 Sale_id FROM Sales ORDER BY date_ DESC", connection);
                return (int)cmd.ExecuteScalar();
            }
        }

        public static void SubtractLaptopQuantity(int laptopID, int quantitySold)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                int newQuantity = GetAvailableQuantityLaptops(laptopID) - quantitySold;

                string queryUpdate = $"UPDATE Laptops SET num_available = {newQuantity} WHERE laptop_id = {laptopID}";
                using (SqlCommand commandUpdate = new SqlCommand(queryUpdate, connection))
                {
                    commandUpdate.ExecuteNonQuery();
                }
                
            }
        }

        public static int GetAvailableQuantityLaptops(int laptopID)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string query = $"SELECT num_available FROM Laptops WHERE laptop_id = {laptopID}";
                using (SqlCommand commandSelect = new SqlCommand(query, connection))
                {
                    return (int)commandSelect.ExecuteScalar();
                }
            }
        }

        public static bool GetEntryPermission(string login, string password, bool admin)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string query;

                if (!admin)
                {
                    query = "SELECT worker_id FROM workers WHERE login = @Login AND password = @Password";
                }
                else
                {
                    query = "SELECT worker_id FROM workers WHERE login = @Login AND password = @Password AND admin = @Admin";
                }

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Login", login);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@Admin", admin);
                    try
                    {
                        int id = (int)command.ExecuteScalar();
                        UserID = Convert.ToInt32(id);
                        return true;
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                }
            }
        }
    }
}
