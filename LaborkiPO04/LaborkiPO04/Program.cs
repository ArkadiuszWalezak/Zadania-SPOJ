using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaborkiPO04
{
    public class Program
    {
        public partial class MyList<T>
        {
            private class Node
            {
                public T value { get ; set ; }
                public Node next;
            }

            private Node first = null;
            private Node last = null;

            public void Add (T element)
            {
                if (first == null)
                {
                    first = last = new Node() { value = element };
                }
                else
                {
                    last = last.next = new Node() { value = element };
                }
            }

            public int Liczonko()
            {
                int k = 0;
                
                foreach (Node node in this)
                {
                    k++;
                }
                return k;
            }

            private Node Get(int i)
            {
                var e = first;
                    while (i-- > 0 && e != null)
                    e = e.next;
                if (e == null)
                    throw new IndexOutOfRangeException();
                return e;
            }

            public T this[int i] { get => Get(i).value; set => Get(i).value = value; }
        }
        
        public void CheckIfParzysta()
        {

        }

        static void Main()
        {
            var l = new MyList<int>();
            l.Add(785);
            l.Add(3);
            l.Add(4);
            l.Add(100);
            l.Add(56);
            l.Add(37);
            
            //for (int j = 0; j < l.Liczonko(); j++)
            //{
            //    //if (l[j] == 0)
            //    {
            //        Console.WriteLine($"pierwszy element: {l[j]}");
            //    }
            //}
            Console.WriteLine($"pierwszy element: {l[0]}");
            Console.WriteLine($"ma być 6: {l.Liczonko()}");
            Console.ReadKey();
        }
    }
}
