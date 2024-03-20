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




// string[] myStrings = new string[2] {"I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices"};
// int stringsCount = myStrings.Length;

// string myString = "";
// int periodLocation = 0;

// for (int i = 0; i < stringsCount; i++)
// {
//     myString = myStrings[i];
//     periodLocation = myString.IndexOf(".");

//     string mySentence;

//     while(periodLocation != -1)
//     {
//         mySentence = myString.Remove(periodLocation);

//         myString = myString.Substring(periodLocation + 1);

//         myString = myString.TrimStart();

//         periodLocation = myString.IndexOf(".");

//         Console.WriteLine(mySentence);
//     }

//     mySentence = myString.Trim();
//     Console.WriteLine(mySentence);
// }


// using System;

// int[] times = {800, 1200, 1600, 2000};
// int diff = 0;

// Console.WriteLine("Enter current GMT");
// int currentGMT = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Current Medicine Schedule:");

// /* Format and display medicine times */
// DisplayTimes();

// Console.WriteLine();

// Console.WriteLine("Enter new GMT");
// int newGMT = Convert.ToInt32(Console.ReadLine());

// if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
// {
//     Console.WriteLine("Invalid GMT");
// }
// else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0) 
// {
//     diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));

//     /* Adjust the times by adding the difference, keeping the value within 24 hours */
//     AdjustTimes();
// } 
// else 
// {
//     diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));

//     /* Adjust the times by adding the difference, keeping the value within 24 hours */
//     AdjustTimes();
// }

// Console.WriteLine("New Medicine Schedule:");

// /* Format and display medicine times */
// DisplayTimes();

// Console.WriteLine();


// void DisplayTimes()
// {
//     /* Format and display medicine times */
//     foreach (int val in times)
//     {
//         string time = val.ToString();
//         int len = time.Length;

//         if (len >= 3)
//         {
//             time = time.Insert(len - 2, ":");
//         }
//         else if (len == 2)
//         {
//             time = time.Insert(0, "0:");
//         }
//         else
//         {
//             time = time.Insert(0, "0:0");
//         }

//         Console.Write($"{time} ");
//     }

//     Console.WriteLine();
// }

// void AdjustTimes()
// {
//     /* Adjust the times by adding the difference, keeping the value within 24 hours */
//     for (int i = 0; i < times.Length; i++) 
//     {
//         times[i] = ((times[i] + diff)) % 2400;
//     }
// }


// If IPA consists of 4 numbers
// and
// if each AIPA number has no leading zeros
// and
// if each IPA number is in rangoe 0-255
// then IPA is valid
// else IPA is invalid

// string[] ipv4Input = {"107.31.1.5", "255.0.0.255", "555..0.555", "255...255"};
// string[] address;
// bool validLength = false;
// bool validZeroes = false;
// bool validRange = false;


// foreach(string ip in ipv4Input)
// {
//     address = ip.Split(".", StringSplitOptions.RemoveEmptyEntries);

//     ValidateLength();
//     ValidateZeroes();
//     ValidateRange();

// if (validLength && validZeroes && validRange) 
// {
//     Console.WriteLine($"{ip} is a valid IPv4 address");
// } 
// else 
// {
//     Console.WriteLine($"{ip} is an invalid IPv4 address");
// }
// }

// void ValidateLength()
// {
//     validLength = address.Length == 4;
// }

// void ValidateZeroes() 
// {
//     foreach (string number in address)
//     {
//         if (number.Length > 1 && number.StartsWith("0"))
//         {
//             validZeroes = false;
//             return;
//         }
//     }

//     validZeroes = true;
// }

// void ValidateRange() 
// {
//     foreach (string number in address)
//     {
//         int value = int.Parse(number);
//         if(value < 0 || value > 255)
//         {
//             validRange = false;
//             return;
//         }
//     }

//     validRange = true;
// }



// Random random = new Random();
// int luck = random.Next(100);

// string[] text = { "You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to" };
// string[] good = { "look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!" };
// string[] bad = { "fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life." };
// string[] neutral = { "appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature." };

// TellFortune();
// luck = random.Next(100);
// TellFortune();

// void TellFortune()
// {

//     Console.WriteLine("A fortune teller whispers the following words:");
//     string[] fortune = (luck > 75 ? good : (luck < 25 ? bad : neutral));
//     for (int i = 0; i < 4; i++)
//     {
//         Console.Write($"{text[i]} {fortune[i]} ");
//     }
// }

// CountTo(5);

// 	void CountTo(int max) 
// 	{
// 		for (int i = 0; i < max; i++)
// 		{
// 			Console.Write($"${i}, ");
// 		}
// 	}

// int[] schedule = { 800, 1200, 1600, 2000 };
// DisplayAdjustedTimes(schedule, 6, -6);

// void DisplayAdjustedTimes(int[] times, int currentGMT, int newGMT)
// {
//     int diff = 0;
//     if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
//     {
//         Console.WriteLine("Invalid GMT");
//     }
//     else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
//     {
//         diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
//     }
//     else
//     {
//         diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
//     }

