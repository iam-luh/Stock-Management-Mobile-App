using DataAnnotationsExtensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Management_Mobile_App.Components.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        [Email]
        public string? Email { get; set; }
        [Phone]
        public int PhoneNumber { get; set; }

    }
}
