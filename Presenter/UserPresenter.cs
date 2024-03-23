using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HRMngt.Model;
using HRMngt.View;

namespace HRMngt.Presenter
{
    public class UserPresenter
    {
        //Fields
        private IUserview view;
        private IUserRepository userRepository;
        private IEnumerable<Users> users;
        private BindingSource userBindingSource;

        public UserPresenter(IUserview view, IUserRepository userRepository)
        {
            this.userBindingSource = new BindingSource();
            this.view = view;
            this.userRepository = userRepository;
            //sub event handler 
            this.view.AddEvent += AddEvent;
            this.view.EditEvent += EditEvent;
            this.view.DeleteEvent += DeleteEvent;
            this.view.SaveEvent += SaveEvent;
            this.view.CancelEvent += CancelEvent;
            this.view.SetUserListBindingSource(userBindingSource);
            LoadAllUserList();
            this.view.Show();
        }

        private void LoadAllUserList()
        {
            users = userRepository.GetAll();
            userBindingSource.DataSource = users;
        }

        private void CancelEvent(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SaveEvent(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DeleteEvent(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void EditEvent(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AddEvent(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
