using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mainMon
{
    class mainlogo
    {
        //▼게임 로고
        string title = " /\\  /\\  /\\  /\\  /\\  /\\  /\\  /\\  /\\  /\\  /\\  /\\  /\\  /\\  /\\  /\\  /\\  /\\  /\\  /\\  /\\ \r\n//\\\\//\\\\//\\\\//\\\\//\\\\//\\\\//\\\\//\\\\//\\\\//\\\\//\\\\//\\\\//\\\\//\\\\//\\\\//\\\\//\\\\//\\\\//\\\\//\\\\//\\\\\r\n\\\\//\\\\//\\\\//\\\\//\\\\//\\\\//\\\\//\\\\//\\\\//\\\\//\\\\//\\\\//\\\\//\\\\//\\\\//\\\\//\\\\//\\\\//\\\\//\\\\//\\\\//\r\n \\/  \\/  \\/  \\/  \\/  \\/  \\/  \\/  \\/  \\/  \\/  \\/  \\/  \\/  \\/  \\/  \\/  \\/  \\/  \\/  \\/ \r\n /\\                                                                              /\\ \r\n//\\\\      _         _   _        ____                 _     _ _                 //\\\\\r\n\\\\//     | |    ___| |_( )___   / ___| __ _ _ __ ___ | |__ | (_)_ __   __ _     \\\\//\r\n \\/      | |   / _ \\ __|// __| | |  _ / _` | '_ ` _ \\| '_ \\| | | '_ \\ / _` |     \\/ \r\n /\\      | |__|  __/ |_  \\__ \\ | |_| | (_| | | | | | | |_) | | | | | | (_| |     /\\ \r\n//\\\\     |_____\\___|\\__| |___/  \\____|\\__,_|_| |_| |_|_.__/|_|_|_| |_|\\__, |    //\\\\\r\n\\\\//                                                                  |___/     \\\\//\r\n \\/                                                                              \\/ \r\n /\\  /\\  /\\  /\\  /\\  /\\  /\\  /\\  /\\  /\\  /\\  /\\  /\\  /\\  /\\  /\\  /\\  /\\  /\\  /\\  /\\ \r\n//\\\\//\\\\//\\\\//\\\\//\\\\//\\\\//\\\\//\\\\//\\\\//\\\\//\\\\//\\\\//\\\\//\\\\//\\\\//\\\\//\\\\//\\\\//\\\\//\\\\//\\\\\r\n\\\\//\\\\//\\\\//\\\\//\\\\//\\\\//\\\\//\\\\//\\\\//\\\\//\\\\//\\\\//\\\\//\\\\//\\\\//\\\\//\\\\//\\\\//\\\\//\\\\//\\\\//\r\n \\/  \\/  \\/  \\/  \\/  \\/  \\/  \\/  \\/  \\/  \\/  \\/  \\/  \\/  \\/  \\/  \\/  \\/  \\/  \\/  \\/ ";
        //▼줄바꿈
        string lineBreak = "====================================================================================";
        //▼게임 끝
        string gameEnd = "   _      _      _      _      _      _      _      _      _      _   \r\n _( )_  _( )_  _( )_  _( )_  _( )_  _( )_  _( )_  _( )_  _( )_  _( )_ \r\n(_ o _)(_ o _)(_ o _)(_ o _)(_ o _)(_ o _)(_ o _)(_ o _)(_ o _)(_ o _)\r\n (_,_)  (_,_)  (_,_)  (_,_)  (_,_)  (_,_)  (_,_)  (_,_)  (_,_)  (_,_) \r\n   _                                                              _   \r\n _( )_       ____                        _____           _      _( )_ \r\n(_ o _)     / ___| __ _ _ __ ___   ___  | ____|_ __   __| |    (_ o _)\r\n (_,_)     | |  _ / _` | '_ ` _ \\ / _ \\ |  _| | '_ \\ / _` |     (_,_) \r\n   _       | |_| | (_| | | | | | |  __/ | |___| | | | (_| |       _   \r\n _( )_      \\____|\\__,_|_| |_| |_|\\___| |_____|_| |_|\\__,_|     _( )_ \r\n(_ o _)                                                        (_ o _)\r\n (_,_)                                                          (_,_) \r\n   _      _      _      _      _      _      _      _      _      _   \r\n _( )_  _( )_  _( )_  _( )_  _( )_  _( )_  _( )_  _( )_  _( )_  _( )_ \r\n(_ o _)(_ o _)(_ o _)(_ o _)(_ o _)(_ o _)(_ o _)(_ o _)(_ o _)(_ o _)\r\n (_,_)  (_,_)  (_,_)  (_,_)  (_,_)  (_,_)  (_,_)  (_,_)  (_,_)  (_,_) ";
        //▼돈없어서 게임 끝
        string gameOver = "   _      _      _      _      _      _      _      _      _      _      _   \r\n _( )_  _( )_  _( )_  _( )_  _( )_  _( )_  _( )_  _( )_  _( )_  _( )_  _( )_ \r\n(_ o _)(_ o _)(_ o _)(_ o _)(_ o _)(_ o _)(_ o _)(_ o _)(_ o _)(_ o _)(_ o _)\r\n (_,_)  (_,_)  (_,_)  (_,_)  (_,_)  (_,_)  (_,_)  (_,_)  (_,_)  (_,_)  (_,_) \r\n   _                                                                     _   \r\n _( )_         ____                         ___                        _( )_ \r\n(_ o _)       / ___| __ _ _ __ ___   ___   / _ \\__   _____ _ __       (_ o _)\r\n (_,_)       | |  _ / _` | '_ ` _ \\ / _ \\ | | | \\ \\ / / _ \\ '__|       (_,_) \r\n   _         | |_| | (_| | | | | | |  __/ | |_| |\\ V /  __/ |            _   \r\n _( )_        \\____|\\__,_|_| |_| |_|\\___|  \\___/  \\_/ \\___|_|          _( )_ \r\n(_ o _)                                                               (_ o _)\r\n (_,_)                                                                 (_,_) \r\n   _      _      _      _      _      _      _      _      _      _      _   \r\n _( )_  _( )_  _( )_  _( )_  _( )_  _( )_  _( )_  _( )_  _( )_  _( )_  _( )_ \r\n(_ o _)(_ o _)(_ o _)(_ o _)(_ o _)(_ o _)(_ o _)(_ o _)(_ o _)(_ o _)(_ o _)\r\n (_,_)  (_,_)  (_,_)  (_,_)  (_,_)  (_,_)  (_,_)  (_,_)  (_,_)  (_,_)  (_,_) ";
        

        public void Print() //게임 로고 출력
        {
            Console.Clear();
            Console.WriteLine(title);
            Console.WriteLine();
            Console.WriteLine(lineBreak);
        }
        public void PrintTitle() //시작화면
        {
            Print();
            Console.WriteLine("\n                              Enter 누르면 게임 시작");
        }
        public string PrintTitleName() //이름입력
        {
            
            Print();
            Console.Write("\n                            플레이어 네임 : ");
            string name = Console.ReadLine();
            return name;
        }
        public void MainStartLogo(string nickName, int money)
        {
            if (money <= 0)
            {
                Console.Clear();
                Console.WriteLine(gameEnd);
            }
            else
            {
                Print();
                Console.WriteLine($"\n플레이어 네임 : {nickName}");
                Console.WriteLine($"소지금 : {money}\n");
                Console.WriteLine("1번 게임 : 블랙잭");
                Console.WriteLine("ESC : 게임 종료");
                
            }
        }
        public void GameEnd(int money)
        {
            Console.Clear();
            if (money <= 0)
            {
                Console.WriteLine(gameEnd);
            }
            else
            {
                Console.WriteLine(gameOver);
            }
        }
    }
    class main
    {
        mainlogo logo = new mainlogo();
        string name { get; set; }

        public main()
        {
            logo.PrintTitle();
            KeyInput();
            name = logo.PrintTitleName();
            logo.MainStartLogo(name, 10000);
            GameChoice();
        }

        public void KeyInput()
        {
            ConsoleKeyInfo startKey;
            bool nextMain = true;
            while (nextMain)
            {
                startKey = Console.ReadKey(true);
                switch (startKey.Key)
                {
                    case ConsoleKey.Enter:
                        nextMain = false;
                        break;
                    default:
                        break;
                }
            }
        }

        public void GameChoice()
        {
            ConsoleKeyInfo gameKey;
            bool nextMain = true;
            while (nextMain)
            {
                gameKey = Console.ReadKey(true);
                switch (gameKey.Key)
                {
                    case ConsoleKey.D1:
                        nextMain = false;
                        break;
                    case ConsoleKey.D2:
                        nextMain = false;
                        break;
                    case ConsoleKey.Escape:
                        logo.GameEnd(0);
                        nextMain = false;
                        break;
                    default:
                        break;
                }
            }
        }
        

      
    }
}
