using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.A._2019.Alekseev._08.bank
{
    class Program
    {
        static void Main(string[] args)
        {
     
            PlatinumCard card3 = new PlatinumCard(2141251, "Reket", "Gref", 280, 35);

            card3.MakeNewBill(17);
            Console.WriteLine(card3.ToString());
            foreach(Card card in CardStorage.AllCardsOfBank)
            {
                Console.WriteLine(card.ToString());
            }
        }
    }
}
