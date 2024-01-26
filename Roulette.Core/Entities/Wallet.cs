using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette.Core.Entities
{
    public class Wallet
    {
        public int Id { get; set; }
        public string PlayerId { get; set; }
        public decimal Balance { get; set; }

    }
}
