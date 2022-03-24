using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SimpleCrm1
{
    public class Customer
    {
        public int Id { get; set; }
        [Display(Name = "First Name"), Required, MaxLength(100)]
        public string FirstName { get; set; }
        [Display(Name = "Last Name"), Required, MaxLength(100)]
        public string LastName { get; set; }
        [Display(Name = "Phone Number"), DataType(DataType.PhoneNumber), Required, MinLength(7), MaxLength(12)]
        public string PhoneNumber { get; set; }
        [Display(Name = "Opt in newsletter")]
        public bool OptInNewsLetter { get; set; }
        [Display(Name = "Customer Type")]
        public CustomerType Type { get; set; }
    }
}
