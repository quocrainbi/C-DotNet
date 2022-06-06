using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThiDotNet.DTO
{
    public class Account
    {
        private string UserName;
        public string userName
        {
            get { return UserName; }
            set { userName = value; }
        }
        private string PassWord;
        public string passWord
        {
            get { return PassWord; }
            set { PassWord = value; }
        }
        private string DisplayName;
        public string displayName
        {
            get { return DisplayName; }
            set { DisplayName = value; }
        }
        private int Type;
        public int type
        {
            get { return Type; }
            set { Type = value; }
        }
        public Account(string UserName,string PassWord,string DisPlayName,int Type)
        {
            this.UserName = UserName;
            this.PassWord = PassWord;
            this.Type = Type;
            this.DisplayName = DisPlayName;
        }
        public Account(DataRow row)
        {
            this.UserName = (string)row["UserName"];
            this.DisplayName = (string)row["DisplayName"];
            this.PassWord = (string)row["PassWord"];
            this.Type = (int)row["Type"];
        }
    }
}
