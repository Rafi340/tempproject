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
            customizeDesing();
            hideSubMenu();

        }
        private void customizeDesing()
        {
            panel2.Visible = false;
            panel3.Visible = false;
            //button4.Visible = false;
            //button5.Visible = false;
        }
        private void hideSubMenu()
        {
            if(panel2.Visible==true)
            {
                panel2.Visible = false;
            }
            if(panel3.Visible==true)
            {
                panel3.Visible = false;
            }
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //Home
        private void Home_Click(object sender, EventArgs e)
        {
            showSubMenu(panel2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }
        // contact
        private void button6_Click(object sender, EventArgs e)
        {
            showSubMenu(panel3);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
