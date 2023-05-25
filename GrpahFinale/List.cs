using System;
using System.Collections.Generic;
using System.Text;

namespace GrpahFinale
{
    class MyList<T>
    {
        public Node<T> first;
        public Node<T> last;

        public MyList()
        {
            first = null;
            last = null;
        }
    }
}
