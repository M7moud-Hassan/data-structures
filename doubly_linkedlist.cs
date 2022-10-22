using System;

public class DoublyLinkedList
{
	internal Node head;
	private int size=0;


    public int this[int index]
    {
        get
        {
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
        set
        {


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

    public DoublyLinkedList(int value)
	{
		head = new Node(value);
		size++;
	}

	public void insertLast(int value)
	{
		Node node=new Node(value);
		Node n = head;
		while (n.next != null)
		{
			n=n.next;
		}
		n.next = node;
		node.prev = n;
		size++;

	}

	public void insertFront(int value)
	{
        Node node = new Node(value);
        head.prev = node;
        node.prev = null;
        node.next = head;
        head = node;
        size++;
		
    }
	

	public void insertAtIndex(int index,int value)
	{
		//1-><>[8]<>2->3->4
		if (index >= size)
			return;

		int m = 0;
		Node newNode = new Node(value);
		Node node=head;
		while (m != index)
		{
			node=node.next;
			m++;
		}
		newNode.next = node;
		node.prev.next = newNode;
		newNode.prev = node.prev;
		node.prev=newNode;
		size++;
	}


	public void deleteAtIndex(int index)
	{
        if (index >= size)
            return;
        int m = 0;
        Node node = head;
        while (m != index)
        {
            node = node.next;
            m++;
        }
		Node prev=node.prev;
		Node next=node.next;
		prev.next = next;
		next.prev = prev;
		size--;

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
            for (int j = 0; j < size - i - 1; j++)
            {
                Node first, second;
                first = node;
                second = node.next;


                if (first.value > second.value)
                {
                    int temp = first.value;
                    first.value = second.value;
                    second.value = temp;
                }



                node = second;
            }


        }



    }

    public override string ToString()
	{
        //null<-1><2><3
       
        String diplay = "null<-"+head.value+"<>";
		Node node = head.next;
		while(node != null)
		{
			diplay += node.value+"<>";
			node = node.next;
		}
		diplay += "null";
		return diplay;
	}

	internal class Node
	{
		internal int value;
		internal Node next;
		internal Node prev;

		public Node(int value)
		{
			this.value = value;
			next = null;
			prev = null;
		}
	}
}
