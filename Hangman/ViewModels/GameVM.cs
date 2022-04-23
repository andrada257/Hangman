using Hangman.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;

namespace Hangman.ViewModels
{
    class GameVM : BaseViewModel
    {

        #region Member Variables
        public UserVM userVM { get; set; }
        public Words words { get; set; }
        public int level { get; set; }
        public int noMistakes { get; set; }
        public string imageSource { get; set; }
        public List<char> mistakes { get; set; }
        public string category { get; set; }

        DispatcherTimer dispatcherTimer = new DispatcherTimer();
        private int delay;
        private DateTime deadline;
        public string timeLeft { get; set; }

        private ICommand _newGame;

        private ICommand _allCategories;
        private ICommand _cars;
        private ICommand _movies;
        private ICommand _capitals;
        private ICommand _singers;

        private ICommand _A;
        private ICommand _B;
        private ICommand _C;
        private ICommand _D;
        private ICommand _E;
        private ICommand _F;
        private ICommand _G;
        private ICommand _H;
        private ICommand _I;
        private ICommand _J;
        private ICommand _K;
        private ICommand _L;
        private ICommand _M;
        private ICommand _N;
        private ICommand _O;
        private ICommand _P;
        private ICommand _Q;
        private ICommand _R;
        private ICommand _S;
        private ICommand _T;
        private ICommand _U;
        private ICommand _V;
        private ICommand _W;
        private ICommand _X;
        private ICommand _Y;
        private ICommand _Z;

        public bool CanCloseA { get; set; }
        public bool CanCloseB { get; set; }
        public bool CanCloseC { get; set; }
        public bool CanCloseD { get; set; }
        public bool CanCloseE { get; set; }
        public bool CanCloseF { get; set; }
        public bool CanCloseG { get; set; }
        public bool CanCloseH { get; set; }
        public bool CanCloseI { get; set; }
        public bool CanCloseJ { get; set; }
        public bool CanCloseK { get; set; }
        public bool CanCloseL { get; set; }
        public bool CanCloseM { get; set; }
        public bool CanCloseN { get; set; }
        public bool CanCloseO { get; set; }
        public bool CanCloseP { get; set; }
        public bool CanCloseQ { get; set; }
        public bool CanCloseR { get; set; }
        public bool CanCloseS { get; set; }
        public bool CanCloseT { get; set; }
        public bool CanCloseU { get; set; }
        public bool CanCloseV { get; set; }
        public bool CanCloseW { get; set; }
        public bool CanCloseX { get; set; }
        public bool CanCloseY { get; set; }
        public bool CanCloseZ { get; set; }

        #endregion

        #region Constructor

        public GameVM(UserVM user)
        {
            userVM = user;
            words = new Words();
            level = 1;
            noMistakes = 0;
            imageSource = "D:/Facultate/Anul2/Semestrul2/MVP/Tema2/Hangman/Hangman/Images/hangman0.png";
            mistakes = new List<char>();
            delay = 30;
            timeLeft = delay.ToString();
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);


            CanCloseA = true;
            CanCloseB = true;
            CanCloseC = true;
            CanCloseD = true;
            CanCloseE = true;
            CanCloseF = true;
            CanCloseG = true;
            CanCloseH = true;
            CanCloseI = true;
            CanCloseJ = true;
            CanCloseK = true;
            CanCloseL = true;
            CanCloseM = true;
            CanCloseN = true;
            CanCloseO = true;
            CanCloseP = true;
            CanCloseQ = true;
            CanCloseR = true;
            CanCloseS = true;
            CanCloseT = true;
            CanCloseU = true;
            CanCloseV = true;
            CanCloseW = true;
            CanCloseX = true;
            CanCloseY = true;
            CanCloseZ = true;

    }

        #endregion

