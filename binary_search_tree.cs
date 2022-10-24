using System;

public class BinarySearchTree
{
	private Node root;
    public BinarySearchTree(int value)
	{
		
		root=new Node(value);

	}

	public void insert(int value)
	{
		Node node = new Node(value);
		Node n = root;
		while(n != null)
		{
            if (value < n.data)
            {

				//left
				if (n.left == null)
				{
					n.left = node;
					break;
				}
				n = n.left;
            }
            else
            {

                if (n.right == null)
                {
                    n.right = node;
                    break;
                }
                n = n.right;
                //right

            }
        }
      
    }

    internal class Node
    {
		public int data;
        public Node left;
        public Node right;

		public Node(int value)
		{
			data= value;
			left= null;
			right = null;
		}
	}
	private bool _checkIsLeaf(Node n)
	{
		return n.left == null && n.right==null;
	}

	private void travelASCL(Node n)
	{

		if (_checkIsLeaf(n))
		{
			//Console.WriteLine(n.left.data);
			Console.Write(n.data+" ");
		}
		else
		{
			if(n.left!=null)
                travelASCL(n.left);
                Console.Write(n.data+"  ");
        }
        if (n.right != null)
            travelASCR(n.right);

    }

    private void travelASCR(Node n)
	{
       
        if (_checkIsLeaf(n))
        {
            Console.Write(n.data+"  ");
        }
        else
        {
			if (n.left != null)
			{
                travelASCL(n.left);
             
            }
			if (n.right != null)
			{
                Console.Write(n.data+"  ");
                travelASCR(n.right);
            }
			
               
        }
    }

	private bool search(Node n,int value)
	{
		if (_checkIsLeaf(n)) {
			if (value == n.data)
				return true;
			else return false;
		}
		else {
			if (n.data == value)
				return true;
			else
			{
				if (n.left != null)
					if (value < n.data)
						return search(n.left, value);

				if (n.right != null)
					if (value > n.data)
						return search(n.right, value);
				return false;
            }
		}
		
	}


    public bool Contain(int value)
	{
		return search(root, value);

	}


    public void travelLDR()
	{
        travelASCL(root);
		Console.WriteLine();
		
	}

	public void travelRDL()
	{
        travelDASCR(root);
        Console.WriteLine();

    }

    private void travelDASCR(Node n)
    {

        if (_checkIsLeaf(n))
        {
            Console.Write(n.data + "  ");
        }
        else
        {
            
            if (n.right != null)
            {
               
                travelDASCR(n.right);
                Console.Write(n.data + "  ");
            }
            if (n.left != null)
            {
                travelDASCL(n.left);

            }
        }
    }

    private void travelDASCL(Node n)
    {

        if (_checkIsLeaf(n))
        {
            //Console.WriteLine(n.left.data);
            Console.Write(n.data + " ");
        }
        else
        {
            if (n.right != null)
                travelDASCR(n.right);
            Console.Write(n.data + "  ");
        }
        if (n.left != null)
            travelDASCL(n.left);

    }


}
