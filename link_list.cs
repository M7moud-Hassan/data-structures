using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

class SingleLinkedList
{

    internal Node head;
    private int size = 0;

    public int  this[int index]
    {
        get {
            if (index > size)
            {
                return -1;
            }
            else
            {
                int m = 0;
                Node n = head;
                while (m != index)
                {

                    n = n.next;
                    m++;
                }

                return n.value;
            }
        }
        set {


            int m = 0;
            Node n = head;
            while (m != index)
            {

                n = n.next;
                m++;
            }
            n.value = value;

        }

    }
   
    public SingleLinkedList(int d)
    {
        head = new Node(d);
        size++;
    }
    public void insert(int d)
    {
        Node n = new Node(d);// new node with value d and next=null
        size++;
        Node nex = head;
        while (nex.next!= null)
       {
         nex = nex.next;
       }
       nex.next = n;
       
    }

    public void insertBeginning(int d)
    {
       Node node = new Node(d);
       node.next = head;
       head = node;
        size++;
    }

    public void insertAtIndex(int d,int index)
    {
        //5->1->2->3->null;
        if (index > size)
            return;
        else
        {
            Node node=new Node(d);
            Node nH = head;
            Node n=nH;
            int m = 0;
            while (m!=index)
            {
                nH = n;
                n = nH.next;
                m++;
            }
            nH.next=node;
            node.next = n;
            size++;
        }
    }


    public void deleteAtIndex(int index)
    {
        //1->2->3->4->5->null
        if (index > size)
            return;
        else
        {
            int m = 0;
            Node nH = head;
            Node n = nH;
            while (m != index)
            {
                nH = n;
                n = nH.next;
                m++;
            }
            nH.next = n.next;
            size--;
        }

    }

    public bool search(int d)
    {
        Node n = head.next;
        while (n != null)
        {
            if (n.value == d)
                return true;
            n = n.next;
        }

        return false;

    }


    public void sort()
    {
   
        for (int i = 0; i < size; i++)
        {
            Node node = head;
            for (int j = 0; j < size - i-1; j++)
            {
                Node first,second;
                first = node;
                second=node.next;
               

                if(first.value > second.value)
                {
                    int temp = first.value;
                    first.value = second.value;
                    second.value = temp;
                }



                node = second;
            }
           
          
        }


    }

    internal class Node
    {
        internal int value;
        internal Node next;
        public Node(int d)
        {
            value = d;
            next = null;
        }
    }

    public override string ToString()
    {
        //5--1--2-->null
        String nodes = head.value + " --> ";
        Node n = head.next;
        while(n!= null)
        {
           
            nodes+= n.value + " --> ";
            n=n.next;
        }
        nodes +="null";
        return nodes;
    }
}