// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Console.WriteLine("Enter your name : ");
//var n = Console.ReadKey();
//Console.WriteLine(n);
//var name = "ammu";
//Console.Write("haii" +name);
//Console.WriteLine("welcome");

/*
var name = "ammu";
var place = "eklm";

Console.WriteLine("my name is "+name+" i am from "+place);

Console.WriteLine($"my name is {name} and i am from {place}");

*/
//Console.BackgroundColor = ConsoleColor.Cyan;
//Console.ForegroundColor= ConsoleColor.Red;
//Console.WriteLine("hellooo");
//Console.WriteLine("welcome");
//Console.WriteLine("good mrng");
//Console.CursorVisible = false;
//Console.Beep();
//Console.WriteLine(3+1+"7"+"1"+4+2);

//var a = "ammu";
//Console.WriteLine(a);
//a = 67.ToString();
//Console.WriteLine(a);

//string a = 89;
//Console.WriteLine(a);
//Console.WriteLine("enter num 1 : ");

//int num1 = Convert.ToInt32(  Console.ReadLine());


//=======5/7/2025 ---  keziya, mohith=====================================================

//== VALUE  Type

/*

int myint = 10;

Console.WriteLine("integer : "+myint);

Console.WriteLine("integer type : " + myint.GetType());

double myfloat = 10.673543543543553265265362;

Console.WriteLine("float : " + myfloat);

Console.WriteLine("float type : " + myfloat.GetType());


bool mybool = 6 < 9;

Console.WriteLine("bool : " + mybool);

Console.WriteLine("bool type : " + mybool.GetType());

Console.WriteLine(6<9);

char mychar = 'a';
Console.WriteLine("char : " + mychar);

Console.WriteLine("char type : " + mychar.GetType());


//=== Reference type
Console.WriteLine(".............Reference type.....................................");

string mystring = "Hello Goodmrng";
Console.WriteLine("string : " + mystring);

Console.WriteLine("string type : " + mystring.GetType());

int[] myarray = new int[] { 1, 2, 3, 4, 5 };

Console.WriteLine("array : " + myarray);

Console.WriteLine("array type : " + myarray.GetType());

Console.WriteLine("//////////////////////////////////////");

object a="ammu";
// = "string";
Console.WriteLine(a);
Console.WriteLine(" type : " + a.GetType());

//a = 56;
//Console.WriteLine(a);
//Console.WriteLine(" type : " + a.GetType());



Console.WriteLine("////////////boxing , unboxing//////////////////////////");


int valueType = 10; // value type
Console.WriteLine(" type : " + valueType.GetType());
//boxing

object boxedvalue = valueType;
Console.WriteLine("boxed value " + boxedvalue);
Console.WriteLine(" type : " + boxedvalue.GetType());

// unboxing

int uboxvalue = (int)boxedvalue;
Console.WriteLine("unboxed "+ uboxvalue);

Console.WriteLine(" type uboxvalue : " + uboxvalue.GetType());


String str = @"Tutorials Point";
Console.WriteLine(str);
Console.WriteLine(" type str : " + str.GetType());





//============Implicit  && Explicit============================================

// imlicit
//int myint = 10;
//Console.WriteLine(" type myint : " + myint.GetType());
//double mydouble = myint; // impcit int to double

//Console.WriteLine(" type mydouble : " + mydouble.GetType());
//Console.WriteLine(mydouble);

// explicit

double mydouble2 = 10.2;
Console.WriteLine(mydouble2);
int myint2 = (int)mydouble2;
Console.WriteLine(myint2);





//================Arithmetic Operators

//Console.WriteLine(3+9);
Console.WriteLine(6/4);

*/



//=========12/7/2025==========Keziya===========================================================

//Console.WriteLine(63/2);
//double a = 62;
//double b = 2;
//double c =a/b;
//Console.WriteLine(c);

//Console.WriteLine(5%2);

//int a = 10;
//Console.WriteLine(a);
////a++;
//a--;
//Console.WriteLine(a);

//5672532.6357 % 10000; 2532.6357

//354656.57657%100000

//Console.WriteLine(56725326357 % 10000);
//Console.WriteLine(56725326357 / 10000);
//double a = 56725326357;
//double b = 10000;
//double c = a / b;
//Console.WriteLine(c);

//---Comparison / relational

//Console.WriteLine(3==6);
//Console.WriteLine(3 == 3);
//Console.WriteLine(3 != 6);
//Console.WriteLine(14>9);   

//Console.WriteLine(13>=16);

// Logincal

//And 
//1   1   1
//1   0   0
//0   1   0
//0   0   0


//or

//1   1   1
//1   0   1
//0   1   1
//0   0   0 

//not

//0   1
//1   0



//Console.WriteLine((45>23) & (45>89));

//Console.WriteLine((45 > 23) | (45 > 89));

//Console.WriteLine(!(5<78));

// Assignment operator

//int a = 10;
//Console.WriteLine(a);

//a += 5; // a=a+5


//Console.WriteLine(a);

