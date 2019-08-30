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
    public partial class Reset_Password : Form
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


        public Reset_Password()
        {
            InitializeComponent();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void change_Click(object sender, EventArgs e)
        {
            if (txt_reset_password.Text.Equals("") || txt_reset_confpass.Text.Equals(""))
            {
                MessageBox.Show("Please Insert ID and PASSWORD","Insert Values");
            }
            else if (!ValidatePassword(txt_reset_password.Text))
            {
                MessageBox.Show("Password Must have atleast 1 Upper case, 1 Digit, 1 Lower Case and should be between 8 to 15 characters", "Invalid Password");
            }
            else if (!txt_reset_password.Text.Equals(txt_reset_confpass.Text))
            {
                MessageBox.Show("Password and Confirm Password Doesn't Match", "Not Matching");
            }
            else
            {
                try { 
                using (SqlConnection sqlConnection = new SqlConnection("Data Source=192.168.23.235;Initial Catalog=Starguide;User ID=dba;Password=sql"))
                {
                    using (SqlCommand cmd = new SqlCommand("UPDATE [Starguide].[dbo].[PETCARE.personnel] SET petcare_password = @petcare_password, allow_reset = @allow_reset WHERE petcare_username = @petcare_username", sqlConnection))
                    {
                        sqlConnection.Open();
                        cmd.Parameters.AddWithValue("petcare_password", txt_reset_password.Text.ToString());
                        cmd.Parameters.AddWithValue("allow_reset", "1");
                        cmd.Parameters.AddWithValue("petcare_username", LoginInfo.UserID);

                        cmd.ExecuteNonQuery();
                       MessageBox.Show("Updated Successfully");
                    }
                    sqlConnection.Close();
                }
                this.Hide();
                Login_Form lgform = new Login_Form();
                lgform.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Can't Update The Password");
                    Console.WriteLine(ex.ToString());
                }
           }
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn__login_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        protected bool ValidatePassword(string password)
        {
            const int MIN_LENGTH = 8;
            const int MAX_LENGTH = 15;

            if (password == null) throw new ArgumentNullException();

            bool meetsLengthRequirements = password.Length >= MIN_LENGTH && password.Length <= MAX_LENGTH;
            bool hasUpperCaseLetter = false;
            bool hasLowerCaseLetter = false;
            bool hasDecimalDigit = false;

            if (meetsLengthRequirements)
            {
                foreach (char c in password)
                {
                    if (char.IsUpper(c)) hasUpperCaseLetter = true;
                    else if (char.IsLower(c)) hasLowerCaseLetter = true;
                    else if (char.IsDigit(c)) hasDecimalDigit = true;
                }
            }
            bool isValid = meetsLengthRequirements
                        && hasUpperCaseLetter
                        && hasLowerCaseLetter
                        && hasDecimalDigit
                        ;
            return isValid;

        }
    }

}
