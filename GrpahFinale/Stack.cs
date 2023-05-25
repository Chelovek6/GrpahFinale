using System;
using System.Collections.Generic;
using System.Text;

namespace GrpahFinale
{
    class MyStack<T>
    {
        public MyList<T> list;

        public MyStack()
        {
            list = new MyList<T>();
        }

        public void Push(T data)
        {
            Node<T> node1 = new Node<T>(data);
            node1.next = list.first;
            list.first = node1;
        }
    }
}
