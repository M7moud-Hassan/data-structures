using System;
using System.Drawing;

public class Queue
{
	private int size;
	private int[] arr;
	int font, rear;
	public Queue()
	{
		size = 3;
		arr = new int[size];
		font = -1;
		rear = -1;
	}

	private bool isFull()=>font==0 && rear==size-1;

	private bool isEmpty()=>font==-1;

	public void enQueue(int value)
	{
		if (isFull())
		{
			Console.WriteLine("the queue is full");
			return;
		}
		if(font==-1)
			font = 0;
		rear++;
		arr[rear] = value;
	}

	public int? deQueue()
	{
		int? value;
		if (isEmpty())
		{
			value = null;
		}
		else
		{
			value=arr[font];
			if (font >= rear)
			{
				font = -1;
				rear=-1;
			}
			else
			{
				font++;
				//rear--;
			}
		}
		return value;
	}
}
