Random random = new Random();
        bool playAgain = true;
        
        String player;
        String computer;
        int comp_score = 0;
        int player_score = 0;
        
        
        
        
        while (playAgain)
        {
            player = " ";
            computer = " ";
        
            while (player != "ROCK" && player != "PAPER" && player != "SCISSORS")
            {
        
        
                Console.Write("Enter ROCK, PAPER or SCISSORS: ");
                player = Console.ReadLine();
                player = player.ToUpper();
        
                
            }
        
            int randomNum = random.Next(1, 4);
            switch (randomNum)
            {
                case 1:
                    computer = "ROCK";
                    break;
                case 2:
                    computer = "PAPER";
                    break;
                case 3:
                    computer = "SCISSORS";
                    break;
            }
        
            Console.WriteLine("Player: " + player);
            Console.WriteLine("Computer: " + computer);
           
        
            if (player == computer)
            {
                Console.WriteLine("Its a tie");
            }else if ((player == "ROCK" && computer == "SCISSORS") ||
                      (player == "PAPER" && computer == "ROCK") ||
                      (player == "SCISSORS" && computer == "PAPER"))
            {
                player_score++;
                Console.WriteLine("You win this round!");
                
            }
            else
            {
                comp_score++;
                Console.WriteLine("Computer wins this round!");
                
            }
            
            Console.WriteLine($"Score -> You: {player_score} | Computer: {comp_score}");
        
        }
