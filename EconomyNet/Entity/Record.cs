using System;

namespace EconomyNet.Entity
{
    public class Record
    {
        public string Description { get; set; }
        public byte Type { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public bool PaidOut { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime PaymentDate { get; set; }
    }
}
