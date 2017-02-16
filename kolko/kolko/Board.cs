using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Linq;

namespace kolko
{
    public sealed class Board
    {
        //private string board_string;
        private int iterator;
        //private ArrayList board_array;
        //private Hashtable board_hashtbale;
        private Dictionary<int,string> board_dictionary;

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

        public void init ()
        {
            iterator = 0;
            board_dictionary = new Dictionary<int, string>(9);
            for (int i = 1; i < 10; i++)
            {
                string pom = i.ToString();
                board_dictionary.Add(i, pom);
            }
        }

 
        public int get_iterator()
        {
            return iterator;
        }
        public void set_board_hashtbale (int _iterator, string _charrr)
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

        }

        public bool is_set_board_hashtbale(int _iterator)
        {
            //board_dictionary.Contains(KeyValuePair< _iterator, "sss" >);
            //object oooo = new KeyValuePair<int, string>(2222, "dsds");
            //board_dictionary.Contains<int,string>(_iterator);
            //bool test = board_dictionary.Contains<KeyValuePair<int, string>>(new KeyValuePair<int, string>(_iterator, "X"));
            
            //warunki czy jest juz uzupełnione pole
            if(board_dictionary.Contains<KeyValuePair<int, string>>(new KeyValuePair<int, string>(_iterator, "X")))
            {
                Console.WriteLine("duzo XXXXXXXXXXXXXX");
                return true;
            }
            if(board_dictionary.Contains<KeyValuePair<int, string>>(new KeyValuePair<int, string>(_iterator, "O")))
            {
                Console.WriteLine("duzo OOOOOOOOOOOOO");
                return true;
            }
            return false;
        }

        public void print()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Write(board_dictionary[7+i]);
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
    }
}
