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
    public partial class Form1 : Form
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
        
        SqlConnection connection = new SqlConnection("server=192.168.23.235;UID=dba;PWD=sql;database=Starguide");
        private string p;

        public Form1()
        {
            InitializeComponent();
        }

        public Form1(string p)
        {
            InitializeComponent();
            // TODO: Complete member initialization
            this.p = p;
            if (p.Equals("Improper Login"))
            {
                button1.Enabled = false;
                button2.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            button1.Enabled = false;
            button2.Enabled = true;
            try 
            {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO [Starguide].[dbo].[pet_care_clock] (username, in_time) VALUES (@username, @in_time)", connection))
                {
                        cmd.Connection = connection;  // <== lacking
                        cmd.CommandType = CommandType.Text;

                        cmd.Parameters.AddWithValue("@username", LoginInfo.UserID.ToString());
                        cmd.Parameters.AddWithValue("@in_time", System.DateTime.Now);
                        //cmd.Parameters.AddWithValue("@out_time", "");
                       
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("You are Clocked In!!!!!");
                }
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.ToString(), "ERROR");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR");
            }
            finally
            {
                connection.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'starguideDataSet.Agent_Status' table. You can move, or remove it, as needed.
            //this.agent_StatusTableAdapter.Fill(this.starguideDataSet.Agent_Status);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            button1.Enabled = true;
            button2.Enabled = false;
            try 
            {
                using (SqlCommand cmd = new SqlCommand("UPDATE [Starguide].[dbo].[pet_care_clock] SET out_time = @out_time WHERE username = @username  and out_time is Null", connection))
                {
                  
                        cmd.Connection = connection;            
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@username", LoginInfo.UserID.ToString());
                        cmd.Parameters.AddWithValue("@out_time", time);

                        connection.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("you are clocked out !");

                }
             }
             catch (SqlException se)
             {
                 MessageBox.Show(se.ToString(), "SQL Error");
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.ToString(), "General Error");
             }
             finally
             {
                 connection.Close();
             }
            
        }
        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn__login_exit_Click(object sender, EventArgs e)
        {
            if (button2.Enabled)
            {
                MessageBox.Show("You can't exit Please Clock Out !", " Clock Out Error");
            }
            else
            {
                Application.Exit();
            }
            
        }
    }
}
