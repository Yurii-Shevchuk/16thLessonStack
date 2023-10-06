namespace _16thLessonStack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < stack.MaxCapacity; i++)
            {
                stack.Push(i);
            }
            Console.WriteLine("Stack values(unmodified):");
            foreach (int i in stack)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine("\n");
            Console.WriteLine("Peek top value: " + stack.Peek());
            Console.WriteLine("Copying stack to array and then popping 3 times.");
            int[] arr = new int[stack.Count];
            arr = stack.CopyTo(arr);

            stack.Pop();
            stack.Pop();
            stack.Pop();

            Console.WriteLine("Stack values(popped 3 times):");
            foreach (int i in stack)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine("\n");

            Console.WriteLine("Array copied before popping:");
            foreach (int i in arr)
            {
                Console.Write($"{i} ");
            }


        }
    }
}