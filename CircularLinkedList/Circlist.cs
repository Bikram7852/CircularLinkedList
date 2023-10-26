using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularLinkedList
{
    public class Circlist
    {
        private int currentdata;
        private Circlist nextdata;
        public Circlist()
        {
            currentdata = 0;
            nextdata = this;
        }
        public Circlist(int value)
        {
            currentdata = value;
            nextdata = this;
        }
        public Circlist Insdata(int value)
        {
            Circlist node = new Circlist(value);
            if (this.nextdata == this)
            {
                node.nextdata = this;
                this.nextdata = node;
            }
            else
            {
                Circlist temp = this.nextdata;
                node.nextdata = temp;
                this.nextdata = node;
            }
            return node;
        }
        public int Deldata()
        {
            if (this.nextdata == this)
            {
                System.Console.WriteLine("\nOnly one node!!!!");
                return 0;
            }
            Circlist node = this.nextdata;
            this.nextdata = this.nextdata.nextdata;
            node = null;
            return 1;
        }
        public void Traverse()
        {
            Traverse(this);
        }
        public void Traverse(Circlist node)
        {
            if (node == null)
                node = this;
            System.Console.WriteLine("Forward Direction!!!!");
            Circlist snode = node;
            do
            {
                System.Console.WriteLine(node.currentdata);
                node = node.nextdata;
            }
            while (node != snode);
        }
        public int Gnodes()
        {
            return Gnodes(this);
        }
        public int Gnodes(Circlist node)
        {
            if (node == null)
                node = this;
            int count = 0;
            Circlist snode = node;
            do
            {
                count++;
                node = node.nextdata;
            }
            while (node != snode);
            System.Console.WriteLine("\nCurrent Node Value : " +
                                     node.currentdata.ToString());
            System.Console.WriteLine("\nTotal nodes :" + count.ToString());
            return count;
        }
    }
}
