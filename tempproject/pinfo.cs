using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace tempproject
{
    public partial class Pinfo : Form
    {
        public Pinfo()
        {
            InitializeComponent();
        }

   

        private void button1_Click(object sender, EventArgs e)
        {
            string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Rafi Samnan\source\repos\tempproject\tempproject\Properties\slogin.mdf; Integrated Security=True;Connect Timeout=30";
            string sql = string.Format("insert into info (Id,FirstName,LastName,MiddleName,FatherName,MotherName,PresentAddress) Values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",textBox1.Text, textBox2.Text,textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text);

            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand sqlCmd = new SqlCommand(sql, conn);
         

            sqlCmd.Connection.Open();

            int rowsAffected = sqlCmd.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                MessageBox.Show("done");
            }
            else
            {
                MessageBox.Show("error");
            }
            sqlCmd.Connection.Close();


            string showdata = String.Format("select * from  [dbo].[info]");

            SqlCommand cmd = new SqlCommand(showdata, conn);

            DataTable dt = new DataTable();

            cmd.Connection.Open();
            dt.Load(cmd.ExecuteReader());
            dataGridView1.DataSource = dt;
            cmd.Connection.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }
    }
}
