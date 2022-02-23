using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProje
{
    class Queue
    {
        private int maxSize;
        private MusteriSınıfı[] kuyrukList;
        private int front;
        private int rear;
        private int NItems;
        public Queue(int maxSize)
        {
            this.maxSize = maxSize;
            kuyrukList = new MusteriSınıfı[maxSize];
            front = 0;
            rear = -1;
            NItems = 0;
        }
        public void Ekle(MusteriSınıfı a)
        {
            if (rear == maxSize - 1)
                rear = -1;
            kuyrukList[++rear] = a;
            NItems++;
        }
        public MusteriSınıfı Sil()
        {
            MusteriSınıfı temp = kuyrukList[front++];
            if (front == maxSize)
                front = 0;
            NItems--;
            return temp;
        }
        public MusteriSınıfı IlkiGoster()
        {
            return kuyrukList[front];
        }
        public bool BosMu()
        {
            return (NItems == 0);

        }
        public bool DoluMu()
        {
            return (NItems == maxSize);
        }
        public int Buyukluk()
        {
            return NItems;

        }
    }
}
