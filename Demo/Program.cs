Random rng = new Random();

#region Introduction
Console.WriteLine("Welcome Trainer!");
Console.WriteLine("What is your name?");
string playerName = Console.ReadLine();
Console.WriteLine("Ha! What a strange name.");
Console.WriteLine("I see you have a Pokemon there with you. What kind is that?");
string userPokemon = Console.ReadLine();
Console.WriteLine($"{playerName} + {userPokemon}, Welcome to the CLI Pokemon battle!");
#endregion

#region PokeStats
int userPokeHp = 100;
int compPokeHp = 100;
#endregion

#region Choice
Console.WriteLine("Your opponent is Charazard!");
Console.WriteLine("What do you choose to do?");
Console.WriteLine("Attack or Run?");
#endregion

string playerChoice = Console.ReadLine();

#region Battle
if (playerChoice == "Attack")
{
    Console.WriteLine("Get ready.... FIGHT!!!!");
    while (compPokeHp > 0)
    {
        int attack = rng.Next(0, 10);
        int attackAccuracy = rng.Next(0, 10);
        int compAttack = rng.Next(0, 10);

        if (attackAccuracy > 3) //I can adjust the value of accuracy here
        {
            compPokeHp -= attack;
            userPokeHp -= compAttack;
            Console.WriteLine($"{userPokemon} has " + userPokeHp + " health left!");
            Console.WriteLine("Charizard has: " + compPokeHp + " health left!");
        }
        else
        {
            Console.WriteLine("The attack missed!");
        }
    }
    if (compPokeHp < userPokeHp)
    {
        Console.WriteLine("You defeated Charizard!");
    }
    else
    {
        Console.WriteLine("You were defated!");
    }
}
else
{
    Console.WriteLine("You ran away?!");
}
#endregion