using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Day26_MVCValidation.Models
{
    public class User
    {
        //data annotations go in [] brackets. Needs a `using System.ComponentModel.DataAnnotations` using statement.
        //only applicable to the Property directly below it.
        // types of annotations: 
            //[Required]
            //[StringLength(n, MinimumLength = j, ErrorMessage = "Your message."] - Forces a string length between n and j
            //[EmailAddress] - does magic email address validation
            //[RegularExpression("regex here")] - does regex validation
        [Required]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Must be between 3 and 30 characters.")]
        public string Name { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z0-9{5,30}]+@[a-zA-A0-9{5,10}]+\.[a-zA-Z0-9{2,3}]+$")]
        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }

        [StringLength(2, MinimumLength = 2)]
        public string State { get; set; }

        [RegularExpression(@"\d{5}", ErrorMessage = "Zip Code must be 5 digits.")]
        public string ZipCode { get; set; }
        public string FavProWrestler { get; set; }

        //make regex for sql server DATE
        public DateTime DOB { get; set; }


    }
}
