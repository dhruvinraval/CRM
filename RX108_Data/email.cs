using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RX108_Data
{
    public class email : BusinessObject
    {
        [EmailAddress(ErrorMessage = "Enter Valid Email Address")]
        public string to { get; set; }


        [Required]
        public string subject { get; set; }

        [Required]
        public string message { get; set; }
    }
}
