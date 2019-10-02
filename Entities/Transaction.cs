using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreApi.Entities
{
    public class Transaction
    {
        public long cardId { get; set; }
        public decimal value { get; set; }
        public DateTime dateTime { get; set; }

        public Transaction(long cardId, decimal value, DateTime dateTime)
        {
            this.cardId = cardId;
            this.value = value;
            this.dateTime = dateTime;
        }
    }
}
