using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCApplication.Models
{
    public class Course
    {
        public int Id { get; set; }
        // Name must be included.
        [Required]
        public string Name  { get; set; }
        // Description has a max of 100 chars.
        [StringLength(100)]
        public string Description{ get; set; }
        // Customised label to Online Course
        [Display(Name="Online Course")]
        public bool IsVirtual { get; set; }
    }
}