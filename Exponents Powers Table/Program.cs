using System.Runtime.CompilerServices;

bool runProgram = true;

while (runProgram)
{
    //get number
    int num = getNum();

    //make our table
    makeTable(num);

    //continue or end our program
    runProgram = contProgram();
}

//Method for retrieving our number
static int getNum()
{
    //Welcome the User and get their number
    Console.Write("Hello User, what number would you like to plug into the Powers Table?: ");
    int num = int.Parse(Console.ReadLine());
    //Formating
    Console.WriteLine();

    //Validate the number as posible for squaring and within the bounds of Int
    while (num <= 0 || num > 1290)
    {
        Console.Write("That is not a valid number for the Powers Table, please enter a valid number (1-1290): ");
        num = int.Parse(Console.ReadLine());
        //Formating
        Console.WriteLine();
    }

    //Return our number to our main program
    return num;
}

//Method for Squaring Numbers
static int sqNum(int num)
{
    return num * num;
}

//Method for Cubing Numbers
static int cubeNum(int num)
{
    return num * num * num;
}


//Method for making powers table
static void makeTable(int num)
{
    //Base formating for text
    Console.WriteLine(String.Format("{0,6}      | {1,15}      | {2,15}", "Number","Squared","Cubed"));
    Console.WriteLine("====================================================");

    //For loop to print out all numbers and their calculations
    for (int i = 1; i <= num; i++)
    {
        Console.WriteLine(String.Format("{0,6}      | {1,15}      | {2,15}", $"{i}", $"{sqNum(i)}", $"{cubeNum(i)}"));
    }
    Console.WriteLine();
}


//Method to ask user to continue using
static bool contProgram()
{
    Console.Write("Would you like to do another Powers Table?(Y/N): ");
    string answer = Console.ReadLine().ToUpper().Trim().Substring(0, 1);
    Console.WriteLine();

    //Validation loop until user enters Y or N
    while (answer != "Y" &&  answer != "N")
    {
        Console.WriteLine("Please enter a valid answer!(Y/N): ");
        answer = Console.ReadLine().ToUpper().Trim().Substring(0, 1);
        Console.WriteLine();
    }

    //Return boolean values for runProgram variable
    if (answer == "Y")
    {
        return true;
    }
    else
    {
        Console.WriteLine("Bye Bye User!");
        return false;
    }
}