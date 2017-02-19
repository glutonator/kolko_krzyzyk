using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
//using System.Linq;

namespace kolko
{
    public sealed class Board
    {
        //private string board_string;
        private int iterator;
        //private ArrayList board_array;
        //private Hashtable board_hashtbale;
        private Dictionary<int, string> board_dictionary;
        private string default_area;
        //singleton
        private static readonly Board instace = new Board();
        private Board()
        {
            init();
        }
        public static Board Instace
        {
            get
            {
                return instace;
            }
        }
        //koniec deklaracji singletona

        public void init()
        {
            iterator = 0;
            default_area = "_";
            board_dictionary = new Dictionary<int, string>(9);

            for (int i = 1; i < 10; i++)
            {
                //string pom = i.ToString();
                string pom = "_";
                board_dictionary.Add(i, pom);
            }
        }


        public int get_iterator()
        {
            return iterator;
        }
        public void set_board_hashtbale(int _iterator, string _charrr)
        {
            iterator++;
            //get_iterator();
            //board_dictionary.Wh
            //int i = 5;

            //tutaj coś jeszcze nie działa z tym wyszukiwaniem
            //ogarnąć jak zrobic zmianę wratosci
            //object ggg = board_dictionary.Where(i => { return i.Key == 2; } );
            board_dictionary[_iterator] = _charrr;
            //ggg.
            //board_dictionary.where();
            Console.Write("");
            print();

        }

        public bool is_set_board_hashtbale(int _iterator)
        {
            //warunki czy jest juz uzupełnione pole

            //to jest długi sposób
            //if (board_dictionary.Contains<KeyValuePair<int, string>>(new KeyValuePair<int, string>(_iterator, "X")))

            //krótki sposób
            //if (board_dictionary.Contains(new KeyValuePair<int, string>(_iterator, "X")))
            if(board_dictionary.FirstOrDefault(x => x.Key.Equals(_iterator)).Value =="X")
            {
                Console.WriteLine("duzo XXXXXXXXXXXXXX");
                return true;
            }
            //if (board_dictionary.Contains(new KeyValuePair<int, string>(_iterator, "O")))
            if(board_dictionary.FirstOrDefault(x => x.Key.Equals(_iterator)).Value =="O")
            {
                Console.WriteLine("duzo OOOOOOOOOOOOO");
                return true;
            }
            return false;
        }

        public void print()
        {
            Console.Clear();
            for (int i = 0; i < 3; i++)
            {
                Console.Write(board_dictionary[7 + i]);
            }
            Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {
                Console.Write(board_dictionary[4 + i]);
            }
            Console.WriteLine();

            for (int i = 0; i < 3; i++)
            {
                Console.Write(board_dictionary[1 + i]);
            }
            Console.WriteLine();

        }

        public bool is_win()
        {
            //pionowo
            for (int i = 0; i < 3; i++)
            {
                if ((board_dictionary.FirstOrDefault(x => x.Key.Equals(7 + i)).Value == board_dictionary.FirstOrDefault(x => x.Key.Equals(4 + i)).Value) &&
                    (board_dictionary.FirstOrDefault(x => x.Key.Equals(4 + i)).Value == board_dictionary.FirstOrDefault(x => x.Key.Equals(1 + i)).Value) &&
                    (board_dictionary.FirstOrDefault(x => x.Key.Equals(4 + i)).Value != default_area))
                {
                    return true;
                }
            }
            //poziomo
            for (int i = 0; i < 3; i++)
            {
                if ((board_dictionary.FirstOrDefault(x => x.Key.Equals(1 + 3 * i)).Value == board_dictionary.FirstOrDefault(x => x.Key.Equals(2 + 3 * i)).Value) &&
                    (board_dictionary.FirstOrDefault(x => x.Key.Equals(2 + 3 * i)).Value == board_dictionary.FirstOrDefault(x => x.Key.Equals(3 + 3 * i)).Value) &&
                    (board_dictionary.FirstOrDefault(x => x.Key.Equals(2 + 3 * i)).Value != default_area))
                {
                    return true;
                }
            }

            //7-5-3
            if ((board_dictionary.FirstOrDefault(x => x.Key.Equals(7)).Value == board_dictionary.FirstOrDefault(x => x.Key.Equals(5)).Value) &&
                    (board_dictionary.FirstOrDefault(x => x.Key.Equals(5)).Value == board_dictionary.FirstOrDefault(x => x.Key.Equals(3)).Value) &&
                    (board_dictionary.FirstOrDefault(x => x.Key.Equals(5)).Value != default_area))
            {
                return true;
            }

            //9-5-1
            if ((board_dictionary.FirstOrDefault(x => x.Key.Equals(9)).Value == board_dictionary.FirstOrDefault(x => x.Key.Equals(5)).Value) &&
                    (board_dictionary.FirstOrDefault(x => x.Key.Equals(5)).Value == board_dictionary.FirstOrDefault(x => x.Key.Equals(1)).Value) &&
                    (board_dictionary.FirstOrDefault(x => x.Key.Equals(5)).Value != default_area))
            {
                return true;
            }
            //jak żaden warunke nie jest spełniony
            return false;
        }
    }
}
