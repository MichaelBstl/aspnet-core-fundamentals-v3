﻿using Microsoft.AspNetCore.Mvc;
namespace SimpleCrm1.Web.Models
{
    public class CustomerModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
    }
}
