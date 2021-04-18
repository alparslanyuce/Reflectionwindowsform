using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionWinForm
{
   public class musteri
    {
        public Guid ID { get; set; }

        public int CariNumarasi { get; set; }

        public string isim { get; set; }

        public string soyisim { get; set; }

        public string emailadres { get; set; }

        public musteri()
        {

        }

        public musteri(Guid ID, int CariNumarasi)
        {
            this.ID = ID;
            this.CariNumarasi = CariNumarasi;
        }


        public musteri(Guid ID, int CariNumarasi, string isim, string soyisim)
        {
            this.ID = ID;
            this.CariNumarasi = CariNumarasi;
            this.isim = isim;
            this.soyisim = soyisim;
        }

        public void ekranayaz()
        {
            Console.WriteLine($"{ID.ToString()} - cari numarası : {CariNumarasi.ToString()} isim soyisim : {isim} {soyisim}");

        }


        public void carinumaraguncelle(int yenicarinumarasi)
        {
            this.CariNumarasi = yenicarinumarasi;
        }






    }
}
