using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForm_app10.Repository;
using WinForm_app10.View;
using WinForm_app10.Model;

namespace WinForm_app10.Presenter
{
    public class RegistrationPresenter
    {
        UserRepository repository;
        RegistrationForm view;

        public RegistrationPresenter() { }
        public RegistrationPresenter (RegistrationForm registrationForm, UserRepository userRepository)
        {
            this.view = registrationForm;
            this.view.registrationPresenter = this;
            this.repository = userRepository;
        }

        public bool CreateAccount()
        {
            User tmp = new User(view.NickName,view.Password,view.UserName, view.UserSurname,new List<string>());
            foreach (var user in repository.GetAllUsers())
            {
                if (user.NickName == tmp.NickName)
                    return false;
            }
            repository.AddSaveUser(tmp);
            return true;
        }

    }
}
