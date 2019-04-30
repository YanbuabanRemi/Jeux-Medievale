using System;
using System.Collections.Generic;
using System.Text;

namespace Exo.Classes
{
    class Roturier
    {
        private int money;


        public int Money { get => money; set => money = value; }

        public Roturier()
        {
            Money = 100;
            
        }

        public bool ChanceToDie()
        {
            bool chanceToDieBool = false;
            int chanceToDie = RandomNumber(1, 50);

            if (chanceToDie == 1)
                chanceToDieBool = true;

            return chanceToDieBool;
        }

        public void Vieillir()
        {
                int gain = RandomNumber(10, 40);
                money = money + money * gain / 100;
                //Console.WriteLine(money);
        }

        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        public int PreleverImpotRoturier()
        {
            int impot;
            impot = money / 2;
            money -= impot;
            return impot;
        }
    }
}
