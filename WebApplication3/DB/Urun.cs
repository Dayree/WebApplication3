using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication3.DB
{
    public class Urun
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string UrunAdi { get; set; }
        public string Renk { get; set; }
        public string Model { get; set; }
        public int Fiyat { get; set; }
      
    }
}
