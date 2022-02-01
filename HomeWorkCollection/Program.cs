
// HOMEWORK1
//Create a Console Application that has variables
//to hold a person's name, age, if they are alive,
//and their phone number.  You do not need to
//capture these values from the user.


string firstName =  "Tom";
string lastName = "Beaudoin";
int age = 53;
bool deceased = true;
string phoneNumber = @$"(404) 294-8354";

Console.WriteLine(value: $"My name is {firstName} {lastName} and I am {age} years old");
Console.WriteLine(value: $"My Phone Number is {phoneNumber}");
Console.WriteLine(value: $"My deceased status is {!deceased}");
