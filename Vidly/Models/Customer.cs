using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Display(Name = "Date of Birth")]
        public DateTime? CustomerBirthdate { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        // Navigation Type: load an object and its related object together from the database
        public MembershipType MembershipType { get; set; }

        // this is treated as a foreign key
        [Display(Name = "Membership Type")]
        public byte MembershipTypeId { get; set; }

    }
}