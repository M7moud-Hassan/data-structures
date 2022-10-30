using System;
using System.Drawing;

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
            Console.Write(n.data + " ");
        }
        else
        {
            if (n.left != null)
            {
                travelASCL(n.left);
                //Console.Write(n.data + "  ");
            }
            Console.Write(n.data + "  ");
            if (n.right != null)
            {
              
                travelASCR(n.right);
            }
            
        }
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
            Console.Write(n.data + "  ");
            if (n.right != null)
			{  
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

    private bool result = false;
    private bool _rmove(Node n, int value)
    {
        if (_checkIsLeaf(n))
        {
            if (value == n.data)
                return true;
            else return false;
        }
        else
        {
            if (n.data == value)
                return true;
            else
            {
                if (n.left != null)
                    if (value < n.data)
                    {
                        result = _rmove(n.left, value);
                        if (result)
                        {
                            if (_checkIsLeaf(n.left))
                            {
                                n.left = null;
                            }
                            else
                            {
                                sheftLeft(n);
                            }
                            return false;
                        }
                        
                        return false;
                    }

                if (n.right != null)
                    if (value > n.data)
                    {
                        result = _rmove(n.right, value);
                        if (result)
                        {
                            if (_checkIsLeaf(n.right))
                            {
                                n.right = null;
                            }
                            else
                            {
                                   sheftRight(n);
                            }
                            return false;
                        }
                        return false;
                    }
                return false;
            }
        }

    }


    private void sheftRight(Node n)
    {
        Node node = n.right;
        if (_checkIsLeaf(node))
        {
            node = null;
        }else if (node.left == null)
        {
            n.right = node.right;
        }else if (_checkIsLeaf(node.left))
        {
            node.data=node.left.data;
            node.left = null;
        }
        else
        {
            Node leftNode = node.right;
            while (leftNode.left != null)
                leftNode = leftNode.left;
            Remove(leftNode.data);
            node.data = leftNode.data;
        }
    }
    private void sheftLeft(Node n)
    {
        Node node = n.left;
        if (node.right == null)
            n.left = node.left;
        else if (_checkIsLeaf(node.right))
        {
            n.left.data = node.right.data;
            node.right = null;
        }else if (node.right.left == null)
        {
            n.left = node.right;
            node.right.left = node.left;
        }
        else
        {
            Node leftNode = node.right;
            while (leftNode.left != null)
                leftNode = leftNode.left;
            Remove(leftNode.data);
            node.data = leftNode.data;
        }
    }

    public bool Contain(int value)
	{
		return search(root, value);

	}


    public void travelLDR()
	{
        if (root != null)
        {
            travelASCL(root);
            Console.WriteLine();
        }
        else Console.WriteLine("empty");
      
		
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
              
               
            }
            Console.Write(n.data + "  ");
            if (n.left != null)
            {
                //Console.Write(n.data + "  ");
               
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
            if (n.left != null)
            {
                // Console.Write(n.left.data + "  ");
                travelDASCL(n.left);

            }
        }
    }

    public void Remove(int d)
    {
        if (root.data == d)
        {
            if (_checkIsLeaf(root))
            {
                root = null;
             
            }else if (root.left == null)
            {
                Node node = root.right;
                while (node.left != null)
                    node = node.left;
                _rmove(root, node.data);
                root.data = node.data;
             
            }
            else
            {
                Node node = root.left;
                while (node.left != null)
                    node = node.left;
                _rmove(root, node.data);
                root.data = node.data;
              
            }
           
        }else
        _rmove(root, d);
    }


}
