using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThiDotNet.DAO;
using ThiDotNet.View;

namespace ThiDotNet
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }
        #region method
        private bool Login_Account(string username,string password)
        {
            if(AccountDAO.Instance.Login(username,password))
            {
                return true;
            }
            return false;
        }
        #endregion
        #region envent
        private void bntLogin_Click(object sender, EventArgs e)
        {
            string UserName=txbNameLogin.Text;
            string PassWork=txbPwdLogin.Text;
            if(UserName==""||PassWork=="")
            {
                MessageBox.Show("Vui lòng nhập tài khoản hoặc mật khẩu.", "Thông Báo");
            }    
            else if (Login_Account(UserName,PassWork))
            {
                fTableManager f = new fTableManager(AccountDAO.Instance.GetAccountByUserName(UserName));
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Bạn đã nhập sai tài khoản hoặc mật khẩu ", "Thông Báo");
            }    
        }

        private void bntExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình ?", "Thông Báo", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
        #endregion
    }
}