//     for (int i = 0; i < times.Length; i++) 
//     {
//         int newTime = ((times[i] + diff)) % 2400;
//         Console.WriteLine($"{times[i]} -> {newTime}");
//     }
// }

// string[] students = {"Jenna", "Ayesha", "Carlos", "Viktor"};

// DisplayStudents(students);
// DisplayStudents(new string[] {"Robert","Vanya"});

// void DisplayStudents(string[] students) 
// {
//     foreach (string student in students) 
//     {
//         Console.Write($"{student}, ");
//     }
//     Console.WriteLine();
// }


// double pi = 3.14159;
// PrintCircleInfo(12);
// PrintCircleInfo(24);

// void PrintCircleInfo(int radius) 
// {
//     Console.WriteLine($"Circle with radius {radius}");
//     PrintCircleArea(radius);
//     PrintCircleCircumference(radius);
// }
// void PrintCircleArea(int radius)
// {
//     double area = pi * (radius * radius);
//     Console.WriteLine($"Area = {area}");
// }

// void PrintCircleCircumference(int radius)
// {
//     double circumference = 2 * pi * radius;
//     Console.WriteLine($"Circumference = {circumference}");
// }

// string[] guestList = { "Rebecca", "Nadia", "Noor", "Jonte" };
// string[] rsvps = new string[10];
// int count = 0;

// RSVP("Rebecca");
// RSVP("Nadia", 2, "Nuts");
// RSVP(name: "Linh", partySize: 2, inviteOnly: false);
// RSVP("Tony", allergies: "Jackfruit", inviteOnly: true);
// RSVP("Noor", 4, inviteOnly: false);
// RSVP("Jonte", 2, "Stone fruit", false);
// ShowRSVPs();

// void RSVP(string name, int partySize = 1, string allergies = "none", bool inviteOnly = true)
// {
//     if (inviteOnly)
//     {
//         bool found = false;
//         foreach (string guest in guestList)
//         {
//             if (guest.Equals(name))
//             {
//                 found = true;
//                 break;
//             }
//         }
//         if (!found)
//         {
//             Console.WriteLine($"Sorry, {name} is not on the guest list");
//             return;
//         }
//     }

//     rsvps[count] = $"Name: {name}, \tParty Size: {partySize}, \tAllergies: {allergies}";
//     count++;
// }

// void ShowRSVPs()
// {
//     Console.WriteLine("\nTotal RSVPs:");
//     for (int i = 0; i < count; i++)
//     {
//         Console.WriteLine(rsvps[i]);
//     }
// }


// string[,] corporate = 
// {
//     {"Robert", "Bavin"}, {"Simon", "Bright"},
//     {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
//     {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
// };

// string[,] external = 
// {
//     {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
//     {"Shay", "Lawrence"}, {"Daren", "Valdes"}
// };

// string externalDomain = "hayworth.com";
// string abbreviation = "";

// for (int i = 0; i < corporate.GetLength(0); i++) 
// {
//     DisplayEmail(first: corporate[i,0], last: corporate[i,1]);
// }

// for (int i = 0; i < external.GetLength(0); i++) 
// {
//     DisplayEmail(first: external[i,0], last: external[i,1], domain: externalDomain);
// }

// void DisplayEmail(string first, string last, string domain = "constoso.com")
// {
//     string email = first.Substring(0,2) + last;
//     email = email.ToLower();
//     Console.WriteLine($"{email}@{domain}");
// }

// double total = 0;
// double minimumSpend = 30.00;

// double[] items = {15.97, 3.50, 12.25, 22.99, 10.98};
// double[] discounts = {0.30, 0.00, 0.10, 0.20, 0.50};

// for (int i = 0; i < items.Length; i++)
// {
//     if (TotalMeetsMinimum())
// {
//     total -= 5.00;
// }
//     total += GetDiscountedPrice(i);
// }

// Console.WriteLine($"Total: ${FormatDecimal(total)}");

// double GetDiscountedPrice(int itemIndex)
// {
//     // Calculate the discounted price of the item
//     return items[itemIndex] * (1 - discounts[itemIndex]);
// }

// bool TotalMeetsMinimum()
// {
//     // Check if the total meets the minimum
//     return total >= minimumSpend;
// }

// string FormatDecimal(double input)
// {
//     return input.ToString().Substring(0, 5);
// }


// double usd = 23.73;
// int vnd = UsdToVnd(usd);

// Console.WriteLine($"${usd} USD = ${vnd} VND");
// Console.WriteLine($"${vnd} VND = ${VndToUsd(vnd)} USD");

// int UsdToVnd(double usd) 
// {
//     int rate = 23500;
//     return (int) (rate * usd);
// }

// double VndToUsd(int vnd) 
// {
//     double rate = 23500;
//     return vnd / rate;
// }


// string input = "there are snakes at the zoo";

// Console.WriteLine(input);
// Console.WriteLine(ReverseSentence(input));

