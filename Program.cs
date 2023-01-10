//Greeting to user
Console.WriteLine("Hello and welcome to the number analyzer. What is your name?");
string rawUName = Console.ReadLine().ToLower().Trim();
string uName = rawUName.Substring(0,1).ToUpper() + rawUName.Substring(1);
//Start infinite loop
bool loop = true;
int kick = 0;
do
{
    //Prompt user to enter a interger
    double num1 = 0;
    do
    {
        Console.WriteLine(uName + ", would you please enter a number from 1 to 100?");
        num1 = double.Parse(Console.ReadLine().Trim());
        Console.WriteLine(uName + ", you entered the number " + num1 + ".");
        // Kick user after 3 wrong answers.    
        if (num1 < 1 || num1 > 100)
            {
                kick++;
                if (kick >= 3)
                {
                    break;
                }
            }
    } while (num1 < 1 || num1 > 100 || kick > 3);
    if(kick >= 3)
        {
            break;
        }
    if (kick < 3)
    {
        kick = 0;
    }
        //If/else number sorter
    if (num1 < 60 && num1 % 2 == 1)
    {
        Console.WriteLine(uName + ", the number is odd and less than 60.");
    }
    else if (num1 % 2 == 0 && num1 <= 25)
    {
        Console.WriteLine(uName + ", the number is even and less than 25.");
    }
    else if (num1 % 2 == 0 && num1 <= 60)
    {
        Console.WriteLine(uName + ", the number is even and between 26 and 60.");
    }
    else if (num1 % 2 == 0)
    {
        Console.WriteLine(uName + ", the number is even and greater than 60.");
    }
    else
    {
        Console.WriteLine(uName + ", the number is odd and greater than 60.");
    }
    Console.WriteLine(uName + ", would you like to enter another number?");
    string ans = Console.ReadLine().Trim().ToLower();
    loop = ans == "yes" || ans == "y" || ans == "yeah" || ans == "yep" ? true : false;
} while (loop);
if(kick >= 3)
{
    Console.WriteLine(uName + ", you have entered the wrong number too many times. Have a good day.");
}
else
{
    Console.WriteLine(uName + ", have a good day!");
}

