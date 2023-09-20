// See https://aka.ms/new-console-template for more information
// 


/*  Simple Dice game in c#
        Author:B alogun Muhammed-Awwal
        Date: 20/09/2023
        Description: This is a simple cli dice game with limited funtionalities.
        It works by generating a random number which stimulates a human roll with
        a probability of 1/6. It validates some conditions to display some certain
        messages and performs some operations under the hood which is not really 
        under the hood :) > try it out your self. To run the code simply run dotnet run
        in your terminal Enjoy. 
*/

const int DOUBLEPOINT = 2;
const int TRIPLEPOINT = 6;
int totalPoint;
const int LUCKYNUMBER = 21;

System.Console.Write("====== Dice Game ======\ntype 'Start' or 'S' to roll the dice: ");
string startRoll = Console.ReadLine()!;

if (!(startRoll.Equals("Start", StringComparison.OrdinalIgnoreCase) || startRoll.Equals("S", StringComparison.OrdinalIgnoreCase)))
{
    System.Console.WriteLine("Enter 'Start' or 'S' to roll the dice");
    return;
}


Random random = new();
int dice0ne = random.Next(1, 7);
int diceTwo = random.Next(1, 7);
int diceThree = random.Next(1, 7);
totalPoint = dice0ne + diceTwo + diceThree;

System.Console.WriteLine($"Dice one {dice0ne} \t Dice Two {diceTwo}\tDice Three {diceThree}");


// check to see if  three faces of a  die is equal
if (dice0ne == diceTwo && diceTwo == diceThree)
{
    System.Console.WriteLine("You scored a bonus point of 6");
    totalPoint += TRIPLEPOINT;
    System.Console.WriteLine(totalPoint);
}
// Check to see if two die is equal 
else if (dice0ne == diceTwo || diceTwo == diceThree || dice0ne == diceThree)
{
    System.Console.WriteLine("You scored a bonus point of 2");
    totalPoint += DOUBLEPOINT;
    System.Console.WriteLine(totalPoint);
}
// =======  PRIZES =======
if (totalPoint >= 10 && totalPoint <= 13)
{
    System.Console.WriteLine("Congratulations!!! :)\nYou get a balloon");
    System.Console.WriteLine(totalPoint);
}
else if (totalPoint >= 14 && totalPoint <= 16)
{
    System.Console.WriteLine("Congratulations!!! (:)(\nYou get an Exercise");
}
else if (totalPoint == 17)
{
    System.Console.WriteLine("Congratulations!!! (:)(\nYou get a 5000mah power bank");
}
else if (totalPoint == LUCKYNUMBER)
{
    System.Console.WriteLine("Congratulations!!!\nYou rolled the lucky number");
    System.Console.WriteLine("You win a Samsung A24");
}
else if (totalPoint >= 18 && totalPoint <= 20)
{
    System.Console.WriteLine("Congratulations!!! :)\nYou win a Sliver bird Cinema Ticket");
}

else if (totalPoint >= 22 && totalPoint <= 24)
{
    System.Console.WriteLine("Congratulations!!! :)\nYou win all gifts");
}
// ====== You did not recieve any prize
else
{
    System.Console.WriteLine("Sorry try again");
}