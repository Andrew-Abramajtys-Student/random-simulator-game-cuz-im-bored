namespace Simulator;

public static class Game
{
    public int money = 0;
    public int rating = 0;
    public string player = "";

    public static void GameInfo()
    {
        Console.WriteLine("Your current balance is $" + money);
        Console.WriteLine("Your current rating is " + rating);
        Console.WriteLine("Name: " + player);
    }

    public static void NameInquiry()
    {
        Console.WriteLine("What is your name?")
        player = Console.ReadLine();
    }

    public static void GameStart()
    {
        Console.WriteLine("Welcome to unnamed simulator game");
        Thread.Wait(1000);
        Console.WriteLine("Allan please add details.");
        Thread.Wait(1500);
        Console.WriteLine("Press anything to continue");
        Console.ReadLine();
    }

    public static void Menu()
    {
        Console.WriteLine("What do you want to do?")
        Thread.Wait(1000);
        Console.WriteLine("To view your current player info, say ");
    }
}