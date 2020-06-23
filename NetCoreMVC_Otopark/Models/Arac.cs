using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreMVC_Otopark.Models
{
    public class Arac
    {
        [Key]
        public int AracID { get; set; }
        public string AracPlaka { get; set; }
        public DateTime GirisTarihi { get; set; }
        public DateTime CikisTarihi { get; set; }
        public bool Aktiflik { get; set; }
    }
}
