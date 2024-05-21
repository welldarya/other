using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using MessageBox = System.Windows.MessageBox;

namespace TechnoServ
{
    public partial class MainWindow : Window
    {
        DataBase database = new DataBase();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, RoutedEventArgs e)
        {
            var loginUser = textbox_login.Text;
            var passwordUser = textbox_password.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string query = $"SELECT id_role FROM [User] WHERE login = '{loginUser}' AND password = '{passwordUser}'";
            SqlCommand command = new SqlCommand(query, database.getConn());
            database.openConn();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Успешно!");
                Window1 task1 = new Window1();
                task1.Show();
                this.Close();
            }
            else MessageBox.Show("Какие-то приколы");
        }
    }
}
