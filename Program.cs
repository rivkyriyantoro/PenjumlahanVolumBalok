using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace volumbalok
{

    namespace volumbalok
    {
        /// <summary>
        /// main class
        /// </summary>
        /// <remarks> class volum dapat membuat operasi penjumlahan volum balok  </remarks>
        
        class volum
        {
            /// <summary>
            /// operasi perkalian
            /// </summary>
            /// <param name="p">angka pertama dalam operasi penjumlahan </param>
            /// <param name="l">angka kedua yang akan dikalikan dengan angka pertama </param>
            /// <param name="t">angka ketiga yang akan dikalikan dengan angka pertama dan kedua  </param>
            /// <returns> hasil dari jumlah perkalian dari angka pertama, angka kedua, angka ketiga </returns>

            public double hitungvolum(double p, double l, double t)
            {
                return p * l * t;
            }

        }

        /// <summary>
        /// main class
        /// </summary>
        /// <remarks> class inputoutput dapat menambahkan angka pada masukan input operasi penjumlahan volum balok  </remarks>

        class inputoutput
        {

            /// <summary>
            /// operasi input data
            /// </summary>
            /// <param name="panjang">data panjang dalam operasi penjumlahan </param>
            /// <param name="lebar">data lebar yang akan dikalikan dengan data panjang </param>
            /// <param name="tinggi">data tinggi yang akan dikalikan dengan data panjang dan lebar  </param>
           

            public double panjang, lebar, tinggi;
            int abc;

            public void MasukanData()
            {
                Console.Write("masukan panjang = ");
                panjang = Convert.ToDouble(Console.ReadLine());
                Console.Write("masukan lebar = ");
                lebar = Convert.ToDouble(Console.ReadLine());
                Console.Write("masukan tinggi = ");
                tinggi = Convert.ToDouble(Console.ReadLine());

            }

            /// <summary>
            /// operasi penjumlahan
            /// </summary>
            /// <param name="V">data yang akan dikalikan dengan data panjang, data lebar,  data tinggi   </param>
            
            public void hasil(double V)
            {
                Console.WriteLine("Volume balok = {0}", V);

            }
        }

        /// <summary>
        /// Subclass
        /// untuk memanggil masukan data dan hasil
        /// </summary>
      
        class Program
        {

            static void Main(string[] args)
            {

                volum vol = new volum();
                inputoutput io = new inputoutput();

                io.MasukanData();
                io.hasil(vol.hitungvolum(io.panjang, io.tinggi, io.lebar));
                Console.ReadKey();
            }
        }
    }
}