// string ReverseWord(string word) 
// {
//     string result = "";
//     for(int i = word.Length - 1; i >= 0; i--)
//     {
//         result += word[i];
//     }
//     return result;
// }

// string ReverseSentence(string input) 
// {
//     string result = "";
//     string[] words = input.Split(" ");

//     foreach(string word in words)
//     {
//         result += ReverseWord(word) + " ";
//     }

//     return result.Trim();
// }

// string[] words = {"racecar" ,"talented", "deified", "tent", "tenet"};

// Console.WriteLine("Is it a palindrome?");
// foreach (string word in words) 
// {
//     Console.WriteLine($"{word}: {IsPalindrome(word)}");
// }

// bool IsPalindrome(string word) 
// {
//     int start = 0;
//     int end = word.Length - 1;

//     while(start < end)
//     {
//         if(word[start] != word[end])
//         {
//             return false;
//         }
//         start ++;
//         end --;
//     }

//     return true;
// }

// int target = 30;
// int[] coins = new int[] {5, 5, 50, 25, 25, 10, 5};
// int[,] result = TwoCoins(coins, target);

// if (result.Length == 0) 
// {
//     Console.WriteLine("No two coins make change");
// } 
// else 
// {
//     Console.WriteLine($"Change found at positions:");
//     for(int i = 0; i < result.GetLength(0); i++)
//     {
//         if(result[i,0] == -1)
//         {
//             break;
//         }
//         Console.WriteLine($"{result[i,0]}, {result[i,1]}");
//     }
// }

// // int[] TwoCoins(int[] coins, int target) 
// int[,] TwoCoins(int[] coins, int target)
// {
//     int[,] result = {{-1,-1},{-1,-1},{-1,-1},{-1,-1},{-1,-1}};
//     int count = 0;

//     for(int curr = 0; curr < coins.Length; curr++)
//     {  
//         for (int next = curr + 1; next < coins.Length; next++)
//         {
//             if(coins[curr] + coins[next] == target)
//             {
//                 result[count,0] = curr;
//                 result[count,1] = next;
//                 count ++;
//             }
//             if(count == result.GetLength(0))
//             {
//                 return result;
//             }

//         }
//     }

//     return(count == 0) ? new int[0,0] : result;

// }


// Random random = new Random();

// Console.WriteLine("Would you like to play? (Y/N)");
// if (ShouldPlay())
// {
//     PlayGame();
// }

// bool ShouldPlay()
// {
//     string response = Console.ReadLine();
//     return response.ToLower().Equals("y");
// }

// void PlayGame()
// {
//     var play = true;

//     while (play)
//     {
//         var target = GetTarget();
//         var roll = RollDice();

//         Console.WriteLine($"Roll a number greater than {target} to win!");
//         Console.WriteLine($"You rolled a {roll}");
//         Console.WriteLine(WinOrLose(roll, target));
//         Console.WriteLine("\nPlay again? (Y/N)");

//         play = ShouldPlay();
//     }
// }

// int GetTarget()
// {
//     return random.Next(1, 6);
// }

// int RollDice()
// {
//     return random.Next(1, 7);
// }

// string WinOrLose(int roll, int target)
// {
//     if (roll > target)
//     {
//         return "You Win!";
//     }
//     return "You lose!";
// }


// using System;

// string[] pettingZoo =
// {
//     "alpacas", "capybaras", "chickens", "ducks", "emus", "geese",
//     "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws",
//     "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
// };

// PlanSchoolVisit("School A");
// PlanSchoolVisit("School B", 3);
// PlanSchoolVisit("School C", 2);

// void PlanSchoolVisit(string schoolName, int groups = 6)
// {
//     RandomizeAnimals();
//     string[,] group = AssignGroup();
//     Console.WriteLine(schoolName);
//     PrintGroup(group);
// }

// void RandomizeAnimals()
// {
//     Random random = new Random();

//     for (int i = 0; i < pettingZoo.Length; i++)
//     {
//         int r = random.Next(i, pettingZoo.Length);

//         string temp = pettingZoo[r];
//         pettingZoo[r] = pettingZoo[i];
//         pettingZoo[i] = temp;
//     }
// }


// string[,] AssignGroup(int groups = 6)
// {
//     string[,] result = new string[groups, pettingZoo.Length/groups];
//     int start = 0;

//     for(int i = 0; i < groups; i++)
//     {
//         for(int j = 0; j < result.GetLength(1); j++)
//         {
//             result[i,j] = pettingZoo[start++];
//         }
//     }
//     return result;
// }


// void PrintGroup(string[,] group)
// {
//     for(int i = 0; i < group.GetLength(0); i++)
//     {
//         Console.Write($"Group {i + 1}: ");
//         for(int j = 0; j < group.GetLength(1); j++)
//         {
//             Console.Write($"{group[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// there will be 3 visiting schools
// School 1 has 6(default)
// School 2 has 3 visiting groups
// School 3 has 2 groups

// for each visiting school, perform these tasks:
// 1. randomize animals
// 2. assign animals to the correct number of groups
// 3. print school name
// 4. print animal groups


