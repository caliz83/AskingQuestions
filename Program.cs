bool letsPlay = true;

while(letsPlay == true)
{
string name1;
string time2;

Console.WriteLine("What is your name?");
name1 = Console.ReadLine();
Console.WriteLine("What time did you wake up?");
time2 = Console.ReadLine();
Console.WriteLine("Your name is " + name1 + " and you woke up at " + time2 + " today.");


bool question = true;
while(question == true)
{
Console.WriteLine("Do you want to play again? Y/N");
string playAgain = Console.ReadLine().ToUpper();

if(playAgain == "Y")
{
    letsPlay = true;
    question = false;
}
else if(playAgain == "N")
{
    letsPlay = false;
    question = false;
    Console.WriteLine("Goodbye.");
}
else
{
    Console.WriteLine("Please enter a valid option: Y or N");
    question = true;
}
}
}