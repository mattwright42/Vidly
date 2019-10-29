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

        
        //[Min18YearsIfAMember]
        public DateTime? CustomerBirthdate { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        // this is treated as a foreign key
        
        public byte MembershipTypeId { get; set; }
    }
}