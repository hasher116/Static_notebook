using System;

namespace Static
{
    class Program
    {
        static void Main(string[] args)
        {
            Money.nadbavka = 144;

            Money money = new Money(-100);
            Console.WriteLine(money.Zarplata);
            Console.WriteLine(money.Itog);

            Money.nadbavka += 144;

            Money money2 = new Money(100);
            Console.WriteLine(money2.Zarplata);
            Console.WriteLine(money2.Itog);
        }
    }
    class Money
    {
        private int zarplata;

        public int Zarplata
        {
            get { return zarplata; }
            set { if (value > 0) zarplata = value;}
        }

        static public int nadbavka;
        public int Itog { get;}
        public Money(int Zarplata)
        {
            this.Zarplata = Zarplata;
            Itog = this.Zarplata + Money.nadbavka;
        }
    }
}
