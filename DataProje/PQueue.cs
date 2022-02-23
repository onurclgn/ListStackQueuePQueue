using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProje
{
    class PQueue
    {
        List<MusteriSınıfı> Pliste;
        public MusteriSınıfı b;
        public int ListeEleman;

        public PQueue()
        {
            ListeEleman = 0;
            this.Pliste = new List<MusteriSınıfı>();
        }

        public void Ekle(MusteriSınıfı a)
        {
            Pliste.Add(a);
            ListeEleman++;
        }
        public MusteriSınıfı ArtanSil()
        {
            int enBuyuk = 0;
            int temp1;
            foreach (MusteriSınıfı item1 in Pliste)
            {
                temp1 = item1.urunSayisi;
                if (temp1 > enBuyuk)
                {
                    b = item1;
                    enBuyuk = temp1;
                }

            }
            Pliste.Remove(b);
            ListeEleman--;
            return b;
        }
        public MusteriSınıfı AzalanSil()
        {
            int enKucuk = 20;
            int temp1;
            foreach (MusteriSınıfı item1 in Pliste)
            {
                temp1 = item1.urunSayisi;
                if (temp1 < enKucuk)
                {
                    b = item1;
                    enKucuk = temp1;
                }

            }
            Pliste.Remove(b);
            ListeEleman--;
            return b;
        }
        public bool BosMu()
        {
            return (ListeEleman == 0);


        }
    }

}
