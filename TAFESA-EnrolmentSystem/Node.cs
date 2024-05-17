using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TAFESA_EnrolmentSystem
{
    public class Node<T>
    {
        public Node<T> LeftNode { get; set; }
        public Node<T> RightNode { get; set; }
        public T Data { get; set; }

        public Student Student { get; set; }

    }
}
