using System.Data;
using System.Windows;
using Microsoft.Data.SqlClient;

namespace sqlcombo
{
    /// <summary>
    /// Interaction logic for Llistcoutry.xaml
    /// </summary>
    public partial class Llistcoutry : Window
    {
        public Llistcoutry()
        {
            InitializeComponent();
            SqlConnection ocon = new SqlConnection();
            ocon.ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=HEADOFFICE;Data Source=DESKTOP-L4GUH2T\\MSSQLSERVER02; Encrypt=false";
            ocon.Open();
            string sqlq = "Select * from COUNTRYYY";
            SqlCommand sqlC = new SqlCommand(sqlq, ocon);
            SqlDataAdapter SqlDataAdapter = new SqlDataAdapter(sqlC);
            DataSet od = new DataSet();
            SqlDataAdapter.Fill(od, "country");
            cmbcountry.ItemsSource = od.Tables["country"].DefaultView;
            cmbcountry.DisplayMemberPath = "COUNTRYNAME";
            cmbcountry.SelectedValuePath = "CID";
            ocon.Close();
        }

        private void btnreg_Click(object sender, RoutedEventArgs e)
        {

            //SqlConnection ocon = new SqlConnection();
            //ocon.ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=HEADOFFICE;Data Source=DESKTOP-L4GUH2T\\MSSQLSERVER02; Encrypt=false";
            //ocon.Open();
            //string sqlq = "SELECT*FROM COUNTRY";

            //SqlCommand sqlC = new SqlCommand(sqlq, ocon);
            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlC);
            //DataSet od = new DataSet();
            //sqlDataAdapter.Fill(od, "countryname");
            //cmbstate.ItemsSource = null;
            //cmbstate.ItemsSource = od.Tables["countryname"].DefaultView;
            //cmbstate.DisplayMemberPath = "countryname";
            //cmbstate.SelectedValuePath = "CID";



            //ocon.Close();





        }

        private void cmbcountry_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            SqlConnection ocon = new SqlConnection();
            ocon.ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=HEADOFFICE;Data Source=DESKTOP-L4GUH2T\\MSSQLSERVER02; Encrypt=false";
            ocon.Open();
            string val = cmbcountry.SelectedValue.ToString();
            string query = "SELECT*FROM SSTATTE WHERE CID=" + val;
            SqlCommand sqlC = new SqlCommand(query, ocon);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlC);
            DataSet od = new DataSet();
            sqlDataAdapter.Fill(od, "STATENAME");
            cmbstate.ItemsSource = null;
            cmbstate.ItemsSource = od.Tables["STATENAME"].DefaultView;
            cmbstate.DisplayMemberPath = "STATENAME";
            cmbstate.SelectedValuePath = "SID";



            ocon.Close();
        }

        private void cmbstate_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            
            SqlConnection ocon = new SqlConnection();
            ocon.ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=HEADOFFICE;Data Source=DESKTOP-L4GUH2T\\MSSQLSERVER02; Encrypt=false";
            ocon.Open();
            string value = cmbstate.SelectedValue.ToString();
            string query = "SELECT*FROM DISSTRICTT WHERE  SID=" + value;
            SqlCommand sqlC = new SqlCommand(query, ocon);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlC);
            DataSet od = new DataSet();
            sqlDataAdapter.Fill(od, "DISTRICNAME");
            cmbcity.ItemsSource = null;
            cmbcity.ItemsSource = od.Tables["DISTRICNAME"].DefaultView;
            cmbcity.DisplayMemberPath = "DISTRICNAME";
            cmbcity.SelectedValuePath = "DID";



            ocon.Close();

        }

        private void cmbcity_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            
            SqlConnection ocon = new SqlConnection();
            ocon.ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=HEADOFFICE;Data Source=DESKTOP-L4GUH2T\\MSSQLSERVER02; Encrypt=false";
            ocon.Open();
            string value = cmbcity.SelectedValue.ToString();
            string query = "SELECT*FROM VILLAGEE WHERE DID=" + value;
            SqlCommand sqlC = new SqlCommand(query, ocon);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlC);
            DataSet od = new DataSet();
            sqlDataAdapter.Fill(od, "VILLAGENAME");
           
            cmbvillage.ItemsSource = od.Tables["VILLAGENAME"].DefaultView;
            cmbvillage.DisplayMemberPath = "VILLAGENAME";
            cmbvillage.SelectedValuePath = "VID";



            ocon.Close();


        }

        private void cmbvillage_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }
    }
}
