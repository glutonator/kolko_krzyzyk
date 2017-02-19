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
            //Timer _timer;
            //_timer = new Timer(3000);
            //_timer.Elapsed += new ElapsedEventHandler(_timer_Elapsed);
            //_timer.Start();

            Console.BackgroundColor = ConsoleColor.DarkBlue;

            //!Console.KeyAvailable
            // while (!(Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Escape))
            {

            }
            Board.Instace.print();
            while (true)
            {//96-0    105-9
                if(Console.KeyAvailable)
                {
                    var input = Console.ReadKey();
                    //konwersja wciśnietego klawisza na int
                    if (char.IsDigit(input.KeyChar))
                    {
                        int input_digit = int.Parse(input.KeyChar.ToString());

                        if(Board.Instace.get_iterator()%2==0)
                        {
                            if (!(Board.Instace.is_set_board_hashtbale(input_digit)))
                            {
                                Board.Instace.set_board_hashtbale(input_digit, "X");
                            }
                        }
                        else
                        {
                            if(!(Board.Instace.is_set_board_hashtbale(input_digit)))
                            {
                                Board.Instace.set_board_hashtbale(input_digit, "O");
                            }
                        }
                    }
                    if(Board.Instace.is_win())
                    {
                        break;
                    }
                    
                    //Console.Clear();
                    //input = ConsoleKeyInfo.
                }
            }

            //koniec programu
            Console.WriteLine("Koniec gry");
            Console.ReadKey(true);

        }

        private static void _timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Console.Clear();
            //Board.Instace.set_board_hashtbale(2,"p");
            Board.Instace.print();


            //throw new NotImplementedException();
        }
    }
}
