using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_1
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }

        //Kullanıcı aktif ise %10 indirme - pasifse indirimden yararlanamıyor.
        public decimal CalculateDiscount()
        {
            return IsActive ? 0.1M : 0;
        }
    }
}
