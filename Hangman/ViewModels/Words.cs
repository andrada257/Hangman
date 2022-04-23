using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman.ViewModels
{
    public class Words : BaseViewModel
    {
        public List<string> wordsList { get; set; }

        public string CurrentWord { get; set; }

        public string ShownedWord { get; set; }

        public Words()
        {
            wordsList = new List<string>()
            {
                "Ford", "Audi", "BMW", "Cadillac", "Mustang", "Tesla", "Volvo", "Toyota", "Volkswagen", "Lexus",
                "Titanic", "The Godfather", "Spiderman", "Finding Nemo", "Pretty women", "Inception", "Ironman", "Batman", "Interstellar", "The Matrix",
                "Sofia", "London", "Bucharest", "Washington", "Paris", "Berlin", "Rome", "Prague", "Kiew", "Moscow",
                "Ariana Grande", "Adele", "Lady Gaga", "The Weeknd", "Miley Cyrus", "Dua Lipa", "Britney Spears", "Rihanna", "Michael Jackson", "Freddie Mercury"

            };

            CurrentWord = "";
            ShownedWord = "";
        }

        public void AllCategories()
        {
            Random random = new Random();
            int index = random.Next(wordsList.Count);
            CurrentWord = wordsList[index];
            OnPropertyChanged("CurrentWord");
        }

        public void Cars()
        {
            Random random = new Random();
            int index = random.Next(10);
            CurrentWord = wordsList[index];
            OnPropertyChanged("CurrentWord");
        }

        public void Movies()
        {
            Random random = new Random();
            int index = random.Next(10, 20);
            CurrentWord = wordsList[index];
            OnPropertyChanged("CurrentWord");
        }

        public void Capitals()
        {
            Random random = new Random();
            int index = random.Next(20, 30);
            CurrentWord = wordsList[index];
            OnPropertyChanged("CurrentWord");
        }

        public void Singers()
        {
            Random random = new Random();
            int index = random.Next(30, 40);
            CurrentWord = wordsList[index];
            OnPropertyChanged("CurrentWord");
        }

        public void FindShownedWord()
        {
            string unknWord = "";

            foreach (char c in CurrentWord)
            {
                if (c == ' ')
                {
                    unknWord += ' ';
                    unknWord += ' ';
                    unknWord += ' ';
                }
                else
                {
                    unknWord += '-';
                    unknWord += ' ';
                    unknWord += ' ';
                }

            }

            ShownedWord = unknWord;
            OnPropertyChanged("ShownedWord");
        }


        public void ReplaceCharacters(char character1)
        {
           char character2 = Char.ToLower(character1);


           for(int index =0; index <CurrentWord.Length; index++)
           { 
                if (CurrentWord[index] == character1)
                {
                    ShownedWord = ShownedWord.Remove(index * 3, 1).Insert(index * 3, character1.ToString());
                }
                
                if(CurrentWord[index] == character2)
                {
                    ShownedWord = ShownedWord.Remove(index * 3, 1).Insert(index * 3, character2.ToString());
                }

            }

            OnPropertyChanged("ShownedWord");
           
        }

        public bool areEqual()
        {
            for(int i =0; i < CurrentWord.Length; i++)
            {
                if(CurrentWord[i] != ShownedWord[i*3])
                    return false;
            }

            return true;
        }


    }
   

}
