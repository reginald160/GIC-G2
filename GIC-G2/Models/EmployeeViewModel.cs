using Castle.MicroKernel.SubSystems.Conversion;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace GIC_G2.Models
{
    public class EmployeeViewModel
    {

        [Column(TypeName = "nvarchar(100)")]
        [DataType(DataType.Text)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [Column(TypeName = "nvarchar(100)")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email Address")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Qualification")]
        public string HighestQualification { get; set; }

        public long TrackingNum { get; set; }
     
        public List<IFormFile> File { get; set; }
    }
}
