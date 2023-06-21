using System;
using System.Collections.Generic;

using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Screen_Recorder.UI
{
    public partial class Login : Form
    {
        public Boolean LogonSuccessful = false;
        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            using (WebClient client = new WebClient())
            {
                var reqparm = new System.Collections.Specialized.NameValueCollection();
                reqparm.Add("option", "com_users");
                reqparm.Add("task", "user.staff_app_win_ajax_login");
                reqparm.Add("username", txt_usernane.Text);
                reqparm.Add("password", txt_password.Text);
                byte[] responsebytes = client.UploadValues("https://softway.vn", "POST", reqparm);
                string responsebody = Encoding.UTF8.GetString(responsebytes);
                if (responsebody.Equals("0"))
                {
                    MessageBox.Show("Đăng nhập không thành công");
                }
                else
                {
                    LogonSuccessful = true;
                    MessageBox.Show("Đăng nhập thành công");
                    RecorderScreenMainWindow recorderScreenMainWindow = new RecorderScreenMainWindow();
                    RecorderScreenMainWindow.user_id = int.Parse(responsebody);
                    recorderScreenMainWindow.Show();
                    this.Hide();


                }
            }


        }
    }
}
