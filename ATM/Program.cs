namespace ATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pin, socialSecurity;
            string name;
            List<Costumer> costumers = new List<Costumer>();
            Costumer selectedCostumer = new Costumer();

            costumers.Add(new Costumer(1234, "john doe", 1000.0m, 12345));
            costumers.Add(new Costumer(1235, "jane doe", 2000.0m, 12346));

            while (true)
            {
                Console.WriteLine("Enter Pin");
                pin = int.TryParse(Console.ReadLine(), out pin) ? pin : 0;
                Console.WriteLine("Enter Name");
                name = Console.ReadLine();
                Console.WriteLine("Enter Social Security Number");
                socialSecurity = int.TryParse(Console.ReadLine(), out socialSecurity) ? socialSecurity : 0;

                foreach (Costumer costumer in costumers)
                {
                    selectedCostumer = costumer.ActivateAccount(pin, name.ToLower(), socialSecurity);

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

                Console.WriteLine("Select an option:\n1. Deposit\n2. Withdraw\n3. Check Balance\n4. Exit");

                int selectedOption = int.TryParse(Console.ReadLine(), out selectedOption) ? selectedOption : 0;

                switch (selectedOption)
                {
                    case 1:
                        Console.WriteLine("Enter amount to deposit:");
                        decimal depositAmount = decimal.TryParse(Console.ReadLine(), out depositAmount) ? depositAmount : 0;
                        selectedCostumer.Deposit(depositAmount);
                        Console.WriteLine("Deposit successful");
                        break;
                    case 2:
                        Console.WriteLine("Enter amount to withdraw:");
                        decimal withdrawAmount = decimal.TryParse(Console.ReadLine(), out withdrawAmount) ? withdrawAmount : 0;
                        selectedCostumer.Withdraw(withdrawAmount);
                        Console.WriteLine("Withdrawal successful");
                        break;
                    case 3:
                        selectedCostumer.CheckBalance();
                        break;
                    case 4:
                        Console.WriteLine("Have a nice day");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        continue;

                }
            }

        }
    }
}
