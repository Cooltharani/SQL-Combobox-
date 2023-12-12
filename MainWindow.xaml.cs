using System;
using System.Data;
using System.Windows;
using Microsoft.Data.SqlClient;
namespace sqlcombo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SqlConnection ocon = new SqlConnection();
            ocon.ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=HEADOFFICE;Data Source=DESKTOP-L4GUH2T\\MSSQLSERVER02; Encrypt=false";
            ocon.Open();
            String sqlq="Select * from LISTCOUNTRY";
            SqlCommand sqlC = new SqlCommand(sqlq, ocon);
            SqlDataAdapter SqlDataAdapter = new SqlDataAdapter(sqlC);
            DataSet od = new DataSet();
            SqlDataAdapter.Fill(od, "country");
            cmbcountry.ItemsSource = od.Tables["country"].DefaultView;
            cmbcountry.DisplayMemberPath ="COUNTRYNAME";
            ocon.Close();
            
            
        }

        private void btnreg_Click(object sender, RoutedEventArgs e)
        {

            
                SqlConnection ocon = new SqlConnection();
                ocon.ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=HEADOFFICE;Data Source=DESKTOP-L4GUH2T\\MSSQLSERVER02; Encrypt=false";
                ocon.Open();
                string registerquery = $"INSERT INTO  EMPLID SET ENAME='',EMAIL='',PASSWORD=''";
                string query = "CREATE TABLE EMPLID(ENAME NVARCHAR(20),EMAIL NVARCHAR(20),PASSWORD NVARCHAR(20))";
                SqlCommand sqlC = new SqlCommand(registerquery, ocon);
                int value = sqlC.ExecuteNonQuery();
                if (value == 1)
                {
                    MessageBox.Show("Register success");

                }

                ocon.Close();
            
        }
    }
}
