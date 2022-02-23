using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProje
{
    class Yigit
    {
        public int MaxSize;
        public MusteriSınıfı[] stackArray;
        public int top;

        public Yigit(int Maxsize)
        {

            stackArray = new MusteriSınıfı[Maxsize];
            top = -1;
        }
        public void push(MusteriSınıfı a)
        {
            stackArray[++top] = a;
        }
        public MusteriSınıfı pop()
        {
            return stackArray[top--];
        }
        public MusteriSınıfı peek()
        {
            return stackArray[top];
        }
        public bool isEmpty()
        {
            return (top == -1);
        }
        public bool isFull()
        {
            return (top == MaxSize - 1);
        }
    }
}
