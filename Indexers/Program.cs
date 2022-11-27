class SampleCollection<T>
{
    // Declare an array to store the data elements.
    private T[] arr;
    public SampleCollection(short n)
    {
        arr = new T[n];
    }

    // Define the indexer to allow client code to use [] notation.
    public T this[short i]
    {
        get { return arr[i]; }
        set { arr[i] = value; }
    }
}

class Program
{
    static void Main()
    {
        short n = 10;
        SampleCollection<double> doubleCollection = new SampleCollection<double>(n);
        short i = 0; double input = 0.0;

        while (i < n)
        {
            Console.Write($"Enter the {i + 1} data: ");
            double.TryParse(Console.ReadLine(), out input);
            doubleCollection[i++] = input;
        }
        for (short index = 0; index < n; index++)
        {
            doubleCollection[index] = doubleCollection[index] + (doubleCollection[index] * 10 / 100);
            Console.WriteLine($"Index of collection {index}: {doubleCollection[index]}");
        }
        Console.ReadKey();
    }
}