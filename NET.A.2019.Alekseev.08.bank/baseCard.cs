using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.A._2019.Alekseev._08.bank
{
    [Serializable]
    class BaseCard : Card
    {
        public override void AddBill(double sum,int bill)
        {
            this.bills[bill] += sum;
            this.bonusBill +=Convert.ToInt32( sum / 100 * (int)TypeOfCard.Base);
        }
        public BaseCard(int number, string firstName, string lastName, double bill, int bonusBill)
            :base(number,firstName,lastName,bill,bonusBill,TypeOfCard.Base)
        {
            
        }
        
    }
}
