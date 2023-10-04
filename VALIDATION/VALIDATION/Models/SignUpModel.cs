using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VALIDATION.Models
{
    public class SignUpModel
    {
        [Required(ErrorMessage ="Please provide your name to register")]

        public string Name {  get; set; }
        [Required]
        public string Password {  get; set; }
        [Required]
        public string Profession {  get; set; }
        [Required]
        public string Gender {  get; set; }
        [Required]
        public string[] Hobbies {  get; set; }
    }
}