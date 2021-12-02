using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_KalıtımNedir
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Kalıtım Miras Alma Nedir?
             * Kalıtım yolu ile oluşturmuş olduğumuz nesnelerimiz birbirlerinden türetilebilir ve türeyen nesne türetilen nesnenin tüm özelliklerini kullanabilir.
             * C# programlama diline başlarken tip dönüşümlerinde tüm nesneleri tanıyan her türlü nesneyi kabul eden object tipinden bahsetmiştik.
             * Object tipi framework içerisindeki tüm nesnelerin atası olan bir tip olduğu için (tüm nesneler object nesnesinden kalıtıldığı için)  türetilen tip kendisinden türeyen tüm tipleri tanır ve tam bir uyumluluk sağlar.
             * Ogrenci O1 = new Ogrenci ();
             * Nesne örneği alınan öğrenci nesnesi aslında object tipinden türetilmiş bir nesnedir.
             */

            
            //temelTip T1 = new temelTip();
            //T1.TemelTipMetot1();
            //Console.WriteLine("---------------------------------");
            Egitmen E1 = new Egitmen();
            //Console.WriteLine("Eğitmen nesnesi örneklendi.");
            //E1.TemelTipMetot1();
            

            // Özel tiplerde Boxing ve Unboxing 

            //Bizim object nesnemiz nedir? => TemelTip
            temelTip T2;
            //Hangi nesnelerde temelTip object görevi görür?
            //Personel,Egitmen,Ogrenci.
            //TemelTip nesnesinden türedikleri için temelTip nesnesi bu nesnelerde object gibi davranır.

            T2 = E1; // Eğitmen nesnesini TemelTip nesnesine atadık.
            E1 = (Egitmen)T2; // Unboxing

            Console.ReadKey();
        }
    }
}
