using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs
{
    class Node
    {
        public long Value { get; set; }
        public Node Next { get; set; }
        public Node Prev { get; set; }
        public int count { get; set; }
    }
    class list
    {
        private int Size { get; set; }
        private Node Head { get; set; }   //Head referense
        
        private Node Tail { get; set; }  //Last referense

        public void push_Back(long value)
        {
            
            Node node = new Node() { Value = value };
            Head.count = 0;
            if (Head == null)
            {
                Head = node;
            }
            else
            {
                node.count = node.Prev.count+1;
                Tail.Next = node;
                node.Prev = Tail;
            }
            Tail = node;
            Size++;
        }
        public int CountMultiples()
        {
	        Node node =Head;
	        int k = 0;
	        while (node != null)
	        {
		        if (node.Value % 5 == 0 && node.count%2==0)
		        {
			        k++;
		        }
		        node = node.Next;
	        }
	        return k;
        }

        public void Remove(int data)
        {
            Node current = Head;

            // поиск удаляемого узла
            while (current != null)
            {
                if (current.Value >= data)
                {
                    // если узел не последний
                    if (current.Next != null)
                    {
                        current.Next.Prev = current.Prev;
                    }
                    else
                    {
                        // если последний, переустанавливаем tail
                        Tail = current.Prev;
                    }

                    // если узел не первый
                    if (current.Prev != null)
                    {
                        current.Prev.Next = current.Next;
                    }
                    else
                    {
                        // если первый, переустанавливаем head
                        Head = current.Next;
                    }
                }
                current = current.Next;
            }
           
            
            
        }
    }
}
