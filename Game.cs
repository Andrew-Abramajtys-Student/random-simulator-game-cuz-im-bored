namespace Simulator;

public static class Game
{
    public static double money = 0;
    public static double rating = 1;
    public static string player = "";
    public static string response = "";
    public static string lResponse = "";

    public static void input()
    {
        response = Console.ReadLine();
        lResponse = response.ToLower();
        if (lResponse == "end")
        {
            Environment.Exit(0);
        }
    }
    
    public static void PlayerInfo()
    {
        Console.WriteLine("Your current balance is $" + money);
        Console.WriteLine("Your current rating is " + rating);
        Console.WriteLine("Name: " + player);
        Thread.Sleep(1000);
        Console.WriteLine("Press anything to continue");
        input();
        Thread.Sleep(1000);
        Menu();
    }

    public static void NameInquiry()
    {
        Console.WriteLine("What is your name?");
        player = Console.ReadLine();
        if (player == "end")
        {
            Environment.Exit(0);
        }
    }

    public static void GameStart()
    {
        Console.WriteLine("Welcome to unnamed simulator game");
        Thread.Sleep(1000);
        Console.WriteLine("Allan please add details.");
        Thread.Sleep(1500);
        Console.WriteLine("Press anything to continue");
        input();
    }

    public static void Menu()
    {
        Console.WriteLine("What do you want to do?");
        Thread.Sleep(1000);
        Console.WriteLine("To view your current player info, say \"Info\"");
        Console.WriteLine("To earn money and increase your rating, say \"Work\"");
        Thread.Sleep(1000);
        input();
        if (lResponse == "info")
        {
            PlayerInfo();
        }
        if (lResponse == "work")
        {
            Work();
        }
    }

    public static void Work()
    {
        Console.WriteLine("I dont have a good system for this yet so say 1 to work correct and 2 to work incorrect");
        input();
        if (lResponse == "1")
        {
            Console.WriteLine("Correct! You have been paid accordingly and your rating has gone up a lil bit");
            money = money + (50 * rating);
            rating = rating + 0.1;
        }
        if (lResponse == "2")
        {
            Console.WriteLine("Incorrect! You have been underpaid and your rating has gone down (if it even can)");
            money = money + 10;
            if (rating > 1)
            {
                rating = rating - 0.1;
            }
        }
        Menu();
    }

    public static void Start()
    {
        GameStart();
        NameInquiry();
        Menu();
    }
}