using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        #region Первая задача
        static T Max<T>(T y, T z, T x) where T : IComparable<T>
        {
            if (y.CompareTo(z) > 0 && y.CompareTo(x) > 0)
                return y;
            else if (z.CompareTo(y) > 0 && z.CompareTo(x) > 0)
                return z;
            else
                return x;
        }
        #endregion

        #region Вторая задача 
        static T Min<T>(T y, T z, T x) where T : IComparable<T>
        {
            if (y.CompareTo(z) < 0 && y.CompareTo(x) < 0)
                return y;
            else if (z.CompareTo(y) < 0 && z.CompareTo(x) < 0)
                return z;
            else
                return x;
        }
        #endregion

        #region Чертвертая задача
        public class Kycha<T>
        {
            private List<T> list = new List<T>();
            public int Count { get { return list.Count; } }
            public void Push(T element) => list.Add(element);
            public T Pop()
            {
                T result = list[list.Count - 1];
                list.RemoveAt(list.Count - 1);
                return result;
            }
            public T Peek() { return list[list.Count - 1]; }
        }
        #endregion

        #region Пятая задача
        public class Ochered<T>
        {
            private List<T> list = new List<T>();
            public int count => list.Count;
            public void Enqueue(T element) => list.Add(element);
            public T Dequeue()
            {
                T element = list[0];
                list.RemoveAt(0);
                return element;
            }
            public T Peek() { return list[0]; }
        }
        #endregion
        static void Main(string[] args)
        {
            int zadanie_1 = Max(1, 2, 4);
            Console.WriteLine(zadanie_1);
            int zadanie_2 = Min(1, 2, 4);
            Console.WriteLine(zadanie_2);
            Stack<int> zadanie_4 = new Stack<int>();
            zadanie_4.Push(1);
            zadanie_4.Push(4);
            Console.WriteLine(zadanie_4.Count);
            Console.WriteLine(zadanie_4.Peek());
            zadanie_4.Pop();
            Console.WriteLine(zadanie_4.Count);
        }
    }
}