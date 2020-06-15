using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GIC_G2.Models
{
    public enum Qualification
    {

        [Display(Name = "Ph.D (Doctorate Degree)")]
        DC,
        [Display(Name = "Ms.c (Master of Science)")]
        Msc,
        [Display(Name = "B.sc ( Degree Certificate)")]
        Bsc,
        [Display(Name = "HND (Higher National Diploma)")]
        HND,
        [Display(Name = "NCE (Nigeria certificate in Education)")]
        NCE,
        [Display(Name = "OND (Ordinary National diploma)")]
        OND,
        [Display(Name = "WAEC (West Africa Exam...)")]
        WAEC

    }
}
