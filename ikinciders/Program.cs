// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ya Allah");

byte var1 = 50;
byte var2 = 40;//byte.Parse(Console.ReadLine());

int sum = var1 + var2;

Console.WriteLine(sum);

var intmin = int.MinValue;
var intmax = int.MaxValue;

float var3 = 445.65F;
double var4 = 451.35D;

var sum2 = var3 + var4;

Console.WriteLine(sum2);

bool var5 = (6>5) && (4<5);
Console.WriteLine(var5);

char var6 = 'A';
char var7 = 'B';

var concat = var6.ToString() + var7.ToString();

Console.WriteLine(concat);

var var8 = char.IsLetter(var6);
var var9 = char.IsNumber(var7);

Console.WriteLine(var9);
Console.WriteLine(var8);

//string

string var10 = "tahir oxu";
var var11 = var10.ToUpper();
Console.WriteLine(var11);




