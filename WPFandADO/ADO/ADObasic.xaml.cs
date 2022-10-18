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
using System.Windows.Shapes;
using System.Data.SqlClient;
namespace WPFandADO.ADO
{
    /// <summary>
    /// Interaction logic for ADObasic.xaml
    /// </summary>
    public partial class ADObasic : Window
    {
        private const String ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\VS file\WPFandADO\WPFandADO\ADO\Database1.mdf"";Integrated Security=True";
        private SqlConnection connection;  // объект-подключение
        public ADObasic()
        {
            InitializeComponent();
            connection = new SqlConnection(ConnectionString);
            // !! ADO создание объекта не открывает подключени
        }

        private void ButtonConnect_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                connection?.Open();
                MessageBox.Show("Подключение открыто");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonDisconnect_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                connection?.Close();
                MessageBox.Show("Подключение закрыто");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonTimestamp_Click(object sender, RoutedEventArgs e)
        {
            using (SqlCommand cmd = new SqlCommand("SELECT CURRENT_TIMESTAMP", connection))
            {
                MessageBox.Show(
                    cmd.ExecuteScalar()  // исполнение команды и возврат "скаляра" - одного рез-та
                    .ToString());
            }
        }
    }
}
