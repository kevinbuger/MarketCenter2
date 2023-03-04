using MarketCenter.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketCenter.Domain.Entities
{
    public class Order : EntityBase
    {
        public int AccountId { get; set; }
        public decimal TotalPrice { get; set; }
        [MaxLength(30)]
        public string? CardName { get; set; }
        [MaxLength(30)]
        public string? CardNumber { get; set; }
        [MaxLength(20)]
        public string? Expiration { get; set; }
        [MaxLength(10)]
        public string? CVV { get; set; }
        [MaxLength(200)]
        public string? PaymentMethod { get; set; }
    }
}
