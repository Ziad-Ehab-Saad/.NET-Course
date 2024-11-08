namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfSmall = 0,  numOfLarge = 0 ;
            Console.WriteLine("Enter number of small carpets : ");
            numOfSmall=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of large capets : ");
            numOfLarge=int.Parse(Console.ReadLine());
            Console.WriteLine("price per small room : $25");
            Console.WriteLine("price per large room : $35");
            int cost = (numOfSmall * 25 )+( numOfLarge * 35);
            Console.WriteLine($"Cost : ${cost}");
            double tax = cost * 0.06;
            Console.WriteLine($"Tax : ${tax}");
            double totalEstiamte = tax + cost;
            Console.WriteLine($"Total estiamte :${totalEstiamte} ");
            Console.WriteLine("this estiamte is valid for 30 days");    









        }
    }
}
