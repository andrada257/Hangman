﻿using Hangman.ViewModels;
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
using System.Windows.Shapes;

namespace Hangman.Views
{
    /// <summary>
    /// Interaction logic for BoardGameWindow.xaml
    /// </summary>
    public partial class BoardGameWindow : Window
    {
        private  GameVM boardGameVM;
        public BoardGameWindow(UserVM user)
        {
            InitializeComponent();
            boardGameVM = new GameVM(user);
            this.DataContext = boardGameVM;
        }

        private void btnExit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}
