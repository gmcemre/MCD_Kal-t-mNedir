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
            //Egitmen E1 = new Egitmen();
            //Console.WriteLine("Eğitmen nesnesi örneklendi.");
            //E1.TemelTipMetot1();


            // Özel tiplerde Boxing ve Unboxing 

            //Bizim object nesnemiz nedir? => TemelTip
            //temelTip T2;
            //Hangi nesnelerde temelTip object görevi görür?
            //Personel,Egitmen,Ogrenci.
            //TemelTip nesnesinden türedikleri için temelTip nesnesi bu nesnelerde object gibi davranır.

            //T2 = E1; // Eğitmen nesnesini TemelTip nesnesine atadık.
            //E1 = (Egitmen)T2; // Unboxing

            //Personel P1 = new Personel();
            //T2 = P1; // PErsonel nesnesini Temeltip nesnesine atadık.

            //P1 = (Personel)T2;//Unboxing

            //Ogrenci O1 = new Ogrenci();
            //T2 = O1; // Ogrenci nesnesini TemelTip nesnesine atadık.

            //O1 = (Ogrenci)T2; //Unboxing

            //object O3 = T2;

            //object O1 = E1;//Boxing
            //E1 = (Egitmen)O1;//Unboxing

            //Personel P1 = new Personel();
            //P1.TemelTipMetot1();

            //Ogrenci O1 = new Ogrenci();
            //O1.TemelTipMetot1();

            //object obj1 = O1;
            //O1 = (Ogrenci)obj1;

            //obj1 = P1;
            //P1 = (Personel)obj1;

            //Ben istiyorum ki türemiş olan tiplerim türeyemesin...
            // object => temelTip => Personel => X
            //                      => Ogrenci => X
            //                      => Egitmen => X

            //Hangi nesnemizin kalıtılmasısnı istemiyoruz?
            //Egitmen Sealed

            //Egitmen E1 = new Egitmen();

            //public: uygulamamızın içerisinde veya dışarısında ulaşılabilir anlamını taşır.
            //private: saadece tanımlandığı class içerisine erişebilir olur.
            //protected: Normal kullanımda private olarak davranır.Kalıtım yolu ile başka bir class içerisinde public olarak kullanılır.

            temelTip T1 = new temelTip();

            Ogrenci O1 = new Ogrenci();
            O1.TemelTipMetot1();


            Console.ReadKey();
        }
    }
}
