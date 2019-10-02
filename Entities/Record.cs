using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreApi.Entities
{
    public class Record
    {
        public string customer { get; set; }
        public string store { get; set; }
        public DateTime date { get; set; }
        public decimal value { get; set; }
        public string place { get; set; }

        public Record(string customer, string store, DateTime date, decimal value, string place)
        {
            this.customer = customer;
            this.store = store;
            this.date = date;
            this.value = value;
            this.place = place;
        }
    }
}
