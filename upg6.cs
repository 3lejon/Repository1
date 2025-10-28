        // upg6
        Console.Write("enter a number to loop,then how many times it loops");
        string message = Console.ReadLine();


        int loopCounter = Convert.ToInt32(Console.ReadLine());
        if (loopCounter <= 0)
        {
            Console.WriteLine("please enter a value above 0");
        }
        else
        {
            for (int i = 0; i < loopCounter; i++)
            {
                Console.WriteLine(message);
            }
        } Console.WriteLine("Loop is finished");