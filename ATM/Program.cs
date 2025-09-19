namespace ATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int selectedPersonIndex;
            List<Costumer> costumers = new List<Costumer>();
            Costumer selectedCostumer;

            costumers.Add(new Costumer(1234, "John Doe", 1000.0));
            costumers.Add(new Costumer(1235, "Jane Doe", 1000.0));

            Console.WriteLine("Enter Pin");


            foreach (Costumer costumer in costumers)
            {
                costumer.ActivateAccount(Convert.ToInt32(Console.ReadLine()), Console.ReadLine());
            }

        }
    }
}
