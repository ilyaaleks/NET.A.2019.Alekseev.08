using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace NET.A._2019.Alekseev._08.bank
{
    [Serializable]
    class CardStorage
    {
        static List<Card> allCardsOfBank = new List<Card>();
        public static List<Card> AllCardsOfBank
        {
            get
            {
                
                return allCardsOfBank;
            }
            
        }
        static string path;
        static CardStorage()
        {
            Console.WriteLine("Enter the path");
            path=Console.ReadLine();
            if(path==null)
            {
                throw new ArgumentException("Null string");
            }
        }
        public CardStorage()
        {
            LoadCards();
        }
        public void AddCard(Card card)
        {
            if (!allCardsOfBank.Contains(card))
            {
                allCardsOfBank.Add(card);
                SaveCards();
            }
            else
            {
                throw new ArgumentException("This bank card exists");
            }
        }
        public void SaveCards()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                formatter.Serialize(fs, allCardsOfBank);

                Console.WriteLine("Cards saved");
            }

        }
        public void LoadCards()
        {
            if (File.Exists(path))
                if(new FileInfo(path).Length != 0)
            {
                BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                
                    allCardsOfBank = (List<Card>)formatter.Deserialize(fs);

                    Console.WriteLine("Cards loaded");
                }
            }
        }
    }
}
