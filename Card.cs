using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mainMon
{
    class Card
    {
        private List<string> list = new List<string>(); //카드덱 생성
        private string[] nubers = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" }; //카드중 숫자
        private string[] mongu = { "◆", "♥", "♠", "♣" }; //카드중 문양

        private Random rnd = new Random(); 

        public List<string> CardDeck //카드덱 프로페서
        {
            get { return list; }
            set { list = value; }
        }
        
        public Card() //카드 생성자
        {
            MakeCard();
            MixCard();
            ShowCard();
        }

        public void MakeCard() //카드 만들기
        {
            for (int i = 0; i < nubers.Length; i++)
            {
                for (int j = 0; j < mongu.Length; j++)
                {
                    list.Add(mongu[j] + nubers[i]);
                }
            }
        }

        public void MixCard() //카드 섞기
        {

            for (int i = list.Count - 1; i > 0; i--)
            {
                int j = rnd.Next(0, i + 1);

                string temp = list[i];
                list[i] = list[j];
                list[j] = temp;
            }
        }

        public void ShowCard() //카드 보여주기
        {
            foreach (string s in list)
            {
                Console.WriteLine(s);
            }
        }
    }
}
