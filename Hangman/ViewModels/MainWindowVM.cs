using Hangman.Models;
using Hangman.Views;
using Microsoft.Win32;
using System;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.Windows.Input;

namespace Hangman.ViewModels
{
    class MainWindowVM : BaseViewModel
    {
        #region Member Variables
        public ObservableCollection<UserVM> userList { get; set; }
        public UserVM selectedUser { get; set; }

        #endregion

        #region Constructor

        public MainWindowVM()
        {
            userList = new ObservableCollection<UserVM>();
            User user = new User("D:/Facultate/Anul2/Semestrul2/MVP/Tema2/Hangman/Hangman/Images/UserImages/Andrada.jpg") { userName = "Andrada"};
            userList.Add(new UserVM(user));
        }

        #endregion

        #region IComamnds for Add/Delete an user and Play the game

        public void AddUser(object param)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                Image image = new Image();
                Uri fileUri = new Uri(openFileDialog.FileName);
                image.Source = new System.Windows.Media.Imaging.BitmapImage(fileUri);
                userList.Add(new UserVM(new User(image.Source.ToString())));

            }
            
        }
        private ICommand _addUser;
        public ICommand addUser
        {
            get 
            {
                if (_addUser == null)
                    _addUser = new RelayCommands(AddUser);
                return _addUser; 
            } 
        }


        public void DeleteUser(object param)
        {
            userList.Remove(selectedUser);

        }
        private ICommand _deleteUser;
        public ICommand deleteUser
        {
            get
            {
                if(_deleteUser == null)
                    _deleteUser = new RelayCommands(DeleteUser);
                return _deleteUser;
            }
        }

        public void Play(object param)
        {
            BoardGameWindow boardGameWindow = new BoardGameWindow(selectedUser);
            boardGameWindow.Show();
        }
        private ICommand _play;
        public ICommand play
        {
            get
            {
                if (_play == null)
                    _play = new RelayCommands(Play);
                return _play;
            }
        }

        #endregion


    }
}
