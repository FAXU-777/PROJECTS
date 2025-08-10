 Console.WriteLine("Enter number one: ");
        int numberOne = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter number two: ");
        int numberTwo = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Now choose an operator: ");
        Console.WriteLine("1. + ");
        Console.WriteLine("2. - ");
        Console.WriteLine("3. * ");
        Console.WriteLine("4. / ");

        int operation = Convert.ToInt32(Console.ReadLine());

        switch (operation)
        {
            case 1:
                double sum = numberOne + numberTwo;
                Console.WriteLine("The sum of " + numberOne +" and " + numberTwo +" is "+  sum);
            break;
            case 2:
                double sub = numberOne - numberTwo;
                Console.WriteLine(numberOne + " - "+ numberTwo+ " = " + sub);
                break;
            case 3:
                double num = numberOne * numberTwo;
                Console.WriteLine(numberOne +" * "+ numberTwo+ " = "+ num );
                break;
            case 4:
                if (numberTwo == 0)
                {
                    Console.WriteLine("Cannot divide by zero!");
                }
                else
                {
                    double div = numberOne / numberTwo;
                    Console.WriteLine($"{numberOne} / {numberTwo} = {div}");
                }
                break;
            
            default: Console.WriteLine("Invalid input");
                break;
        }
