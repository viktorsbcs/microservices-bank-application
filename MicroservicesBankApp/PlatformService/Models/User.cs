﻿using System.ComponentModel.DataAnnotations;

namespace PlatformService.Models
{
    public class User
    {
        [Key]
        public string UserId { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string SecondName { get; set; }  

        public List<Account> Accounts { get; set; }
    }
}
