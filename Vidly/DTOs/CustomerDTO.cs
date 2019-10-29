using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.DTOs
{
    public class CustomerDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter customer's name.")]
        [StringLength(255)]
        public string Name { get; set; }

        [Display(Name = "Date of Birth")]
        [Min18YearsIfAMember]
        public DateTime? CustomerBirthdate { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        // Navigation Type: load an object and its related object together from the database
        public MembershipType MembershipType { get; set; }

        // this is treated as a foreign key
        [Display(Name = "Membership Type")]
        public byte MembershipTypeId { get; set; }
    }
}