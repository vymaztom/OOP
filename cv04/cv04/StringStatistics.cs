using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv04
{
    class StringStatistics
    {
        private string inputString;
        private int sumWord = 0;
        private int sumRows = 0;
        private int sumSentence = 0;
        private List<string> longestWord = new List<string>();
        private int longestWordSize = 0;
        private List<string> shortestWord = new List<string>();
        private int shortestWordSize = int.MaxValue;
        private string[] alfabetWord;
        private bool inficeted = false;

        public StringStatistics(string inputString)
        {
            this.inputString = inputString;
            char[] separators;
            string[] list;

            // calcule sum lines
            separators = new char[] { '\n' };
            list = inputString.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            sumRows = list.Length;

            // calcule sum senteces
            separators = new char[] { '.', '!', '?' };
            list = inputString.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < list.Length; i++)
            {
                if ((i + 1) < list.Length)
                {
                    //Console.WriteLine(list[i + 1].ToCharArray()[1]);
                    if (Char.IsUpper(list[i + 1].ToCharArray()[1]))
                    {
                        sumSentence++;
                    }
                }
                else
                {
                    sumSentence++;
                }
            }

            // calcule sum words
            separators = new char[] { ' ', '.', ',', ';', '!', '?', '\n', '(', ')' };
            list = inputString.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            sumWord = list.Length;

            // find longist word and shortest
            foreach (string item in list)
            {
                if (longestWordSize == item.Length)
                {
                    longestWord.Add(item);
                }
                if (longestWordSize < item.Length)
                {
                    longestWord = new List<string>();
                    longestWord.Add(item);
                    longestWordSize = item.Length;
                }



                if (shortestWordSize == item.Length)
                {
                    shortestWord.Add(item);
                }
                if (shortestWordSize > item.Length)
                {
                    shortestWord = new List<string>();
                    shortestWord.Add(item);
                    shortestWordSize = item.Length;
                }

            }

            Array.Sort(list);
            alfabetWord = list;

            inficeted = inputString.Contains("koronavirus");


           


        }
 
        public int SumWord { get { return sumWord; } }
        public int SumRows { get { return sumRows; } }
        public int SumSentence { get { return sumSentence; } }
        public bool Inficeted { get { return inficeted; } }

        public string LongestWord {
            get {
                StringBuilder buffer = new StringBuilder("");
                foreach (string item in longestWord)
                {
                    buffer.Append(item);
                }
                return buffer.ToString();
            }
        }

        public string ShortestWord
        {
            get
            {
                StringBuilder buffer = new StringBuilder("");
                foreach (string item in shortestWord)
                {
                    buffer.Append(item);
                    buffer.Append(" ");
                }
                return buffer.ToString();
            }
        }

        public string AlfabetWord
        {
            get
            {
                StringBuilder buffer = new StringBuilder("");
                for (int i = 0; i < alfabetWord.Length; i++)
                {
                    if (i != 0) {
                        buffer.Append(" ,");
                    }
                    buffer.Append(alfabetWord[i]);
                }
                return buffer.ToString();
            }
        }
    }

}




    

   




