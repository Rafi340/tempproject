using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace tempproject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Login(object sender, EventArgs e)
        {
            string connectingstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Rafi Samnan\source\repos\tempproject\tempproject\Properties\slogin.mdf; Integrated Security=True;Connect Timeout=30";
            string sql = "select Id,UserName,Password " + "from login where UserName='" + txtUserName.Text
                 + "' and Password='" + txtPassword.Text + "'";
            SqlConnection conn = new SqlConnection(connectingstring);
            SqlCommand sqlCmd = new SqlCommand(sql, conn);
           
            DataTable dt = new DataTable();
            sqlCmd.Connection.Open();
            dt.Load(sqlCmd.ExecuteReader());
            
            if ( dt.Rows.Count > 0 )
            {
                MessageBox.Show("Correct Pass");
               
               Pinfo p = new Pinfo();
                p.Show();
               this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Password");
            }
            sqlCmd.Connection.Close();

        }
    }
}
