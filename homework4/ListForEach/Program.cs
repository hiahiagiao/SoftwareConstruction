using System;

namespace ListForEach
{
    class Program
    {
        //为示例中的泛型链表类添加类似于List<T>类的ForEach(Action<T> action)方法。
        //通过调用这个方法打印链表元素，求最大值、最小值和求和（使用lambda表达式实现）
        static void Main(string[] args)
        {
            GenericList<int> list = new GenericList<int>();
            for (int i = 0; i < 5; i++)
            {
                list.add(i);
            }
            int max = list.Head.Data;
            int min = list.Head.Data;
            int sum = list.Head.Data;

            list.forEach(m => Console.WriteLine(m));
            list.forEach(m => { max = m > max ? m : max; });
            list.forEach(m => { min = m > min ? min : m; });
            list.forEach(m => { sum += m; });

            Console.WriteLine(max );
            Console.WriteLine(min);
            Console.WriteLine(sum);
        }
        public class Node<T>
        {
            public Node<T> Next { get; set; }
            public T Data { get; set; }
            public Node(T t)
            {
                Next = null;
                Data = t;
            }
        }
        public class GenericList<T>
        {
            private Node<T> head;
            private Node<T> tail;
            
            public GenericList()
            {
                tail = head = null;

            }


            public Node<T> Head
            {
                get => head;
            }

            public void add(T t)
            {
                Node<T> n = new Node<T>(t);
                if (tail == null)
                {
                    head = tail = n;
                }
                else
                {
                    tail.Next = n;
                    tail = n;
                }
            }


            public void forEach(Action<T> action)
            {
                for (Node<T> node = head; node != tail.Next; node = node.Next)
                {
                    action(node.Data);
                }
            }
        }
    } }
