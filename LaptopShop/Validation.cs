using LaptopShop.Forms;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaptopShop
{
    static internal class Validation
    {
        public static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);

                if (!ContainsAllowedCharacters(email))
                {
                    MessageBox.Show("Адреса електронної пошти може містити тільки латинські літери," +
                        " цифри та спеціальні символи (@, ., _, -).", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                return true;
            }
            catch
            {
                MessageBox.Show("Введіть коректну адресу електронної пошти.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private static bool ContainsAllowedCharacters(string input)
        {
            foreach (char c in input)
            {
                if (!((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z') || (c >= '0' && c <= '9') || c == '@' || c == '.' || c == '_' || c == '-'))
                {
                    return false;
                }
            }
            return true;
        }

        public static bool IsValidPhoneNumber(string phoneNumber, KeyPressEventArgs e)
        {
            // Дозволяємо тільки цифри та плюс
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '+' && !char.IsControl(e.KeyChar))
            {
                return false;
            }

            // Перевіряємо, чи плюс є першим символом
            if (e.KeyChar == '+' && phoneNumber.Length > 0)
            {
                return false;
            }

            return true;
        }

        public static bool IsValidName(KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space && e.KeyChar != '-')
            {
                return false;
            }

            return true;
        }

        public static bool IsEngTextWithNum(KeyPressEventArgs e)
        {
            // Дозволяємо тільки латинські літери та цифри
            if (!((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= '0' && e.KeyChar <= '9')) && !char.IsControl(e.KeyChar))
            {
                return false;
            }

            return true;
        }

        public static bool AreAllTextBoxesFilled(Form f)
        {
            foreach (Control control in f.Controls)
            {
                if (control is TextBox textBox && string.IsNullOrWhiteSpace(textBox.Text))
                {
                    MessageBox.Show("Будь ласка, заповніть всі текстові поля.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }

        public static bool IsValidFormat(string format)
        {
            string pattern = @"^\d+:\d+$";

            if (!Regex.IsMatch(format, pattern))
            {
                MessageBox.Show("Некоректний формат співвідношення сторін. Використовуйте формат 'число:число'.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public static bool IsValidPrice(KeyPressEventArgs e, string price)
        {
            // Дозвіл вводити лише числа, десятичну кому і Backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                return false; // Запретить ввод недопустимых символов
            }

            // Перевірка наявності коми
            if (e.KeyChar == ',' && price.IndexOf(',') > -1)
            {
                return false; // Заборона більше однієї коми
            }

            if (price.Contains(","))
            {
                string[] parts = price.Split(new char[] { ',' });
                if (parts[1].Length >= 2 && !char.IsControl(e.KeyChar))
                {
                    return false; // Заборона вводу більше двох знаків післе коми
                }
            }

            if (e.KeyChar == ',' && price.Length == 0)
            {
                return false; // Заборона вводу коми, якщо строка пуста
            }

            return true;
        }

        public static bool IsDigit(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                 return false;
            }

            return true;
        }

        public static bool IsValidWight(KeyPressEventArgs e, string wt)
        {
            // Дозвіл вводити лише числа, десятичну кому і Backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                return false; // Запретить ввод недопустимых символов
            }

            // Перевірка наявності коми
            if (e.KeyChar == ',' && wt.IndexOf(',') > -1)
            {
                return false; // Заборона більше однієї коми
            }

            if (wt.Contains(","))
            {
                string[] parts = wt.Split(new char[] { ',' });
                if (parts[1].Length >= 1 && !char.IsControl(e.KeyChar))
                {
                    return false; // Заборона вводу більше двох знаків післе коми
                }
            }

            if (e.KeyChar == ',' && wt.Length == 0)
            {
                return false; // Заборона вводу коми, якщо строка пуста
            }

            return true;
        }

        public static bool IsLoginUnique(string login)
        {
            using (SqlConnection connection = new SqlConnection(DatabaseManager.ConnectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM Workers WHERE Login = @Login";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Login", login);
                    int count = (int)command.ExecuteScalar();

                    if(count != 0) 
                    {
                        MessageBox.Show("Логін має бути унікальним.",
                            "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    return true;
                }
            }
        }

        public static bool CanDeleteLaptop(int laptopId)
        {
            using (SqlConnection connection = new SqlConnection(DatabaseManager.ConnectionString))
            {
                connection.Open();

                string query = $"SELECT COUNT(*) FROM Checks WHERE Laptop_id = {laptopId}";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    int count = (int)command.ExecuteScalar();

                    // Якщо кількість чеків, в яких є цей ноутбук, дорівнює 0, тоді можна видаляти
                    return count == 0;
                }
            }
        }

    }
}
