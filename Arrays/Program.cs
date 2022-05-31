using Arrays;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the size of the Array");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[n];
        Console.WriteLine("Enter the elements in the Array!!");
        for (int i = 0; i < n; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Elements in the Array are: ");
        for (int i = 0; i < n; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();

        //KADEN'S ALGORITHM
        //KadenAlgorithm k1 = new KadenAlgorithm();

        //Console.WriteLine(k1.maxSumArray(arr));

        //MooreVotingAlgorithm m1 = new MooreVotingAlgorithm();
        //Console.WriteLine(m1.majorityElement(arr));

        //BuySellStock_Type1 b1 = new BuySellStock_Type1();
        //Console.WriteLine(b1.maxProfit(arr));

        BuySellStock_Type2 b2 = new BuySellStock_Type2();
        Console.WriteLine(b2.maxProfit(arr));
    }
}