using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman.Models
{
    public class User
    {
        #region MemberVariables

        public User(string _image) => image = _image;

        public string userName { get; set; }
        public string image { get; set; }
       
            

        #endregion
    }
}
