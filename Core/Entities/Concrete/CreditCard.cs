using Core.Entities;
using Core.Entities.Concrete;
using System;

namespace Core.Entities
{
    public class CreditCard : BaseEntity
    {
        public string CardType { get; set; }
        public int CardNumber { get; set; }
        public int CVC { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime EndDate { get; set; }
        public Guid UserId { get; set; }

        public virtual User User { get; set; }
    }
}
