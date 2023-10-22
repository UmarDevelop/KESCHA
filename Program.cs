

System.Console.WriteLine("Please enter number which you wanna calculate ");
decimal Number1 = Convert.ToDecimal(Console.ReadLine());
System.Console.WriteLine("Please enter second number which you wanna calculate ");
decimal number2 = Convert.ToDecimal(Console.ReadLine());
System.Console.WriteLine("Please choose symbol(+, -, *, /,) ");
Console.ReadLine();
decimal result = Number1 * number2;
decimal result1 = Number1 / number2;
decimal result2 = Number1 + number2;
decimal result3 = Number1 - number2;

System.Console.WriteLine($"if adding two numbers each other rusult is: {Number1} + {number2} = {result2}");
System.Console.WriteLine($"if subtraction two numbers each other rusult is: {Number1} - {number2} = {result3}");
System.Console.WriteLine($"if multiple two numbers each other rusult is: {Number1} * {number2} = {result}");
System.Console.WriteLine($"if divide two numbers each other rusult is: {Number1} / {number2} = {result1}");

decimal firstNumber;
decimal secondNumber;
string name;
string greeting = "Assalomu Aleykum";
System.Console.WriteLine("Hi welcome to our website\nWhat is your name ?");
name = Console.ReadLine();
System.Console.WriteLine($"{greeting} {name}");

System.Console.WriteLine("Lets compare numbers !!!");
System.Console.WriteLine("Enter 1st number which you wanna compare: ");
firstNumber = Convert.ToDecimal(Console.ReadLine());
System.Console.WriteLine("Enter 2nd nuber which you wanna compare: ");
secondNumber = Convert.ToDecimal(Console.ReadLine());
System.Console.WriteLine($"1st number is bigger than 2nd {firstNumber > secondNumber}");
System.Console.WriteLine($"1st number is samll than 2nd number {firstNumber < secondNumber}");
System.Console.WriteLine($"1st number is equal to 2nd number {firstNumber == secondNumber}");
System.Console.WriteLine($"1st number is small or equal than 2nd number {firstNumber <= secondNumber}");
System.Console.WriteLine($"1st number is bigger or equal than 2nd number {firstNumber >= secondNumber}");
System.Console.WriteLine($"1st and 2nd numbers are not equal {firstNumber != secondNumber}");

int keschasAge = 5;
int myAge;
System.Console.WriteLine("lets compare our ages\n how old are you ?");
myAge = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"great {name} your age is: {myAge}");
System.Console.WriteLine($"my age is: {keschasAge}");
int difer = myAge - keschasAge;
System.Console.WriteLine($"Our age difference is:{difer}");
System.Console.WriteLine($"Umar is bigger than kescha {myAge > keschasAge}");
System.Console.WriteLine($"Umar is small than kescha {myAge < keschasAge}");
System.Console.WriteLine($"Umar's and kescha's age is equal {myAge == keschasAge}");
System.Console.WriteLine($"Umar is bigger or equal than kescha {myAge >= keschasAge}");
System.Console.WriteLine($"Umar is small or equal than kescha {myAge <= keschasAge}");
System.Console.WriteLine($"Umar's and kescha's age are not equal {myAge != keschasAge}");



    
  
