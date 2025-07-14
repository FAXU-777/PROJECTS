        int balance = 1000 ;
        while (true)
        {
            Console.WriteLine("Welcome to the ATM");
            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Withdraw");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");
            int num = Convert.ToInt32(Console.ReadLine());
            
            switch (num)
            {
                case 1:
                    Console.WriteLine("Your balance is: "+ balance +"$");
                    break;
                
                case 2:
                    Console.Write("Enter a1mount to deposit: ");
                    int newDeposit = Convert.ToInt32(Console.ReadLine());
                    balance = balance + newDeposit;
                    Console.WriteLine("Now your balance is: " + balance +"$");
                    break;
                case 3:
                    Console.Write("Enter how much you want to withdraw: ");
                    int withdraw = Convert.ToInt32(Console.ReadLine());
                    if (withdraw > balance)
                    {
                        Console.WriteLine("Error, you haved entered more " +
                                          "than you have on balance");
                    }
                    else 
                    {
                        balance = balance - withdraw;
                        Console.WriteLine("Now on you balance is :" + balance +"$");
                    }
                    break;
                case 4: return;
                
                default: Console.WriteLine("Enter number from 1 to 4 to choose your option");
                    break;
            }
            Console.WriteLine(" ");

        }
