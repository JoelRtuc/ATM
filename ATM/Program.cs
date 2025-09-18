namespace ATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Costumer> costumers = new List<Costumer>();

            costumers.Add(new Costumer(1234, "John Doe", 1000.0));
            costumers.Add(new Costumer(1235, "Jane Doe", 1000.0));


        }
    }
}
