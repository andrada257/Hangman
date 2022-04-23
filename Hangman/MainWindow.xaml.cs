using Hangman.Models;
using Hangman.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Hangman
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainWindowVM mainWindowVM = new MainWindowVM();
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = mainWindowVM;
        }
        public void OnSelected(object sender, RoutedEventArgs e)
        {
            mainWindowVM.selectedUser = lbUsers.SelectedItem as UserVM;
            btnDel.IsEnabled = true;
            btnPlay.IsEnabled = true;
        }

    }
}
