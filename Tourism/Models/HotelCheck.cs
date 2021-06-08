using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Tourism.Models
{
    public class HotelCheck
    {
        [Key] 
        public int HotelId { get; set; }

        [Column(TypeName = "nvarchar(250)")] 
        [Required(ErrorMessage = "This field is required.")] 
        [DisplayName("Hotel Name")] 
        public string HotelName { get; set; }

        [Column(TypeName = "varchar(100)")]
        [Required(ErrorMessage = "This field is required.")]
        public string Star { get; set; }

        [Column(TypeName = "varchar(100)")] [DisplayName("Hotel Location")]
        [Required(ErrorMessage = "This field is required.")]
        public string HotelLocation { get; set; }
    }
}
