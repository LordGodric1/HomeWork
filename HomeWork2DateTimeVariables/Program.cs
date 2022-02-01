

//Homework2
/* Capture a User's age from the Console and then 
 * identify how old they will be in 25 years, as well 
 * as how old they were 25 years ago.  Print that
 * information to the Console in natural language.
 * 
 * request age
 * calculate age 25 years from now
 * calculate age 25 years ago
 * print results to console
 * 
 */

Console.Write(value: "What is your age: ");

retry:
string? ageText = Console.ReadLine();

bool isvalidInt = int.TryParse(ageText, out int age);

if (isvalidInt  == true)
        {
        Console.WriteLine(value: $"Your have entered the age of {age}.");
        Console.WriteLine(value: $"This makes your age 25 years ago {age - 25} and your future age in 25 years {age + 25}");
        Console.WriteLine("Thank you for using my age program") ;
}
else
        {
        Console.Write(value: $"{ageText} is not a valid age please try again : ");
        goto retry;
        };

Console.WriteLine();





//bool isvalidInt = int.TryParse(ageText, out int age);
//bool isvalidInt = int.TryParse(ageText, out int age);

//Console.WriteLine(ageText + 25);
//Console.WriteLine(ageText - 25);
//Console.WriteLine(value: $"This is valid: {isvalidInt}. The number was {age}.");
/*


Console.Write(value: "What is your age: ");
string? ageText = Console.ReadLine();

// this is concatenating the 15 to entered age.
//Console.WriteLine(ageText + 15);

//int age;
bool isvalidInt  = int.TryParse(ageText, out int age);

Console.WriteLine(value: $"This is valid: {isvalidInt}. The number was {age}.");

Console.WriteLine(age + 15);

double testDouble = age;

decimal testDecimal = (decimal)testDouble;
*/

