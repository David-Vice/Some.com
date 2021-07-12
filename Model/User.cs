using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm_app10.Model
{
    public class User
    {
        public User() { }
        
        public User(string nickName, string password, string name, string surName, List<string> statusList)
        {
            NickName = nickName;
            Password = password;
            Name = name;
            SurName = surName;
            StatusList = statusList;
        }

        public string NickName { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public List<string> StatusList { get; set; }
    }
}
