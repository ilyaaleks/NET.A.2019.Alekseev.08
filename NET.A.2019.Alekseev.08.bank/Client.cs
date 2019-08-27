using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.A._2019.Alekseev._08.bank
{
    [Serializable]
    class Client
    {
        public readonly string firstName ;
        public readonly string lastName;

        public Client(string firstName, string lastName)
        {
            this.firstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
            this.lastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
        }
    }
}
