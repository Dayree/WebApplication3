using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication3.DB
{
    public class Siparis
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string SiparisAdi { get; set; }
        public int Miktar { get; set; }
        public int Fiyat { get; set; }
      
    }
}
