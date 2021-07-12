using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using WinForm_app10.Model;

namespace WinForm_app10.Repository
{
    public class UserRepository
    {
        public string xmlPath { get; set; }
        XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<User>));
        public List<User> users { get; set; }

        public UserRepository(string path)
        {
            xmlPath = path + "\\users.xml";
            if (!File.Exists(xmlPath))
            {
                XmlFakeRepo();
            }
            users = new List<User>();
            using (var ser = new StreamReader(xmlPath))
            {
                users = (List<User>)xmlSerializer.Deserialize(ser);
            }
        }

        void XmlFakeRepo()
        {
            List<User> userList = new List<User>
            {
                new User("admin","1234","Admin","Adminovic",new List<string>{"Сегодня меня укусила пчела, печаль(((","Продаю BMW Х5. Есть желающие?" })
            };
            SaveUsers(userList);
        }

        public IEnumerable<User> GetAllUsers()
        {
            return users;
        }

        public void AddSaveUser(User user)
        {
            users.Add(user);
            SaveUsers(users);
        }

        public User GetUserByID(int id)
        {
            return users[id];
        }
        public void SaveUsers(List<User> _users)
        {
            using (var ser = new StreamWriter(xmlPath))
            {
                xmlSerializer.Serialize(ser, _users);
            }
        }
        public void SaveUser(int id, User user)
        {
            users[id] = user;
            SaveUsers(users);
        }
    }
}
