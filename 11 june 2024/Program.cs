//guess the number software
//creating a instance of the random class
Random random = new Random();
int randomNumber = random.Next(0, 10);
Console.WriteLine("Guess the number");
int userNumber = int.Parse(Console.ReadLine());
Console.WriteLine("computer guessed " + randomNumber);
if(randomNumber == userNumber)
{
    Console.WriteLine("you guessed right");
  
}
else
{
    Console.WriteLine("Try again");
}
