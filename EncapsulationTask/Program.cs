namespace EncapsulationTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new("Apple", "Iphone16", 1000, 500, 10);

            Console.WriteLine("Products:");
            product.GetInfo();
            Phone phone = new("Apple", "Iphone16", 1000, 500, 10,8,"white",0);
            phone.Seconds(10);
            phone.Money(10);
            phone.GetInfo();
            
            
        }
    }
}
