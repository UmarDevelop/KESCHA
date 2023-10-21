

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

    
  
