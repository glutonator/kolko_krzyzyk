using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace kolko
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer _timer;
            _timer = new Timer(3000);
            _timer.Elapsed += new ElapsedEventHandler(_timer_Elapsed);
            _timer.Start();
            //string board;

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            //Board plansza = plansza.Instace();
            //object board=Board.Instace.get_board_string();
            //Console.Write(board);

            //!Console.KeyAvailable
            // while (!(Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Escape))
            {

            }
            Console.ReadKey(true);

        }

        private static void _timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Console.Clear();

            object board = Board.Instace.get_board_string();
            object buu = Board.Instace.get_iterator();
            Board.Instace.set_board_hashtbale(2,"p");
            //Console.Write(board);
            //Console.Write(buu);
            Board.Instace.print();


            //throw new NotImplementedException();
        }
    }
}
