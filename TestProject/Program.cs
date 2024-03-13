// int hero = 10;
// int monster = 10;

// Random dice = new Random();

// do
// {
//     int roll = dice.Next(1, 11);
//     monster -= roll;
//     Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

//     if (monster <= 0) continue;

//     roll = dice.Next(1, 11);
//     hero -= roll;
//     Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

// } while (hero > 0 && monster > 0);

// Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");


// string? readResult;
// bool validEntry = false;
// Console.WriteLine("Enter a string containing at least three characters:");
// do
// {
//     readResult = Console.ReadLine();
//     if (readResult != null)
//     {
//         if (readResult.Length >= 3)
//         {
//             validEntry = true;
//         }
//         else
//         {
//             Console.WriteLine("Your input is invalid, please try again.");
//         }
//     }
// } while (validEntry == false);


// capture user input in a string variable named readResult




// string? readResult;

// int numericValue = 0;
// bool validNumber = false;

// validNumber = int.TryParse(readResult, out numericValue);



// string? readResult;
// string valueEntered = "";
// int numValue = 0;
// bool validNumber = false;

// Console.WriteLine("Enter an integer value between 5 and 10");

// do{
//     readResult = Console.ReadLine();
//     if(readResult != null)
//     {
//         valueEntered = readResult;
//     }
//     validNumber = int.TryParse(valueEntered, out numValue);

//     if(validNumber == true)
//     {
//         if(numValue <= 5 || numValue >= 10)
//         {
//             validNumber = false;
//             Console.WriteLine($"You entered {numValue}. Please enter a number between 5 and 10.");
//         }
//     }
//     else
//     {
//         Console.WriteLine("Sorry, you entered an invalid number, please try again.");
//     }
// } while (validNumber == false);

// Console.WriteLine($"Your input value ({numValue}) has been accepted.");

// readResult = Console.ReadLine();





// string[] roles = new string[] { "Administrator", "Manager", "User"};

// Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
// string? userInput = Console.ReadLine();

// if (userInput == roles[0] || userInput == roles[1] || userInput == roles[2])
// {
//     Console.WriteLine($"Your input value ({userInput}) has been accepted.");
// }
// else
// {
//     Console.WriteLine($"The role name that you entered, \"{userInput}\" is not valid. Enter your role name (Administrator, Manager, or User)");
   
// }



// string? readResult;
// string roleName = "";
// bool validEntry = false;

// do
// {
//     Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
//     readResult = Console.ReadLine();
//     if (readResult != null)
//     {
//         roleName = readResult.Trim();
//     }

//     if(roleName.ToLower() == "administrator" || roleName.ToLower() == "manager" || roleName.ToLower() == "user") 
//     {
//         validEntry = true;
//     }
//     else 
//     {
//         Console.Write($"The role name that you entered, \"{roleName}\" is not valid. ");
//     }
// }
// while (validEntry == false);

// Console.WriteLine($"Your input value ({roleName}) has been accepted.");
// readResult = Console.ReadLine();



// string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };




string[] myStrings = new string[2] {"I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices"};
int stringsCount = myStrings.Length;

string myString = "";
int periodLocation = 0;

for (int i = 0; i < stringsCount; i++)
{
    myString = myStrings[i];
    periodLocation = myString.IndexOf(".");

    string mySentence;

    while(periodLocation != -1)
    {
        mySentence = myString.Remove(periodLocation);

        myString = myString.Substring(periodLocation + 1);

        myString = myString.TrimStart();

        periodLocation = myString.IndexOf(".");

        Console.WriteLine(mySentence);
    }

    mySentence = myString.Trim();
    Console.WriteLine(mySentence);
}