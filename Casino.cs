using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mainMon
{
    class Casino
    {
        private MainLogo logo = new MainLogo(); //로고 가져오기
        private Money money = new Money(); //소지금
        private string name { get; set; } //닉네임

        public Casino() //실제 게임 생성자
        {
            logo.PrintTitle();
            KeyInput(1);
            name = logo.PrintTitleName();
            logo.MainStartLogo(name, money.PlayerMoney);
            KeyInput(2);
        }

        public void KeyInput(int page) //키를 누르면 실행
        {
            ConsoleKeyInfo startKey;
            bool nextMain = true;
            
            while (nextMain)
            {
                startKey = Console.ReadKey(true);
                if (page == 1)
                {
                    switch (startKey.Key)
                    {
                        case ConsoleKey.Enter:
                            nextMain = false;
                            break;
                        default:
                            break;
                    }
                }
                if (page == 2)
                {
                    switch (startKey.Key)
                    {
                        case ConsoleKey.D1:
                            Blackject blackject = new Blackject();
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
}
