//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VideoRentalStore.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class tbl_employee
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Name Field is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Father name Field is required")]
        public string Fname { get; set; }

        [Required(ErrorMessage = "Email Field is required")]
        //[EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone no. Field is required")]
        [MinLength(11, ErrorMessage = "Phone no should be 11 digit")]
        public string Mobile { get; set; }

        public string Description { get; set; }
    }
}

