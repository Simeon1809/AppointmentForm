using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppointmentForm.Models
{
    public class AppointmentModel
    {
        public int Id { get; set; }
        [StringLength(25, MinimumLength =4)]
        [Required]
        [DisplayName("Patient Name ") ]
        public string PatientName { get; set; }
        [DisplayName("Patient Address")]
        public string Street { get; set; }
        [DisplayName("City")]
        public String City { get; set; }
        [Required]
        [DisplayName("Email Address")]
        public String Email { get; set; }
        [Required]
        [DisplayName("Phone Number")]
        public int Phone { get; set; }
        [DisplayName("Net Worth")]
        [DataType(DataType.Currency)]
        [Range(150000,9999999999999)]
        public decimal Networth { get; set; }
        [DisplayName("Patient level of Pain")]
        [Range(1,10)]
        public int PainLevel { get; set; }
        [Required]
        public String DoctorsName { get; set; }
        public DateTime AppointmentDate { get; set; }
       
    }
}
