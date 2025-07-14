 Random random = new Random();
        bool playAgain = true;
        int min = 1;
        int max = 100;
        int guess;
        int number;
        int guesses;
        
        while (playAgain)
        {
            guess = 0;
            guesses = 0;
            number = random.Next(min, max+1);
            Console.WriteLine("Guess a number between 1 and 100: " );
        
            while (guess != number)
            {
                
                guess = Convert.ToInt32(Console.ReadLine());
                
        
                if (guess > number)
                {
                    Console.WriteLine(guess + " is high, try lower");
                }
                else if (guess < number)
                {
                    Console.WriteLine(guess + " is lower, try higher");
                }
        
                guesses++;
            }
            Console.WriteLine("Congrats!! you guessed my number in "+ guesses +" attempts");
            Console.WriteLine("My number was: " + number);
            Console.WriteLine(" ");
            Console.WriteLine("1. Play again");
            Console.WriteLine("2. Exit");
            int retry = Convert.ToInt32(Console.ReadLine());

            switch (retry)
            {
                case 1 : Console.WriteLine("Okay lets play again");
                    break;
                case 2 : return;
                default: Console.WriteLine("Pleas enter 1 or 2");
                    break;
            }
       
        }