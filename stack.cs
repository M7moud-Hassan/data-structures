using System;

public class Stack
{
	private int[] arr;
	private int top;
	private int capacity ;
	public int Capacity { get => capacity; }


	public Stack(int size=10)
	{
		arr= new int[size];
		capacity= size;
		top= -1;
	}

    public void push(int value)
    {
		if (isFull())
		{
			Console.WriteLine("the statck is full");
			return;
		}
		arr[++top] = value;
		Console.WriteLine($"the element is add {value}");

    }
	public int? pop()
	{
		if (isEmpty())
		{
			Console.WriteLine("the stack is empty");
			return null;
		}

		return arr[top--];
	}

    private bool isFull() => top == capacity-1;
    private bool isEmpty() => top+1 == 0;
    
}
