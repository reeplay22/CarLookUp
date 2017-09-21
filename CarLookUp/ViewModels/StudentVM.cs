using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarLookUp.Web.ViewModels
{
    public class StudentVM
    {
        [Required(ErrorMessage = "First name is required")]
        [MinLength(2, ErrorMessage = " First is required to have 2 letters")]
        [MaxLength(20, ErrorMessage = "First name is required to have 20 lettes at Most")]
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [DisplayName("Student Number")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Last name is required")]
        [MinLength(2, ErrorMessage = " Last is required to have 2 letters")]
        [MaxLength(20, ErrorMessage = "Last name is required to have 20 lettes at Most")]
        [DisplayName("Last Name")]
        public string LastName { get; set; }
    }
}
