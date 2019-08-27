using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.A._2019.Alekseev._08.bank
{
    [Serializable]
    enum TypeOfCard
    {
        Base=1,
        Gold,
        Platinum
    }
    [Serializable]
    abstract class Card
    {

        protected int number;
        protected Client client;
        protected List<double> bills=new List<double>();
        protected int bonusBill;
        protected TypeOfCard type;
        static string path;
        public static CardStorage storage = new CardStorage();
        public Card(int number, string firstName, string lastName, double bill, int bonusBill, TypeOfCard type)
        {
            this.number = number;
            client = new Client(firstName, lastName);
            this.bills.Add(bill);
            this.bonusBill = bonusBill;
            this.type = type;
            
            AddCardToList();
        }
       
        public void AddCardToList()
        {
            storage.AddCard(this);
        }
        public abstract void AddBill(double sum, int bill);
        public  void WriteOffBill(double sum, int bill)
        {
            this.bills[bill] -= sum;
        }
        public void MakeNewBill(double startSum)
        {
            this.bills.Add(startSum);
        }
        public void CloseBill(int count)
        {
            if (this.bills[count] < 0)
            {
                throw new ArgumentException("negative balance");
            }
            this.bills.RemoveAt(count);
        }
        public override string ToString()
        {
            return $"Number: {number}, bill: {bills.ToArray().Sum()}, type: {this.type.ToString()}";
        }
        public override bool Equals(object obj)
        {
            if(!(obj is Card) || obj is null)
            {
                throw new ArgumentException("Null object");
            }
            Card card = obj as Card;
            return card.number == this.number;
        }
        public override int GetHashCode()
        {
            return this.number.GetHashCode();
        }
    }
}
