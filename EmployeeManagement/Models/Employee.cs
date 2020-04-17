using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [NotMapped]
        public string EncryptedId { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "Name cannot exceed 50 characters")]
        public string Name { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$",
            ErrorMessage = "Invalid Email Format")]
        [Display(Name = "Office Email")]
        public string Email { get; set; }
        [Required]
        public Dept? Department { get; set; }
        public string PhotoPath { get; set; }
    }
}
