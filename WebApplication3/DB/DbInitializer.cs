using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.DB
{
    public class DbInitializer
    {
        public static void Initialize(AppDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.Users.Any())
            {
                return;  
            }

            var users = new User[]
            {
            new User{Name="Carson",LastName="Alexander"},
            new User{Name="Meredith",LastName="Alonso"},
            new User{Name="Arturo",LastName="Anand"},
            new User{Name="Gytis",LastName="Barzdukas"}
            };
            foreach (User s in users)
            {
                context.Users.Add(s);
            }
            context.SaveChanges();

            var siparisler = new Siparis[]
            {
            new Siparis{SiparisAdi="Chemistry",Fiyat=3,Miktar=4},
            new Siparis{SiparisAdi="Microeconomics",Fiyat=3,Miktar=4},
            new Siparis{SiparisAdi="Macroeconomics",Fiyat=3,Miktar=2},
            new Siparis{SiparisAdi="Calculus",Fiyat=4,Miktar=3},
            new Siparis{SiparisAdi="Trigonometry",Fiyat=4,Miktar=5},
            new Siparis{SiparisAdi="Composition",Fiyat=3,Miktar=7},
        
            };
            foreach (Siparis c in siparisler)
            {
                context.Siparises.Add(c);
            }
            context.SaveChanges();
        }
    }
}
