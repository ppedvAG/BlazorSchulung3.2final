using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorSchulung3._2final.Data
{
    public class Person
    {
        [Key()]
        public int ID { get; set; }
        [Required(ErrorMessage ="Muss was rein")]
        [MinLength(3,ErrorMessage ="mind 3 Zeichen")]
        public string Name { get; set; }
        [Display(Name="GeburtsDatum")]
        [Range(typeof(DateTime), "1/2/2000", "5/29/2020",
        ErrorMessage = "Value for {0} must be between {1} and {2}")] 
        public DateTime GebTag { get; set; }
    }
}
