using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
namespace WebApplication3.DB
{
    public class Siparis
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string SiparisAdi { get; set; }
        public int Miktar { get; set; }
        public int Fiyat { get; set; }
      
    }
}
