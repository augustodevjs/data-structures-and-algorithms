namespace queue
{
    public class ImplementationQueue
    {
        private int front;
        private int rear;
        private int[] queue;

        public ImplementationQueue(int size)
        {
            front = 0;
            rear = -1;
            queue = new int[size];
        }

        public void Enqueue(int item)
        {
            if (rear == queue.Length - 1)
            {
                throw new StackOverflowException("Queue is full");
            }
            queue[++rear] = item;
        }

        public int Dequeue()
        {
            if (front > rear)
            {
                throw new Exception("Queue is empty");
            }
            int item = queue[front];
            front++;
            return item;
        }

        public int Peek()
        {
            if (front > rear)
            {
                throw new Exception("Queue is empty");
            }
            return queue[front];
        }

        public void GetAllItems()
        {
            Console.WriteLine("Items of queue are:");
            for (int i = front; i <= rear; i++)
            {
                Console.WriteLine(queue[i]);
            }
        }
    }
}