//int b = 5;
//Console.WriteLine(b);
//b -= 8; // b=b-8
//Console.WriteLine(b);

//====decision making=====================

//int time = 21;

//if (time < 12)
//{
//    Console.WriteLine("good mrng");
//}
//else if (time<16)
//{
//    Console.WriteLine("good afternoon");
//}
//else if (time < 20)
//{
//    Console.WriteLine("good evng");
//}
//else
//{
//    Console.WriteLine("good night");
//}



//===================26/7/2025 - Mohith========================================

//=== nested if
/*
int mark = 78;
if (mark >= 50)
{
    if (mark > 90 && mark <= 100)
    {       
        Console.WriteLine("A+");
    }
    else if (mark <= 90 && mark > 80)
    {
        Console.WriteLine("A");
    }
    else if (mark <= 80 && mark > 70)
    {
        Console.WriteLine("B+");
    }
    else
    {
        Console.WriteLine("B");
    }
}
else
{
    Console.WriteLine("failed");
}

*/

//==SWITCH

/*
int day = 13;
string dayname;

switch (day)
{
    case 0:
        dayname = "Sunday";
        break;
    case 1:
        dayname = "Monday";
        break;
    case 2:
        dayname = "Tuesday";
        break;
    default:
        dayname = "invalid day";
        break;
}
Console.WriteLine(dayname);



int day = 12;
string daynmae = day switch { 
    1 => "Monday",
    2 => "Tuesday",
    3 => "Wednesday",
    _=>"invalid day"
};

Console.WriteLine(daynmae);



//=====LOOPING STATEMENTS:


//==WHile

int num = 1;
while (num < 5)
{
    
    Console.WriteLine(num); // 1 2 3 4 
    num++;
}

int num1 = 1;
while (num1 < 5)
{
    num1++;
    Console.WriteLine(num1); // 2 3 4 5
}




//=== DO WHILE

int num = 11;
do
{
    Console.WriteLine(num);
    num++;
}
while (num <5);





for (int i = 0; i < 5; i++)
{
    if (i == 3)
    {
        // break;
        Console.WriteLine("...........");
        continue;
        Console.WriteLine("==================");
    }
    Console.WriteLine(i); // 0 1 2
}




condition ? value_if_true :
value_if_false;




int x = 15;
string result = x > 10 ? $" {x} is greater than 10" :
    $" {x} not greater than 10";

Console.WriteLine(result);


1. no. of digigits in a number
2. sum of digits in a number
3. product of digits in a number
4. 


// Null_Coalescing Operator (??)

string name = null;
string fullname = name ?? "unknown";
Console.WriteLine(fullname);




//Null_Coalescing Assignment Operator(??=)

string name = null;
name ??= "unknown";
Console.WriteLine(name);

*/


//string name = "english";

//for (int i = 0; i < name.Length; i++)
//{
//    Console.WriteLine(name[i]);
//}

//foreach(int c in name)
//{
//    Console.WriteLine(c);
//}

//for (int i = 1; i <= 100; i++)
//{
//    if(i>60 && i <= 90)
//    {
//        Console.WriteLine();

//    }
//    else
//    {
//        Console.WriteLine(i);
//    }
//}



//===================02/8/2025 - Mohith, Keziya========================================

//using System.Data;
//add(3, 6);
//void add(int a, int b)
//{
//    int c = a + b;
//    Console.WriteLine(c);
//}

//============13/9/2025======== Mohith, Keziya===========================================





//============20/9/2025======== Mohith, Keziya===========================================


/*
// pass by values

void byValue(int number)
{
    number += 10;
    Console.WriteLine($"inside function number is {number}");
}

//pass by ref
void byRef(ref int number)
{
    number += 10;
    Console.WriteLine($"inside function number is {number}");
}

int val = 5;
Console.WriteLine($" original value of number is {val}");
//byValue(val);
byRef(ref val);
Console.WriteLine($"  value of number after fun call is {val}");





void byOut(out int number)
{
    number = 10;
    Console.WriteLine($"inside function number is {number}");
}
int a ;


byOut(out a);





void SumOfMark(params int[] marks)
{
    int sum = 0;

    foreach (var mark in marks)
    {

    sum += mark; 
    }

    Console.WriteLine($"my total mark is {sum}");
}

int[] mar = { 1, 2, 3, 4 };

SumOfMark(10, 20, 30, 40);
int a = 10, b = 20, c = 30;

SumOfMark(mar);

SumOfMark(a, b, c);



// ===========27/9/2025========Keziya================================


////ARRAY
*/

//int[] age; // declarion

//int[] age = new int[5]; // inita

//string[] age = new string[5];
//age[0] = "7";
//age[1] = "6";
//age[2] = "haii";
//age[3] = "ammu";
//age[4] = "kevin";


//foreach (int i in age)
//{
//    Console.WriteLine(i);
//}

//for (int i = 0; i < 5; i++)
//{
//    Console.WriteLine(age[i]);
//}

//Console.WriteLine(age[2]);

//int[] age = new int[5];
//int[] age = { 4, 6, 2, 1, 5 };

