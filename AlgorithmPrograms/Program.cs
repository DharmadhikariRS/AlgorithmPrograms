namespace AlgorithmPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            
            Console.WriteLine("Algorithm Programs");
            Console.WriteLine("Press 1 for Insertion Sort");
            Console.WriteLine("Press 2 for Bubble Sort");
            int input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1:
                    InsertionSort insertionSort = new InsertionSort("English", "Marathi", "Hindi", "Telugu", "Punjabi");
                    break;
                case 2:
                    BubbleSort bubbleSort = new BubbleSort("English", "Marathi", "Hindi", "Telugu", "Punjabi");
                    break;
                default:
                    Console.WriteLine("Wrong Input");
                    break;
            }

        }
    }
}