using System;

public class CircularQueue
{

	private int front;
	private int rear;
	private int size;
	private int[] arr;
	public CircularQueue()
	{
		front = -1;
		rear = -1;
		size = 5;
		arr = new int[size];
	}

	private bool isFull() => front == 0 && rear == size - 1 || front == rear + 1;

	private bool isEmpty() => front == -1; 

	public void enQueue(int value)
	{
		if (isFull())
		{
			Console.WriteLine("queue if full");
		}
		else
		{
			if(front == -1)
				front = 0;
			rear = (rear + 1) % size;
			arr[rear] = value;
		}
	}

	public int deQueue()
	{
		if (isEmpty())
		{
			//Console.WriteLine("queue is empty");
			return -1;
		}
		else
		{
			int value = arr[front];

			if (front == rear)
			{
				front = -1;
				rear = -1;
			}
			else
			{
				front = (front + 1) % size;
			}
			return value;
		}
	}
	public void display()
	{
		int x = deQueue();

        while (x!=-1)
		{
			Console.WriteLine(x);
			x=deQueue();
		}
	}
	}
