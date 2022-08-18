using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    public class House // class ı public yaptık ve şimdi farklı bi projeden(AccessModifiersTest) ulaşmaya çalışıcaz.
    {
        public int Id { get; set; }
        internal string City { get; set; }    // prop un default hali private halindedir yani public i silersek program.cs den erişemeyiz.

        protected string Suburb { get; set; }  // protected yaparsak sadece kendi yazıldığı class da yazarız
                                               // private --> sadece ve sadece kendi class
                                               // protected --> sadece ve sadece kendi classı + kendi class ını miras alan yerde geçerli.
    }


    public class HouseTest:House
    {
        public HouseTest()
        {
            House house1 = new House();
            house1.Suburb = "Bahcelievler";
        }
    }
    
        
            

    }

