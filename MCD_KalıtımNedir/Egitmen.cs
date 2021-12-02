using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_KalıtımNedir
{
    public class Egitmen:temelTip 
    {
        public string  Brans { get; set; }
        public int BransSeviye { get; set; }

        public Egitmen()
        {
            Console.WriteLine("Egitmen nesnesinin yapıcı metodu çalıştı");
            // IdAtamaISlemi => Private olduğu için gelmiyor.
        }
    }
}
