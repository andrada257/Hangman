using Hangman.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman.ViewModels
{
     public class UserVM : BaseViewModel
    {
        public User user { get; set; }

        public UserVM(User user) => this.user = user;

        public string UserName
        {
            get
            {
                return user.userName;
            }

            set
            {
                if(user.userName == value) return;
                user.userName = value;            
                OnPropertyChanged("UserName");
            }
        }

        public string Image
        {
            get
            {
                return user.image;
            }

            set
            {
                if(user.image == value) return;
                user.image = value;
                OnPropertyChanged("Image");
            }
        }
    }
}
