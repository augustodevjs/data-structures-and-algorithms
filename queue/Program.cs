namespace queue
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Queue<string> numbers = new();

            //numbers.Enqueue("one");
            //numbers.Enqueue("two");
            //numbers.Enqueue("three");
            //numbers.Enqueue("four");
            //numbers.Enqueue("five");

            //foreach (string number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //Console.WriteLine("\nDequeuing '{0}'", numbers.Dequeue());
            //Console.WriteLine("Peek at next item to dequeue: {0}", numbers.Peek());
            //Console.WriteLine("Dequeuing '{0}'", numbers.Dequeue());

            //Queue<string> queueCopy = new(numbers.ToArray());

            //Console.WriteLine("\nContents of the first copy:");
            //foreach (string number in queueCopy)
            //{
            //    Console.WriteLine(number);
            //}

            //string[] array2 = new string[numbers.Count * 2];
            //numbers.CopyTo(array2, numbers.Count);

            //Queue<string> queueCopy2 = new(array2);

            //Console.WriteLine("\nContents of the second copy, with duplicates and nulls:");
            //foreach (string number in queueCopy2)
            //{
            //    Console.WriteLine(number);
            //}

            //Console.WriteLine("\nqueueCopy.Contains(\"four\") = {0}",
            //    queueCopy.Contains("four"));

            //Console.WriteLine("\nqueueCopy.Clear()");
            //queueCopy.Clear();
            //Console.WriteLine("\nqueueCopy.Count = {0}", queueCopy.Count);

            Console.WriteLine("Hello, World!");
            ImplementationQueue queue = new(6);
            queue.Enqueue(4);
            queue.Enqueue(2);
            queue.Enqueue(0);
            queue.Enqueue(420);
            queue.Enqueue(69);
            queue.Enqueue(42069);
            queue.GetAllItems();
            Console.WriteLine($"Item deleted: {queue.Dequeue()}");
            queue.GetAllItems();
            Console.WriteLine();
            Console.WriteLine($"Item peeked: {queue.Peek()}");
        }
    }
}