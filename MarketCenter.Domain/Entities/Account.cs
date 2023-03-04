using MarketCenter.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketCenter.Domain.Entities
{
    public class Account : EntityBase
    {
        [MaxLength(50)]
        public string UserName { get; set; }
        public decimal Balance { get; set; }
        [MaxLength(50)]
        public string Country { get; set; }
        
        [MaxLength(100)]
        public string FullName { get; set; }
        [MaxLength(100)]
        public string Email { get; set; }
        [MaxLength(50)]
        public string AccountType { get; set; }
        [MaxLength(50)]
        public string Currency { get; set; }
        public bool IsDisabled { get; set; }
        public bool IsVirtual { get; set; }
        [MaxLength(50)]
        public string LandingCompanyName { get; set; }
        [MaxLength(50)]
        public string LoginId { get; set; }

        [MaxLength(200)]
        public string AddressLine { get; set; } 
        [MaxLength(50)]
        public string? State { get; set; }
        [MaxLength(50)]
        public string? ZipCode { get; set; }
    }
}
