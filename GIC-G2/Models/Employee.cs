using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GIC_G2.Models
{
    public class Employee
    {
        [Key]
        public long Id { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DataType(DataType.Text)]
        [Display(Name = "First Name")]
        [Required]
        public string FirstName { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [Column(TypeName = "nvarchar(100)")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Please enter a valid Email address")]
        [Display(Name = "Email Address")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"[0-9]{4}[0-9]{3}[0-9]{4}", ErrorMessage = "Phone number should be in this format XXXX-XXX-XXXX")]        
        public string Number { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(200)")]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Home Address")]
        public string Address { get; set; }
        
        public long TrackingNum { get; set; }

    }
}
