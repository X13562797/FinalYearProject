using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
namespace FinalYearProject.Models
{
    public class Contact
    {
        [StringLength(20, MinimumLength =6)]
        public int ContactId { get; set; }

        [StringLength(15, MinimumLength = 6)]
        public string Name { get; set; }

        [StringLength(40, MinimumLength = 10)]
        public string Address { get; set; }

        [StringLength(20, MinimumLength = 3)]
        public string City { get; set; }

        [StringLength(20, MinimumLength = 2)]
        public string State { get; set; }

        [StringLength(10, MinimumLength = 3)]
        public string Zip { get; set; }

        [StringLength(20, MinimumLength = 3)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}