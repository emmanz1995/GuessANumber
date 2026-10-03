string introCaption = "Hi, welcome to the game. What's your name? ";

Console.Write(introCaption);
string userInput = Console.ReadLine() ?? "";

if (string.IsNullOrEmpty(userInput))
{
    Console.WriteLine("Please enter your name to continue application exiting.");
    return;
}

string GreetUser(string username)
{
    return $"Hi user {username}!";
}

Console.WriteLine(GreetUser(userInput));
Console.WriteLine("Guess a number between 0 and 10!");

int userGuess = int.Parse(Console.ReadLine() ?? "");
int cpuGuess = Random.Shared.Next(0, 10);

Console.WriteLine(userGuess == cpuGuess ? "You guessed it!" : "You guessed wrong!");

while (true)
{
    Console.WriteLine("Do you want to play again? (y/n)");
    string playAgain = Console.ReadLine() ?? "";
    if (playAgain.ToLower() == "n")
        break;
    else
    {
        Console.WriteLine("Let's play again!");
        userGuess = int.Parse(Console.ReadLine() ?? "");
        cpuGuess = Random.Shared.Next(0, 10);
        Console.WriteLine(userGuess == cpuGuess ? "You guessed it!" : "You guessed wrong!");
    }
}