using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circlist node1 = new Circlist(1);
            node1.Deldata();
            Circlist node2 = node1.Insdata(2);
            node1.Deldata();
            node2 = node1.Insdata(2);
            Circlist node3 = node2.Insdata(3);
            Circlist node4 = node3.Insdata(4);
            Circlist node5 = node4.Insdata(5);
            node1.Gnodes();
            node3.Gnodes();
            node5.Gnodes();
            node1.Traverse();
            node3.Deldata();
            node2.Traverse();
            node1.Gnodes();
            node3.Gnodes();
            node5.Gnodes();
            Console.Read();
        }
    }
}
