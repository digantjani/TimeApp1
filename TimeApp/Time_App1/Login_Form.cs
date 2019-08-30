using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Time_App1
{

    public partial class Login_Form : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        public Login_Form()
        {
            InitializeComponent();
            if (checkNotLogout())
            {
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
        }

        private bool checkNotLogout()
        {
            try
            {
                return true;
                //using (SqlConnection sqlConnection = new SqlConnection("Data Source=192.168.23.235;Initial Catalog=Starguide;User ID=dba;Password=sql"))
                //{
                //    SqlCommand sqlCmd = new SqlCommand("SELECT * FROM [Starguide].[dbo].[pet_care_clock] Where username = @txt_login_username and out_time is Null", sqlConnection);
                //    sqlCmd.Parameters.AddWithValue("@txt_login_username", txt_login_username.Text);

                //    sqlConnection.Open();
                //    SqlDataReader sqlReader = sqlCmd.ExecuteReader();
                //    if (sqlReader.HasRows)
                //    {
                //        sqlReader.Read();
                //        LoginInfo.UserID = sqlReader["username"].ToString();
                //        return true;
                //    }
                //    else
                //    {
                //        return false;
                //    }
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(),"ERROR");
                return false;
            }
        }
        private void Ok_Click(object sender, EventArgs e)
        {
            if (txt_login_username.Text.ToString().Equals("") || txt_login_password.Text.ToString().Equals(""))
            {
                MessageBox.Show("Fill the Username and Password!", "Incomplete Data");
            } 
            else if(checkNotLogout())
            {
                Form1 form1 = new Form1("Improper Login");
                form1.Show();
                this.Hide();
            }
            else
            {
                //using (SqlConnection sqlConnection = new SqlConnection("Data Source=192.168.23.235;Initial Catalog=Starguide;User ID=dba;Password=sql"))
                //{
                //    SqlCommand sqlCmd = new SqlCommand("SELECT * FROM [Starguide].[dbo].[PETCARE.personnel] Where petcare_username = @txt_login_username and petcare_password = @txt_login_password", sqlConnection);
                //    sqlCmd.Parameters.AddWithValue("@txt_login_username", txt_login_username.Text);
                //    sqlCmd.Parameters.AddWithValue("@txt_login_password", txt_login_password.Text);
                //    sqlConnection.Open();
                //    SqlDataReader sqlReader = sqlCmd.ExecuteReader();

                //    if (sqlReader.HasRows)
                //    {
                //        sqlReader.Read();
                //        LoginInfo.UserID = sqlReader["petcare_username"].ToString();
                //        try
                //        {
                //            if (sqlReader["allow_reset"].ToString().Equals("0"))
                //            {
                //                Reset_Password form1 = new Reset_Password();
                //                form1.Show();
                //                this.Hide();
                //            }
                //            else
                //            {
                //                Form1 form1 = new Form1();
                //                form1.Show();
                //                this.Hide();
                //            }
                //        }catch(Exception ex){
                //            Console.WriteLine(ex.ToString());
                //        }
                //    }
                //    else
                //    {
                //        MessageBox.Show("Invalid Login please check username and password", "Error");
                //        txt_login_password.Text = "";
                //    }
                //}
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btn__login_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
public static class LoginInfo
{
    public static string UserID;
}