using SimpleCrm1;
using System.ComponentModel.DataAnnotations;

namespace SimpleCrm1.Web.Models.Home
{
    public class CustomerEditViewModel
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