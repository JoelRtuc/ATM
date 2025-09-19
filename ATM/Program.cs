namespace ATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pin;
            string name;
            List<Costumer> costumers = new List<Costumer>();
            Costumer selectedCostumer = new Costumer();

            costumers.Add(new Costumer(1234, "john doe", 1000.0));
            costumers.Add(new Costumer(1235, "jane doe", 2000.0));

            while (true)
            {
                Console.WriteLine("Enter Pin");
                pin = int.TryParse(Console.ReadLine(), out pin) ? pin : 0;
                Console.WriteLine("Enter Name");
                name = Console.ReadLine();

                foreach (Costumer costumer in costumers)
                {
                    selectedCostumer = costumer.ActivateAccount(pin, name.ToLower());

                    if (selectedCostumer != null)
                    {
                        break;
                    }
                }

                if (selectedCostumer == null)
                {
                    Console.WriteLine("Invalid credentials");
                    continue;
                }

                Console.WriteLine("Select an option:\n1. Deposit\n2. Withdraw\n3. Check Balance");

                int selectedOption = int.TryParse(Console.ReadLine(), out selectedOption) ? selectedOption : 0;

                switch (selectedOption)
                {
                    case 1:
                        Console.WriteLine("Enter amount to deposit:");
                        double depositAmount = double.TryParse(Console.ReadLine(), out depositAmount) ? depositAmount : 0;
                        selectedCostumer.Deposit(depositAmount);
                        Console.WriteLine("Deposit successful");
                        break;
                    case 2:
                        Console.WriteLine("Enter amount to withdraw:");
                        double withdrawAmount = double.TryParse(Console.ReadLine(), out withdrawAmount) ? withdrawAmount : 0;
                        selectedCostumer.Withdraw(withdrawAmount);
                        Console.WriteLine("Withdrawal successful");
                        break;
                    case 3:
                        selectedCostumer.CheckBalance();
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        continue;

                }
            }

        }
    }
}
