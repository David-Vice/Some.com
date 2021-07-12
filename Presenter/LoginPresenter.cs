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
    public class LoginPresenter
    {
        UserRepository userRepository;
        LoginForm loginForm;

        public LoginPresenter(LoginForm loginForm, UserRepository userRepository)
        {
            this.loginForm = loginForm;
            this.loginForm.loginPresenter = this;
            this.userRepository = userRepository;
        }

        public bool Continue()
        {
            for(int i=0;i<userRepository.GetAllUsers().ToList().Count;i++)
            {
                if(userRepository.GetAllUsers().ToList()[i].NickName==loginForm.NickName && userRepository.GetAllUsers().ToList()[i].Password==loginForm.Password)
                {
                    loginForm.CurrentUserID = i;
                    return true;
                }
            }
            return false;
        }

    }
}
