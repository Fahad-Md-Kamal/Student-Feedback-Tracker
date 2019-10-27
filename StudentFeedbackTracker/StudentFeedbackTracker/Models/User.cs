using System;
using System.ComponentModel.DataAnnotations;

namespace StudentFeedbackTracker.Models
{
    public abstract class User
    {
        [Key]
        public int Id { get; set; }

        [StringLength(250)]
        public string Username { get; set; }

        [StringLength(200)]
        public string Email { get; set; }

        [StringLength(20)]
        public byte[] Password { get; set; }

        public DateTime DoB { get; set; }

        [StringLength(250)]
        public string FirstName { get; set; }

        [StringLength(250)]
        public string LastName { get; set; }

        [StringLength(250)]
        public string Address { get; set; }


        public virtual Role Role { get; set; }

    }
}