        #region Time Management

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            int secondsRemaining = (deadline - DateTime.Now).Seconds;
            if (secondsRemaining == 0)
            {
                dispatcherTimer.Stop();
                dispatcherTimer.IsEnabled = false;
                MessageBox.Show("Time has expired! Try again...");

                level = 1;
                OnPropertyChanged("level");
                ResetLevel();

                delay = 30;
            }
            else
            {
                timeLeft = secondsRemaining.ToString();
                OnPropertyChanged("timeLeft");
            }
        }

        private void StartTimer()
        {
            deadline = DateTime.Now.AddSeconds(delay);
            dispatcherTimer.Start();
        }

        #endregion

        #region ICommand MenuItems

        public void NewGame(object param)
        {
            ResetLevel();
        }
        public ICommand newGame
        {
            get
            {
                if (_newGame == null)
                    _newGame = new RelayCommands(NewGame);
                return _newGame;
            }
        }
        public void AllCategories(object param)
        {
            category = "AllCategories";
            level = 1;
            OnPropertyChanged("level");
            words.AllCategories();
            words.FindShownedWord();
            StartTimer();
        }
        public ICommand allCategories
        {
            get
            {
                if (_allCategories == null)
                    _allCategories = new RelayCommands(AllCategories);
                return _allCategories;
            }

        }

        public void Cars(object param)
        {
            category = "Cars";
            level = 1;
            OnPropertyChanged("level");
            words.Cars();
            words.FindShownedWord();
            StartTimer();
        }
        public ICommand cars
        {
            get
            {
                if (_cars == null)
                    _cars = new RelayCommands(Cars);
                return _cars;
            }

        }

        public void Movies(object param)
        {
            category = "Movies";
            level = 1;
            OnPropertyChanged("level");
            words.Movies();
            words.FindShownedWord();
            StartTimer();
        }
        public ICommand movies
        {
            get
            {
                if (_movies == null)
                    _movies = new RelayCommands(Movies);
                return _movies;
            }

        }

        public void Capitals(object param)
        {
            category = "Capitals";
            level = 1;
            OnPropertyChanged("level");
            words.Capitals();
            words.FindShownedWord();
            StartTimer();
        }
        public ICommand capitals
        {
            get
            {
                if (_capitals == null)
                    _capitals = new RelayCommands(Capitals);
                return _capitals;
            }

        }

        public void Singers(object param)
        {
            category = "Singers";
            level = 1;
            OnPropertyChanged("level");
            words.Singers();
            words.FindShownedWord();
            StartTimer();
        }
        public ICommand singers
        {
            get
            {
                if (_singers == null)
                    _singers = new RelayCommands(Singers);
                return _singers;
            }

        }

        #endregion

        #region Restart Level function

        private void ResetLevel()
        {

            if (category == "AllCategories")
                words.AllCategories();
            if (category == "Cars")
                words.Cars();
            if (category == "Movies")
                words.Movies();
            if (category == "Singers")
                words.Singers();
            if (category == "Capitals")
                words.Capitals();

            words.FindShownedWord();

            CanCloseA = true;
            CanCloseB = true;
            CanCloseC = true;
            CanCloseD = true;
            CanCloseE = true;
            CanCloseF = true;
            CanCloseG = true;
            CanCloseH = true;
            CanCloseI = true;
            CanCloseJ = true;
            CanCloseK = true;
            CanCloseL = true;
            CanCloseM = true;
            CanCloseN = true;
            CanCloseO = true;
            CanCloseP = true;
            CanCloseQ = true;
            CanCloseR = true;
            CanCloseS = true;
            CanCloseT = true;
            CanCloseU = true;
            CanCloseV = true;
            CanCloseW = true;
            CanCloseX = true;
            CanCloseY = true;
            CanCloseZ = true;

            OnPropertyChanged("CanCloseA");
            OnPropertyChanged("CanCloseB");
            OnPropertyChanged("CanCloseC");
            OnPropertyChanged("CanCloseD");
            OnPropertyChanged("CanCloseE");
            OnPropertyChanged("CanCloseF");
            OnPropertyChanged("CanCloseG");
            OnPropertyChanged("CanCloseH");
            OnPropertyChanged("CanCloseI");
            OnPropertyChanged("CanCloseJ");
            OnPropertyChanged("CanCloseK");
            OnPropertyChanged("CanCloseL");
            OnPropertyChanged("CanCloseM");
            OnPropertyChanged("CanCloseN");
            OnPropertyChanged("CanCloseO");
            OnPropertyChanged("CanCloseP");
            OnPropertyChanged("CanCloseQ");
            OnPropertyChanged("CanCloseR");
            OnPropertyChanged("CanCloseS");
            OnPropertyChanged("CanCloseT");
            OnPropertyChanged("CanCloseU");
            OnPropertyChanged("CanCloseV");
            OnPropertyChanged("CanCloseW");
            OnPropertyChanged("CanCloseX");
            OnPropertyChanged("CanCloseY");
            OnPropertyChanged("CanCloseZ");

            imageSource = "D:/Facultate/Anul2/Semestrul2/MVP/Tema2/Hangman/Hangman/Images/hangman0.png";
            OnPropertyChanged("imageSource");

            noMistakes = 0;
            mistakes.Clear();
            mistakes = new List<char>();
            OnPropertyChanged("mistakes");

            OnPropertyChanged("level");

            StartTimer();

        }

        #endregion

        #region ICommand Keyboard
        public void A(object param)
        {
            if(words.CurrentWord.IndexOf('A') != -1 || words.CurrentWord.IndexOf('a') != -1)
            {
                words.ReplaceCharacters('A');

                CanCloseA = false;
                OnPropertyChanged("CanCloseA");

                if (words.areEqual())
                {
                    level++;
                    if(level == 6)
                    {
                        dispatcherTimer.Stop();
                        MessageBox.Show("Congrats! You won! :)");
                    }
                    else
                    {
                        ResetLevel();
                    }
                }
                    
            }
            else
            {
                noMistakes++;
                if (noMistakes == 7)
                {
                    level = 1;
                    MessageBox.Show("You lost the game :(");
                    ResetLevel();
                }
                else
                {
                    imageSource = "D:/Facultate/Anul2/Semestrul2/MVP/Tema2/Hangman/Hangman/Images/hangman" + noMistakes + ".png";
                    OnPropertyChanged("imageSource");

                    mistakes.Add('X');
                    OnPropertyChanged("mistakes");

                    CanCloseA = false;
                    OnPropertyChanged("CanCloseA");

                }
                    
            }
          

        }
        public ICommand a
        {
            get
            {
                if (_A == null)
                    _A = new RelayCommands(A);
                return _A;
            }
        }


        public void B(object param)
        {
            if (words.CurrentWord.IndexOf('B') != -1 || words.CurrentWord.IndexOf('b') != -1)
            {
                words.ReplaceCharacters('B');

                CanCloseB = false;
                OnPropertyChanged("CanCloseB");

                if (words.areEqual())
                {
                    level++;
                    if (level == 6)
                    {
                        dispatcherTimer.Stop();
                        MessageBox.Show("Congrats! You won! :)");
                    }
                    else
                    {
                        ResetLevel();
                    }
                }

            }
            else
            {
                noMistakes++;
                if (noMistakes == 7)
                {
                    level = 1;
                    MessageBox.Show("You lost the game :(");
                    ResetLevel();
                }
                else
                {
                    imageSource = "D:/Facultate/Anul2/Semestrul2/MVP/Tema2/Hangman/Hangman/Images/hangman" + noMistakes + ".png";
                    OnPropertyChanged("imageSource");

                    mistakes.Add('X');
                    OnPropertyChanged("mistakes");

                    CanCloseB = false;
                    OnPropertyChanged("CanCloseB");

                }

            }

        }
        public ICommand b
        {
            get
            {
                if (_B == null)
                    _B = new RelayCommands(B);
                return _B;
            }
        }


        public void C(object param)
        {
            if (words.CurrentWord.IndexOf('C') != -1 || words.CurrentWord.IndexOf('c') != -1)
            {
                words.ReplaceCharacters('C');

                CanCloseC = false;
                OnPropertyChanged("CanCloseC");

                if (words.areEqual())
                {
                    level++;
                    if (level == 6)
                    {
                        dispatcherTimer.Stop();
                        MessageBox.Show("Congrats! You won! :)");
                    }
                    else
                    {
                        ResetLevel();
                    }
                }

            }
            else
            {
                noMistakes++;
                if (noMistakes == 7)
                {
                    level = 1;
                    MessageBox.Show("You lost the game :(");
                    ResetLevel();
                }
                else
                {
                    imageSource = "D:/Facultate/Anul2/Semestrul2/MVP/Tema2/Hangman/Hangman/Images/hangman" + noMistakes + ".png";
                    OnPropertyChanged("imageSource");

                    mistakes.Add('X');
                    OnPropertyChanged("mistakes");

                    CanCloseC = false;
                    OnPropertyChanged("CanCloseC");

                }

            }

        }
        public ICommand c
        {
            get
            {
                if (_C == null)
                    _C = new RelayCommands(C);
                return _C;
            }
        }


        public void D(object param)
        {
            if (words.CurrentWord.IndexOf('D') != -1 || words.CurrentWord.IndexOf('d') != -1)
            {
                words.ReplaceCharacters('D');

                CanCloseD = false;
                OnPropertyChanged("CanCloseD");

                if (words.areEqual())
                {
                    level++;
                    if (level == 6)
                    {
                        dispatcherTimer.Stop();
                        MessageBox.Show("Congrats! You won! :)");
                    }
                    else
                    {
                        ResetLevel();
                    }
                }

            }
            else
            {
                noMistakes++;
                if (noMistakes == 7)
                {
                    level = 1;
                    MessageBox.Show("You lost the game :(");
                    ResetLevel();
                }
                else
                {
                    imageSource = "D:/Facultate/Anul2/Semestrul2/MVP/Tema2/Hangman/Hangman/Images/hangman" + noMistakes + ".png";
                    OnPropertyChanged("imageSource");

                    mistakes.Add('X');
                    OnPropertyChanged("mistakes");

                    CanCloseD = false;
                    OnPropertyChanged("CanCloseD");
                }

            }

        }
        public ICommand d
        {
            get
            {
                if (_D == null)
                    _D = new RelayCommands(D);
                return _D;
            }
        }


        public void E(object param)
        {
            if (words.CurrentWord.IndexOf('E') != -1 || words.CurrentWord.IndexOf('e') != -1)
            {
                words.ReplaceCharacters('E');

                CanCloseE = false;
                OnPropertyChanged("CanCloseE");

                if (words.areEqual())
                {
                    level++;
                    if (level == 6)
                    {
                        dispatcherTimer.Stop();
                        MessageBox.Show("Congrats! You won! :)");
                    }
                    else
                    {
                        ResetLevel();
                    }
                }

            }
            else
            {
                noMistakes++;
                if (noMistakes == 7)
                {
                    level = 1;
                    MessageBox.Show("You lost the game :(");
                    ResetLevel();
                }
                else
                {
                    imageSource = "D:/Facultate/Anul2/Semestrul2/MVP/Tema2/Hangman/Hangman/Images/hangman" + noMistakes + ".png";
                    OnPropertyChanged("imageSource");

                    mistakes.Add('X');
                    OnPropertyChanged("mistakes");

                    CanCloseE = false;
                    OnPropertyChanged("CanCloseE");
                }

            }

        }
        public ICommand e
        {
            get
            {
                if (_E == null)
                    _E = new RelayCommands(E);
                return _E;
            }
        }


        public void F(object param)
        {
            if (words.CurrentWord.IndexOf('F') != -1 || words.CurrentWord.IndexOf('f') != -1)
            {
                words.ReplaceCharacters('F');

                CanCloseF = false;
                OnPropertyChanged("CanCloseF");

                if (words.areEqual())
                {
                    level++;
                    if (level == 6)
                    {
                        dispatcherTimer.Stop();
                        MessageBox.Show("Congrats! You won! :)");
                    }
                    else
                    {
                        ResetLevel();
                    }
                }

            }
            else
            {
                noMistakes++;
                if (noMistakes == 7)
                {
                    level = 1;
                    MessageBox.Show("You lost the game :(");
                    ResetLevel();
                }
                else
                {
                    imageSource = "D:/Facultate/Anul2/Semestrul2/MVP/Tema2/Hangman/Hangman/Images/hangman" + noMistakes + ".png";
                    OnPropertyChanged("imageSource");

                    mistakes.Add('X');
                    OnPropertyChanged("mistakes");

                    CanCloseF = false;
                    OnPropertyChanged("CanCloseF");
                }

            }
            
        }
        public ICommand f
        {
            get
            {
                if (_F == null)
                    _F = new RelayCommands(F);
                return _F;
            }
        }



        public void G(object param)
        {
            if (words.CurrentWord.IndexOf('G') != -1 || words.CurrentWord.IndexOf('g') != -1)
            {
                words.ReplaceCharacters('G');

                CanCloseG = false;
                OnPropertyChanged("CanCloseG");

                if (words.areEqual())
                {
                    level++;
                    if (level == 6)
                    {
                        dispatcherTimer.Stop();
                        MessageBox.Show("Congrats! You won! :)");
                    }
                    else
                    {
                        ResetLevel();
                    }
                }

            }
            else
            {
                noMistakes++;
                if (noMistakes == 7)
                {
                    level = 1;
                    MessageBox.Show("You lost the game :(");
                    ResetLevel();
                }
                else
                {
                    imageSource = "D:/Facultate/Anul2/Semestrul2/MVP/Tema2/Hangman/Hangman/Images/hangman" + noMistakes + ".png";
                    OnPropertyChanged("imageSource");

                    mistakes.Add('X');
                    OnPropertyChanged("mistakes");


                    CanCloseG = false;
                    OnPropertyChanged("CanCloseG");
                }

            }

        }
        public ICommand g
        {
            get
            {
                if (_G == null)
                    _G = new RelayCommands(G);
                return _G;
            }
        }



        public void H(object param)
        {
            if (words.CurrentWord.IndexOf('H') != -1 || words.CurrentWord.IndexOf('h') != -1)
            {
                words.ReplaceCharacters('H');

                CanCloseH = false;
                OnPropertyChanged("CanCloseH");

                if (words.areEqual())
                {
                    level++;
                    if (level == 6)
                    {
                        dispatcherTimer.Stop();
                        MessageBox.Show("Congrats! You won! :)");
                    }
                    else
                    {
                        ResetLevel();
                    }
                }

            }
            else
            {
                noMistakes++;
                if (noMistakes == 7)
                {
                    level = 1;
                    MessageBox.Show("You lost the game :(");
                    ResetLevel();
                }
                else
                {
                    imageSource = "D:/Facultate/Anul2/Semestrul2/MVP/Tema2/Hangman/Hangman/Images/hangman" + noMistakes + ".png";
                    OnPropertyChanged("imageSource");

                    mistakes.Add('X');
                    OnPropertyChanged("mistakes");

                    CanCloseH = false;
                    OnPropertyChanged("CanCloseH");
                }

            }

        }
        public ICommand h
        {
            get
            {
                if (_H == null)
                    _H = new RelayCommands(H);
                return _H;
            }
        }



        public void I(object param)
        {
            if (words.CurrentWord.IndexOf('I') != -1 || words.CurrentWord.IndexOf('i') != -1)
            {
                words.ReplaceCharacters('I');

                CanCloseI = false;
                OnPropertyChanged("CanCloseI");

                if (words.areEqual())
                {
                    level++;
                    if (level == 6)
                    {
                        dispatcherTimer.Stop();
                        MessageBox.Show("Congrats! You won! :)");
                    }
                    else
                    {
                        ResetLevel();
                    }
                }

            }
            else
            {
                noMistakes++;
                if (noMistakes == 7)
                {
                    level = 1;
                    MessageBox.Show("You lost the game :(");
                    ResetLevel();
                }
                else
                {
                    imageSource = "D:/Facultate/Anul2/Semestrul2/MVP/Tema2/Hangman/Hangman/Images/hangman" + noMistakes + ".png";
                    OnPropertyChanged("imageSource");

                    mistakes.Add('X');
                    OnPropertyChanged("mistakes");

                    CanCloseI = false;
                    OnPropertyChanged("CanCloseI");
                }

            }

        }
        public ICommand i
        {
            get
            {
                if (_I == null)
                    _I = new RelayCommands(I);
                return _I;
            }
        }



        public void J(object param)
        {
            if (words.CurrentWord.IndexOf('J') != -1 || words.CurrentWord.IndexOf('j') != -1)
            {
                words.ReplaceCharacters('J');

                CanCloseJ = false;
                OnPropertyChanged("CanCloseJ");

                if (words.areEqual())
                {
                    level++;
                    if (level == 6)
                    {
                        dispatcherTimer.Stop();
                        MessageBox.Show("Congrats! You won! :)");
                    }
                    else
                    {
                        ResetLevel();
                    }
                }

            }
            else
            {
                noMistakes++;
                if (noMistakes == 7)
                {
                    level = 1;
                    MessageBox.Show("You lost the game :(");
                    ResetLevel();
                }
                else
                {
                    imageSource = "D:/Facultate/Anul2/Semestrul2/MVP/Tema2/Hangman/Hangman/Images/hangman" + noMistakes + ".png";
                    OnPropertyChanged("imageSource");

                    mistakes.Add('X');
                    OnPropertyChanged("mistakes");


                    CanCloseJ = false;
                    OnPropertyChanged("CanCloseJ");
                }

            }

        }
        public ICommand j
        {
            get
            {
                if (_J == null)
                    _J = new RelayCommands(J);
                return _J;
            }
        }



        public void K(object param)
        {
            if (words.CurrentWord.IndexOf('K') != -1 || words.CurrentWord.IndexOf('k') != -1)
            {
                words.ReplaceCharacters('K');

                CanCloseK = false;
                OnPropertyChanged("CanCloseK");

                if (words.areEqual())
                {
                    level++;
                    if (level == 6)
                    {
                        dispatcherTimer.Stop();
                        MessageBox.Show("Congrats! You won! :)");
                    }
                    else
                    {
                        ResetLevel();
                    }
                }

            }
            else
            {
                noMistakes++;
                if (noMistakes == 7)
                {
                    level = 1;
                    MessageBox.Show("You lost the game :(");
                    ResetLevel();
                }
                else
                {
                    imageSource = "D:/Facultate/Anul2/Semestrul2/MVP/Tema2/Hangman/Hangman/Images/hangman" + noMistakes + ".png";
                    OnPropertyChanged("imageSource");

                    mistakes.Add('X');
                    OnPropertyChanged("mistakes");

                    CanCloseK = false;
                    OnPropertyChanged("CanCloseK");
                }

            }

 
        }
        public ICommand k
        {
            get
            {
                if (_K == null)
                    _K = new RelayCommands(K);
                return _K;
            }
        }



        public void L(object param)
        {
            if (words.CurrentWord.IndexOf('L') != -1 || words.CurrentWord.IndexOf('l') != -1)
            {
                words.ReplaceCharacters('L');

                CanCloseL = false;
                OnPropertyChanged("CanCloseL");

                if (words.areEqual())
                {
                    level++;
                    if (level == 6)
                    {
                        dispatcherTimer.Stop();
                        MessageBox.Show("Congrats! You won! :)");
                    }
                    else
                    {
                        ResetLevel();
                    }
                }

            }
            else
            {
                noMistakes++;
                if (noMistakes == 7)
                {
                    level = 1;
                    MessageBox.Show("You lost the game :(");
                    ResetLevel();
                }
                else
                {
                    imageSource = "D:/Facultate/Anul2/Semestrul2/MVP/Tema2/Hangman/Hangman/Images/hangman" + noMistakes + ".png";
                    OnPropertyChanged("imageSource");

                    mistakes.Add('X');
                    OnPropertyChanged("mistakes");

                    CanCloseL = false;
                    OnPropertyChanged("CanCloseL");
                }

            }

        }
        public ICommand l
        {
            get
            {
                if (_L == null)
                    _L = new RelayCommands(L);
                return _L;
            }
        }



        public void M(object param)
        {
            if (words.CurrentWord.IndexOf('M') != -1 || words.CurrentWord.IndexOf('m') != -1)
            {
                words.ReplaceCharacters('M');

                CanCloseM = false;
                OnPropertyChanged("CanCloseM");

                if (words.areEqual())
                {
                    level++;
                    if (level == 6)
                    {
                        dispatcherTimer.Stop();
                        MessageBox.Show("Congrats! You won! :)");
                    }
                    else
                    {
                        ResetLevel();
                    }
                }

            }
            else
            {
                noMistakes++;
                if (noMistakes == 7)
                {
                    level = 1;
                    MessageBox.Show("You lost the game :(");
                    ResetLevel();
                }
                else
                {
                    imageSource = "D:/Facultate/Anul2/Semestrul2/MVP/Tema2/Hangman/Hangman/Images/hangman" + noMistakes + ".png";
                    OnPropertyChanged("imageSource");

                    mistakes.Add('X');
                    OnPropertyChanged("mistakes");

                    CanCloseM = false;
                    OnPropertyChanged("CanCloseM");
                }

            }

 
        }
        public ICommand m
        {
            get
            {
                if (_M == null)
                    _M = new RelayCommands(M);
                return _M;
            }
        }


        public void N(object param)
        {
            if (words.CurrentWord.IndexOf('N') != -1 || words.CurrentWord.IndexOf('n') != -1)
            {
                words.ReplaceCharacters('N');

                CanCloseN = false;
                OnPropertyChanged("CanCloseN");

                if (words.areEqual())
                {
                    level++;
                    if (level == 6)
                    {
                        dispatcherTimer.Stop();
                        MessageBox.Show("Congrats! You won! :)");
                    }
                    else
                    {
                        ResetLevel();
                    }
                }

            }
            else
            {
                noMistakes++;
                if (noMistakes == 7)
                {
                    level = 1;
                    MessageBox.Show("You lost the game :(");
                    ResetLevel();
                }
                else
                {
                    imageSource = "D:/Facultate/Anul2/Semestrul2/MVP/Tema2/Hangman/Hangman/Images/hangman" + noMistakes + ".png";
                    OnPropertyChanged("imageSource");

                    mistakes.Add('X');
                    OnPropertyChanged("mistakes");

                    CanCloseN = false;
                    OnPropertyChanged("CanCloseN");
                }

            }


        }
        public ICommand n
        {
            get
            {
                if (_N == null)
                    _N = new RelayCommands(N);
                return _N;
            }
        }



        public void O(object param)
        {
            if (words.CurrentWord.IndexOf('O') != -1 || words.CurrentWord.IndexOf('o') != -1)
            {
                words.ReplaceCharacters('O');

                CanCloseO = false;
                OnPropertyChanged("CanCloseO");

                if (words.areEqual())
                {
                    level++;
                    if (level == 6)
                    {
                        dispatcherTimer.Stop();
                        MessageBox.Show("Congrats! You won! :)");
                    }
                    else
                    {
                        ResetLevel();
                    }
                }

            }
            else
            {
                noMistakes++;
                if (noMistakes == 7)
                {
                    level = 1;
                    MessageBox.Show("You lost the game :(");
                    ResetLevel();
                }
                else
                {
                    imageSource = "D:/Facultate/Anul2/Semestrul2/MVP/Tema2/Hangman/Hangman/Images/hangman" + noMistakes + ".png";
                    OnPropertyChanged("imageSource");

                    mistakes.Add('X');
                    OnPropertyChanged("mistakes");

                    CanCloseO = false;
                    OnPropertyChanged("CanCloseO");
                }

            }

 
        }
        public ICommand o
        {
            get
            {
                if (_O == null)
                    _O = new RelayCommands(O);
                return _O;
            }
        }



        public void P(object param)
        {
            if (words.CurrentWord.IndexOf('P') != -1 || words.CurrentWord.IndexOf('p') != -1)
            {
                words.ReplaceCharacters('P');

                CanCloseP = false;
                OnPropertyChanged("CanCloseP");

                if (words.areEqual())
                {
                    level++;
                    if (level == 6)
                    {
                        dispatcherTimer.Stop();
                        MessageBox.Show("Congrats! You won! :)");
                    }
                    else
                    {
                        ResetLevel();
                    }
                }

            }
            else
            {
                noMistakes++;
                if (noMistakes == 7)
                {
                    level = 1;
                    MessageBox.Show("You lost the game :(");
                    ResetLevel();
                }
                else
                {
                    imageSource = "D:/Facultate/Anul2/Semestrul2/MVP/Tema2/Hangman/Hangman/Images/hangman" + noMistakes + ".png";
                    OnPropertyChanged("imageSource");

                    mistakes.Add('X');
                    OnPropertyChanged("mistakes");

                    CanCloseP = false;
                    OnPropertyChanged("CanCloseP");
                }

            }

        }
        public ICommand p
        {
            get
            {
                if (_P == null)
                    _P = new RelayCommands(P);
                return _P;
            }
        }



        public void Q(object param)
        {
            if (words.CurrentWord.IndexOf('Q') != -1 || words.CurrentWord.IndexOf('q') != -1)
            {
                words.ReplaceCharacters('Q');

                CanCloseQ = false;
                OnPropertyChanged("CanCloseQ");

                if (words.areEqual())
                {
                    level++;
                    if (level == 6)
                    {
                        dispatcherTimer.Stop();
                        MessageBox.Show("Congrats! You won! :)");
                    }
                    else
                    {
                        ResetLevel();
                    }
                }

            }
            else
            {
                noMistakes++;
                if (noMistakes == 7)
                {
                    level = 1;
                    MessageBox.Show("You lost the game :(");
                    ResetLevel();
                }
                else
                {
                    imageSource = "D:/Facultate/Anul2/Semestrul2/MVP/Tema2/Hangman/Hangman/Images/hangman" + noMistakes + ".png";
                    OnPropertyChanged("imageSource");

                    mistakes.Add('X');
                    OnPropertyChanged("mistakes");

                    CanCloseQ = false;
                    OnPropertyChanged("CanCloseQ");
                }

            }

        }
        public ICommand q
        {
            get
            {
                if (_Q == null)
                    _Q = new RelayCommands(Q);
                return _Q;
            }
        }



        public void R(object param)
        {
            if (words.CurrentWord.IndexOf('R') != -1 || words.CurrentWord.IndexOf('r') != -1)
            {
                words.ReplaceCharacters('R');

                CanCloseR = false;
                OnPropertyChanged("CanCloseR");

                if (words.areEqual())
                {
                    level++;
                    if (level == 6)
                    {
                        dispatcherTimer.Stop();
                        MessageBox.Show("Congrats! You won! :)");
                    }
                    else
                    {
                        ResetLevel();
                    }
                }

            }
            else
            {
                noMistakes++;
                if (noMistakes == 7)
                {
                    level = 1;
                    MessageBox.Show("You lost the game :(");
                    ResetLevel();
                }
                else
                {
                    imageSource = "D:/Facultate/Anul2/Semestrul2/MVP/Tema2/Hangman/Hangman/Images/hangman" + noMistakes + ".png";
                    OnPropertyChanged("imageSource");

                    mistakes.Add('X');
                    OnPropertyChanged("mistakes");

                    CanCloseR = false;
                    OnPropertyChanged("CanCloseR");
                }

            }

        }
        public ICommand r
        {
            get
            {
                if (_R == null)
                    _R = new RelayCommands(R);
                return _R;
            }
        }



        public void S(object param)
        {
            if (words.CurrentWord.IndexOf('S') != -1 || words.CurrentWord.IndexOf('s') != -1)
            {
                words.ReplaceCharacters('S');

                CanCloseS = false;
                OnPropertyChanged("CanCloseS");

                if (words.areEqual())
                {
                    level++;
                    if (level == 6)
                    {
                        dispatcherTimer.Stop();
                        MessageBox.Show("Congrats! You won! :)");
                    }
                    else
                    {
                        ResetLevel();
                    }
                }

            }
            else
            {
                noMistakes++;
                if (noMistakes == 7)
                {
                    level = 1;
                    MessageBox.Show("You lost the game :(");
                    ResetLevel();
                }
                else
                {
                    imageSource = "D:/Facultate/Anul2/Semestrul2/MVP/Tema2/Hangman/Hangman/Images/hangman" + noMistakes + ".png";
                    OnPropertyChanged("imageSource");

                    mistakes.Add('X');
                    OnPropertyChanged("mistakes");

                    CanCloseS = false;
                    OnPropertyChanged("CanCloseS");
                }

            }

        }
        public ICommand s
        {
            get
            {
                if (_S == null)
                    _S = new RelayCommands(S);
                return _S;
            }
        }



        public void T(object param)
        {
            if (words.CurrentWord.IndexOf('T') != -1 || words.CurrentWord.IndexOf('t') != -1)
            {
                words.ReplaceCharacters('T');

                CanCloseT = false;
                OnPropertyChanged("CanCloseT");

                if (words.areEqual())
                {
                    level++;
                    if (level == 6)
                    {
                        dispatcherTimer.Stop();
                        MessageBox.Show("Congrats! You won! :)");
                    }
                    else
                    {
                        ResetLevel();
                    }
                }

            }
            else
            {
                noMistakes++;
                if (noMistakes == 7)
                {
                    level = 1;
                    MessageBox.Show("You lost the game :(");
                    ResetLevel();
                }
                else
                {
                    imageSource = "D:/Facultate/Anul2/Semestrul2/MVP/Tema2/Hangman/Hangman/Images/hangman" + noMistakes + ".png";
                    OnPropertyChanged("imageSource");

                    mistakes.Add('X');
                    OnPropertyChanged("mistakes");

                    CanCloseT = false;
                    OnPropertyChanged("CanCloseT");
                }

            }

        }
        public ICommand t
        {
            get
            {
                if (_T == null)
                    _T = new RelayCommands(T);
                return _T;
            }
        }



        public void U(object param)
        {
            if (words.CurrentWord.IndexOf('U') != -1 || words.CurrentWord.IndexOf('u') != -1)
            {
                words.ReplaceCharacters('U');

                CanCloseU = false;
                OnPropertyChanged("CanCloseU");

                if (words.areEqual())
                {
                    level++;
                    if (level == 6)
                    {
                        dispatcherTimer.Stop();
                        MessageBox.Show("Congrats! You won! :)");
                    }
                    else
                    {
                        ResetLevel();
                    }
                }

            }
            else
            {
                noMistakes++;
                if (noMistakes == 7)
                {
                    level = 1;
                    MessageBox.Show("You lost the game :(");
                    ResetLevel();
                }
                else
                {
                    imageSource = "D:/Facultate/Anul2/Semestrul2/MVP/Tema2/Hangman/Hangman/Images/hangman" + noMistakes + ".png";
                    OnPropertyChanged("imageSource");

                    mistakes.Add('X');
                    OnPropertyChanged("mistakes");

                    CanCloseU = false;
                    OnPropertyChanged("CanCloseU");
                }

            }

        }
        public ICommand u
        {
            get
            {
                if (_U == null)
                    _U = new RelayCommands(U);
                return _U;
            }
        }



        public void V(object param)
        {
            if (words.CurrentWord.IndexOf('V') != -1 || words.CurrentWord.IndexOf('v') != -1)
            {
                words.ReplaceCharacters('V');

                CanCloseV = false;
                OnPropertyChanged("CanCloseV");

                if (words.areEqual())
                {
                    level++;
                    if (level == 6)
                    {
                        dispatcherTimer.Stop();
                        MessageBox.Show("Congrats! You won! :)");
                    }
                    else
                    {
                        ResetLevel();
                    }
                }

            }
            else
            {
                noMistakes++;
                if (noMistakes == 7)
                {
                    level = 1;
                    MessageBox.Show("You lost the game :(");
                    ResetLevel();
                }
                else
                {
                    imageSource = "D:/Facultate/Anul2/Semestrul2/MVP/Tema2/Hangman/Hangman/Images/hangman" + noMistakes + ".png";
                    OnPropertyChanged("imageSource");

                    mistakes.Add('X');
                    OnPropertyChanged("mistakes");

                    CanCloseV = false;
                    OnPropertyChanged("CanCloseV");
                }

            }

        }
        public ICommand v
        {
            get
            {
                if (_V == null)
                    _V = new RelayCommands(V);
                return _V;
            }
        }



        public void W(object param)
        {
            if (words.CurrentWord.IndexOf('W') != -1 || words.CurrentWord.IndexOf('w') != -1)
            {
                words.ReplaceCharacters('W');

                CanCloseW = false;
                OnPropertyChanged("CanCloseW");

                if (words.areEqual())
                {
                    level++;
                    if (level == 6)
                    {
                        dispatcherTimer.Stop();
                        MessageBox.Show("Congrats! You won! :)");
                    }
                    else
                    {
                        ResetLevel();
                    }
                }

            }
            else
            {
                noMistakes++;
                if (noMistakes == 7)
                {
                    level = 1;
                    MessageBox.Show("You lost the game :(");
                    ResetLevel();
                }
                else
                {
                    imageSource = "D:/Facultate/Anul2/Semestrul2/MVP/Tema2/Hangman/Hangman/Images/hangman" + noMistakes + ".png";
                    OnPropertyChanged("imageSource");

                    mistakes.Add('X');
                    OnPropertyChanged("mistakes");

                    CanCloseW = false;
                    OnPropertyChanged("CanCloseW");
                }

            }

        }
        public ICommand w
        {
            get
            {
                if (_W == null)
                    _W = new RelayCommands(W);
                return _W;
            }
        }



        public void X(object param)
        {
            if (words.CurrentWord.IndexOf('X') != -1 || words.CurrentWord.IndexOf('x') != -1)
            {
                words.ReplaceCharacters('X');

                CanCloseX = false;
                OnPropertyChanged("CanCloseX");

                if (words.areEqual())
                {
                    level++;
                    if (level == 6)
                    {
                        dispatcherTimer.Stop();
                        MessageBox.Show("Congrats! You won! :)");
                    }
                    else
                    {
                        ResetLevel();
                    }
                }

            }
            else
            {
                noMistakes++;
                if (noMistakes == 7)
                {
                    level = 1;
                    MessageBox.Show("You lost the game :(");
                    ResetLevel();
                }
                else
                {
                    imageSource = "D:/Facultate/Anul2/Semestrul2/MVP/Tema2/Hangman/Hangman/Images/hangman" + noMistakes + ".png";
                    OnPropertyChanged("imageSource");

                    mistakes.Add('X');
                    OnPropertyChanged("mistakes");

                    CanCloseX = false;
                    OnPropertyChanged("CanCloseX");
                }

            }

        }
        public ICommand x
        {
            get
            {
                if (_X == null)
                    _X = new RelayCommands(X);
                return _X;
            }
        }

        public void Y(object param)
        {
            if (words.CurrentWord.IndexOf('Y') != -1 || words.CurrentWord.IndexOf('y') != -1)
            {
                words.ReplaceCharacters('Y');

                CanCloseY = false;
                OnPropertyChanged("CanCloseY");

                if (words.areEqual())
                {
                    level++;
                    if (level == 6)
                    {
                        dispatcherTimer.Stop();
                        MessageBox.Show("Congrats! You won! :)");
                    }
                    else
                    {
                        ResetLevel();
                    }
                }

            }
            else
            {
                noMistakes++;
                if (noMistakes == 7)
                {
                    level = 1;
                    MessageBox.Show("You lost the game :(");
                    ResetLevel();
                }
                else
                {
                    imageSource = "D:/Facultate/Anul2/Semestrul2/MVP/Tema2/Hangman/Hangman/Images/hangman" + noMistakes + ".png";
                    OnPropertyChanged("imageSource");

                    mistakes.Add('X');
                    OnPropertyChanged("mistakes");

                    CanCloseY = false;
                    OnPropertyChanged("CanCloseY");
                }

            }

        }
        public ICommand y
        {
            get
            {
                if (_Y == null)
                    _Y = new RelayCommands(Y);
                return _Y;
            }
        }



        public void Z(object param)
        {
            if (words.CurrentWord.IndexOf('Z') != -1 || words.CurrentWord.IndexOf('z') != -1)
            {
                words.ReplaceCharacters('Z');

                CanCloseZ = false;
                OnPropertyChanged("CanCloseZ");

                if (words.areEqual())
                {
                    level++;
                    if (level == 6)
                    {
                        dispatcherTimer.Stop();
                        MessageBox.Show("Congrats! You won! :)");
                    }
                    else
                    {
                        ResetLevel();
                    }
                }

            }
            else
            {
                noMistakes++;
                if (noMistakes == 7)
                {
                    level = 1;
                    MessageBox.Show("You lost the game :(");
                    ResetLevel();
                }
                else
                {
                    imageSource = "D:/Facultate/Anul2/Semestrul2/MVP/Tema2/Hangman/Hangman/Images/hangman" + noMistakes + ".png";
                    OnPropertyChanged("imageSource");

                    mistakes.Add('X');
                    OnPropertyChanged("mistakes");

                    CanCloseZ = false;
                    OnPropertyChanged("CanCloseZ");
                }

            }

        }
        public ICommand z
        {
            get
            {
                if (_Z == null)
                    _Z = new RelayCommands(Z);
                return _Z;
            }
        }

        #endregion


    }
}
