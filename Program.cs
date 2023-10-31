

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


//Birinchi topshiriq
//outRadius = 4.23M;
//inRadius = 3;

decimal uzun =2;
decimal radius;
decimal pi = 3.14159265358979323846264338327950288419716939937510m;
System.Console.WriteLine("Doira ichki yuzi va aylana uzunligini hisoblash");
System.Console.WriteLine($"Ichki yuza qiymatini topish uchun berilgan radiusni kiriting: ");
radius = Convert.ToDecimal(Console.ReadLine());
System.Console.WriteLine("Bajarilmoqda...");
decimal resultForl = radius * radius * pi;
System.Console.WriteLine($"Doira yuzi:L={resultForl}");

System.Console.WriteLine("Aylanani ichki uzunligini topish uchun radousni kiriting ");
radius = Convert.ToDecimal(Console.ReadLine());
System.Console.WriteLine("hisoblanmoqda...");
decimal uzunlig = uzun * pi * radius;
System.Console.WriteLine($"S={uzunlig}");


decimal uzunOut =2;
decimal radiusOut;
decimal piOut = 3.141592653589793238462643383279502884197169399375m;
System.Console.WriteLine("Doira tashqi yuzi va aylana uzunligini hisoblash");
System.Console.WriteLine($"Tashqi yuza qiymatini topish uchun berilgan radiusni kiriting: ");
radiusOut = Convert.ToDecimal(Console.ReadLine());
System.Console.WriteLine("Bajarilmoqda...");
decimal resultOut = radiusOut * radiusOut * piOut;
System.Console.WriteLine($"Doira yuzi:L={resultOut}");

System.Console.WriteLine("Aylanani tashqi uzunligini topish uchun radousni kiriting ");
radius = Convert.ToDecimal(Console.ReadLine());
System.Console.WriteLine("hisoblanmoqda...");
decimal uzunligOut = uzunOut * piOut * radiusOut;
System.Console.WriteLine($"S={uzunligOut}");

//ikkinchi topshiriq
decimal kurs = 12400;
decimal miqdor;
System.Console.WriteLine("Assalomu Aleykum Hurmatli mijoz\n Dollor Konvertatsiya Bo'limiga hush kelibsiz ");
System.Console.WriteLine("Konvertatsiya qilmoqchi bo'lgan summa miqdorini kiriting: ");
miqdor = Convert.ToDecimal(Console.ReadLine());
System.Console.WriteLine("Hissoblanmoqda...");
decimal hissob = kurs * miqdor;
System.Console.WriteLine($"{hissob}sum");

decimal kurs1 = 12400;
decimal miqdor1;
System.Console.WriteLine("Assalomu Aleykum Hurmatli mijoz\n Dollor Konvertatsiya Bo'limiga hush kelibsiz ");
System.Console.WriteLine("Konvertatsiya qilmoqchi bo'lgan summa miqdorini kiriting: ");
miqdor1 = Convert.ToDecimal(Console.ReadLine());
System.Console.WriteLine("Hissoblanmoqda...");
decimal hissob1 = kurs1 * miqdor1;
System.Console.WriteLine($"{hissob1}sum");

//uchinchi topshiriq
int year = 365;
int usersYear;
int now = 2023;
System.Console.WriteLine("Qiziq siz nechi kundan buyon bu yer yuzida yashab kelyabsiz");
System.Console.WriteLine("Agar bilishni hohlasangiz tug'ilgan yilingizni kititing: ");
usersYear = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Tug'ilgan oyingizni kiriting: ");
int kunlar =  (now - usersYear) * year;
System.Console.WriteLine($"Sizning yashagan kunlaringiz:{kunlar}");

int yearOne = 365;
int usersYearOne;
int nowOne = 2023;
System.Console.WriteLine("Qiziq siz nechi kundan buyon bu yer yuzida yashab kelyabsiz");
System.Console.WriteLine("Agar bilishni hohlasangiz tug'ilgan yilingizni kititing: ");
usersYearOne = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Tug'ilgan oyingizni kiriting: ");
int kunlarOne =  (nowOne - usersYearOne) * yearOne;
System.Console.WriteLine($"Sizning yashagan kunlaringiz:{kunlarOne}");

//Ikkinchi Amaliy Topshiriq - Basics Takrorlash
//Birinchi amaliy vazifa
//Berilgan string va int qiymatlarini xoxlagandek uzgartira olsish mumkin 
//Natija ham uzgaruvchilarga nisbatan uzgaradi 
string str = "Telefon";
string strTwo = "Kompyuter";
int a = 13;
int b =  4;
int inPut;
int outPut;

System.Console.WriteLine($"Kiritilgan ({str}) so'zingizda nechta harf borligini sanab yozing");
inPut = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Kiritilgan ({strTwo}) so'zingizda nechta harf borligini sanab yozing");
outPut = Convert.ToInt32(Console.ReadLine());

string xulosa =
    inPut < a
        ? "TELEFON"
        :  "telefon";
System.Console.WriteLine(xulosa);        
string xulosIkki =
    outPut < b
        ? "KOMPYUTER"
        : "kompyuter";
System.Console.WriteLine(xulosIkki);        

//Ikkinchi amaliy vazifa

int x = 15;
int y = 10;
string resultat =$"({x} > {y})";
if (x > y)
{
    System.Console.WriteLine("x is greater than y");
}
else if (x < y)
{
    System.Console.WriteLine("x is less than y");
}
else if (x == y)
{
    System.Console.WriteLine("x is equal to y");
}
else
{
    System.Console.WriteLine("x and y are not compareble");
}
System.Console.WriteLine(result);

//Uchinchi topshiriq

string haftaKunlari;
System.Console.WriteLine("Hafta kunlarini ingliz va Rus tillarida bilib olshihni xoxlaysizmi?\n Unda ketdik !!! ");
System.Console.WriteLine("Ingliz tili uchun 1 ni rus tili uchun 2 ni yozing ikkala tillar uchun 1 va 2 ni yozing : (Dushanba, Seshanba, Chorshanba, Payshanba, Juma, Shanba, Yakshanba)  ");
haftaKunlari = Console.ReadLine();
string days = haftaKunlari switch
{
     "1" => "Monday-Dushanba\nTuesday-Seshanba\nWednesday-Chorshanba\nThursday-Payshanba\nFriday-Juma\nSaturday-Shanba\nSunday-Yakshanba.",
     "2" => "Понедельник-Dushanba\nBторник-Seshanba\nCреда-Chorshanba\nЧетверг-Payshanba\nПятница-Juma\nСуббота-Shanba\nBоскресенье-Yakshanba",
     "1 2" => "\tEng:\nMonday-Dushanba\nTuesday-Seshanba\nWednesday-Chorshanba\nThursday-Payshanba\nFriday-Juma\nSaturday-Shanba\nSunday-Yakshanba.\n\tRus\nПонедельник-Dushanba\nBторник-Seshanba\nCреда-Chorshanba\nЧетверг-Payshanba\nПятница-Juma\nСуббота-Shanba\nBоскресенье-Yakshanba",
     _  => "Hech qanday til tanlamadingiz "
};
System.Console.WriteLine(days);
    
  
