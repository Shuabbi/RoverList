using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace RoverList
{
    public class RoverList<T> : RoverListBase<T>
    {
        // Add any variables you need here
        public RoverList ()
        {

        }

        public override int Count => throw new NotImplementedException();

        public override void Add(T data)
        {
            Node word = new Node(data);
            word.Next = null;

            current = head;
            if (current == null)
            {
                head = word;
                return;
            }

            while (current.Next != null)
            {
                current = current.Next;
            }

            current.Next = word;
            return;
        }

        public override void Add(int Position, T data)
        { 
            Node word = new Node(data);
            current = head;
            if (Position == 0)
            {
                head = word;
                word.Next = current;
                return;
            }
            
            for (int i = 0; i < Position - 1; i++)
            { 
                current = current.Next;
            }

            word.Next = current.Next;
            current.Next = word;

            return;
        }

        public override void Clear()
        {
            head = null;
        }

        public override T ElementAt(int Position)
        {

            if (Position < 0 || Position >= this.Counter())
            {
                Console.WriteLine("Invalid position");
                return default(T);
            }

            current = head;
            if (Position == 0)
            {
                return current.Data;
            }

            for (int i = 0; i < Position; i++)
            {
                current = current.Next;
            }

            return current.Data;
        }

        public override void ListNodes()
        { 
            current = head;
            if (head == null)
            {
                Console.WriteLine("List is empty");
            } else
            {
                while (current.Next != null)
                {
                    Console.WriteLine(current.Data);
                    current = current.Next;
                }
                Console.WriteLine(current.Data);
            }
        }

        public override bool RemoveAt(int Position)
        {
            current = head;
            object result = null;

            if (Position == 0)
            {
                result = current.Data;
                head = current.Next;
                return true;
            }
            else
            {
                for (int i = 0; i < Position - 1; i++)
                    current = current.Next;

                result = current.Next.Data;

                current.Next = current.Next.Next;
            }

            return true;
        }

        public int Counter()
        {

            int count = 0;

            current = head;
            if (current == null)
            {
                Console.WriteLine("List is empty");
                return count;
            }

            while (current.Next != null)
            {
                count++;
                current = current.Next;
            }

            count++;

            return count;
        }

    }
}