//int[] age = new int[5] { 4, 2, 5, 7 ,4};


//int[] age = new int[] { 4, 2, 5, 7, 4 };
//Console.WriteLine(age[2]);


////////////Multi dim/////////////////////

//1 2 3
//4 5 6
//     2 by 3



//int[,] matrix = new int[2, 3];//

//int[,] matrix = new int[3, 2] { { 1, 2 }, { 4, 5 }, { 7, 9 } };

//Console.WriteLine(matrix[1,0]);

// jagged array

//int[][] data=new int[4][];

//data[0] = new int[]{ 1,5,8};

//data[1] = new int[] { 11, 35 };

//data[2] = new int[] { 14, 25, 82,45 };
//data[3] = new int[] { 14, 25, 82, 45 };



//int[] age = new int[5] { 4, 2, 5, 7, 1 }; // {1,2,4,5,7}

//int len = age.Length;
////Console.WriteLine(len);
//for (int i = 0; i < len - 1; i++) //3
//{
//    for (int j = 0; j < len - i - 1; j++)
//    {
//      //  Console.WriteLine(age[j] + " ---"+ age[j + 1]);
//        if (age[j] > age[j + 1])
//        {
//            int temp=age[j];
//            age[j] = age[j + 1];
//            age[j + 1] = temp;
//        }
//    }
//   // Console.WriteLine("....................");




//}


//foreach (int kk in age)
//{
//    Console.WriteLine(kk);
//}
//Console.WriteLine(".============================..");




//========4/10/2025=======================================================

//string a = "Hello";
//Console.WriteLine(a[1]);
//a = "Malay5alam";
//Console.WriteLine(a[-2]);

//Console.WriteLine(a.Length);
//int l = a.Length;
//Console.WriteLine(a[l-1]);

//foreach (int c in a)
//{
//    Console.WriteLine(c);
//}

//Console.WriteLine(".........................");

//for (int i = 0; i < l; i++)
//{
//    Console.WriteLine(a[i]);
//}


//string fname = "Ammu";
//string lname = "T";
//string name = fname +" "+ lname;
//Console.WriteLine(name);

//string Name = string.Concat(fname," ", lname);
//Console.WriteLine(Name);

//string a = "Malay5alam";
//string sub = a.Substring(2,5);
//Console.WriteLine(sub);


//string h = "hello";
//string H = "Hello";

//bool isEql = h == H;
//Console.WriteLine(isEql);


//bool isEqIng=string.Equals(h,H,StringComparison.OrdinalIgnoreCase);
//Console.WriteLine(isEqIng);

//Console.WriteLine($"my name is {h}"); // interpolation

//string a1 = "Malayalam";

//int i = a1.IndexOf('l');
//Console.WriteLine(i);

//int i2 = a1.LastIndexOf('a');
//Console.WriteLine(i2);


//string a1 = "Malayalam";


////var d1 = a1.Contains("la");
////Console.WriteLine(d1);

//bool sw = a1.StartsWith("ma");

//bool ew = a1.EndsWith("am");
//Console.WriteLine(ew);


//string a1 = "Malayalam";

//string lo=a1.ToLower();
//Console.WriteLine(lo);
//string up = a1.ToUpper();
//Console.WriteLine(up);

//string a1 = "mmmmMalayalam    mmmmm";
//Console.WriteLine(a1+"kkk");

//string a2 = a1.Trim('M');
//Console.WriteLine(a2+"kkk");



//string a1 = "Malayalam";
//Console.WriteLine(a1);
//string a2 = a1.Replace('l','p',StringComparison.OrdinalIgnoreCase);
//Console.WriteLine(a2);



//string a = "malay alam";
//string[] bb = a.Split();

//foreach (string b in bb)
//{
//    Console.WriteLine(b);
//}




//-------18/10/2025-------------------------------------------

//Humen anu = new Humen(); // object
//anu.talking();


//Humen appu = new Humen(); // object

//Humen kiran = new Humen(); // object
//kiran.walk();

//Console.WriteLine("....................");
//Console.WriteLine(appu.legs);
//Console.WriteLine("....========================");
//appu.legs = 1;
//Console.WriteLine("/////////////////////////");
//Console.WriteLine(appu.legs);
//Console.WriteLine(anu.legs);




using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

///
Humen anu = new Humen(); // object

Humen appu = new Humen("APPU"); // object

Humen kiran = new Humen("KIRAN"); // object

appu.walk();

kiran.walk();

class Humen
{
    public int legs = 2;
    public int eyes = 2;  // variables / attributes
    public string myname;
    public Humen() // constructor , default / non parametrized constructor
    {
        Console.WriteLine("i am humen");
    }

    public Humen(string name) // constructor parametrized constructor
    {

       Console.WriteLine("i am humen with argument");
       myname = name;
    }




    public void walk()  // method / function
    {
        Console.WriteLine($"{myname}  can walking");
    }
    public void talking()  // method / function
    {
        Console.WriteLine($"{myname} talking");
    }

}