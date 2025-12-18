namespace Simulator;

public static class Game
{
    public static int money = 0;
    public static int rating = 0;
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
        Console.WriteLine("To view your current player info, say ''Info''");
        Thread.Sleep(1000);
        input();
        if (lResponse == "info")
        {
            PlayerInfo();
        }
    }

    public static void Test()
    {
        GameStart();
        NameInquiry();
        Menu();
    }
}