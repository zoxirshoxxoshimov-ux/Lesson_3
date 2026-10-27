//Task_1

using System;
using System.Diagnostics;
using System.Threading.Tasks.Dataflow;

Console.WriteLine("Topic:C#");

int planned = 40;
Console.WriteLine($"Planned:{planned}");

double distance = 1.5;
Console.WriteLine($"Distance:{distance}");

decimal rate = 12.50m;
Console.WriteLine($"Rate:{rate}");

char code = 'B';
Console.WriteLine($"Code:{code}");

bool complated = false;
Console.WriteLine($"Complated:{complated}");

long bytes = 5000000000L;
Console.WriteLine($"Bytes:{bytes}");

Console.WriteLine();
Console.WriteLine();



//Task_2

int ActualMinutes = 20;
var SessionCount = 3;
const int MinutesPerHour = 60;
string Topic = "C#";


ActualMinutes += 5;
var TotalMinutes = SessionCount * MinutesPerHour;
int CopiedMinutes = ActualMinutes + 5;
string NewTopic = Topic + "," + "SQL";

Console.WriteLine($"Actual: {ActualMinutes}");
Console.WriteLine($"Total minutes: {TotalMinutes}");
Console.WriteLine($"Minutes original/copy: {ActualMinutes + "," + CopiedMinutes}");
Console.WriteLine($"Topic original/copy: {NewTopic}");

Console.WriteLine();
Console.WriteLine();



//Task_3

Console.WriteLine(18 + 7);
Console.WriteLine(18 - 7);
Console.WriteLine(18 * 7);
Console.WriteLine(18 / 7);
Console.WriteLine(18 % 7);
Console.WriteLine(18.0 / 4);
Console.WriteLine(2 + 3 * 4);
Console.WriteLine((2 + 3) * 4);

Console.WriteLine();
Console.WriteLine();



//Task_4

int PracticeMinutes = 12;
Console.WriteLine(PracticeMinutes);

int a = PracticeMinutes += 8;
Console.WriteLine(a);

int b = PracticeMinutes -= 2;
Console.WriteLine(b);

int c = PracticeMinutes *= 3;
Console.WriteLine(c);

int d = PracticeMinutes /= 4;
Console.WriteLine(d);

int e = ++PracticeMinutes;
Console.WriteLine(e);

int f = --PracticeMinutes;
Console.WriteLine(f);

Console.WriteLine();
Console.WriteLine();



//Task_5

int WholeNumber = 30;
double WholeNumberChange = WholeNumber;
Console.WriteLine(WholeNumberChange);

double DoubleNumber = 9.7;
int DoubleNumberChange = (int)DoubleNumber;
Console.WriteLine(DoubleNumberChange);

int DoubleNumber2 = Convert.ToInt32(9.7);
Console.WriteLine(DoubleNumber2);

double claculation = (double)7 / 2;
Console.WriteLine(claculation);

double claculation2 = (double)(7 / 2);
Console.WriteLine(claculation2);

Console.WriteLine();
Console.WriteLine();



//Task_6

string number = "48";

int ConvertInt = Convert.ToInt32(number);
int ParseInt = int.Parse(number);
Console.WriteLine(ConvertInt);
Console.WriteLine(ParseInt);


double DoubleParse = double.Parse("3,75");
Console.WriteLine(DoubleParse);

decimal DecimalParse = decimal.Parse("9,90");
Console.WriteLine(DecimalParse);

Console.WriteLine();
Console.WriteLine();



//Task_7

string rawTopic = "  Learn C#  ";

Console.WriteLine($"Original length:{rawTopic.Length}");
Console.WriteLine($"Clean topic:{rawTopic.Trim()}");
Console.WriteLine($"Clean length:{rawTopic.Trim().Length}");
Console.WriteLine($"Uppercase:{rawTopic.ToUpper()}");
Console.WriteLine($"Contains:{rawTopic.Contains("C#")}");
Console.WriteLine($"Replacement:{rawTopic.Replace("C#", ".NET")}");

Console.WriteLine();
Console.WriteLine();



//Task_8

Console.WriteLine("Ismingizni kiriting:");
string name = Console.ReadLine() ?? "";

Console.WriteLine("Bugungi mavzuni kiriting:");
string topic = Console.ReadLine() ?? "";

Console.WriteLine("Masofani kiriting:");
string Distance = Console.ReadLine() ?? "";
double DistanceParse = double.Parse(Distance);

Console.WriteLine("Masofani kiriting:");
string Time = Console.ReadLine() ?? "";
double TimeParse = double.Parse(Time);

Console.WriteLine($"Hello:{name}");
Console.WriteLine($"Today's topic:{topic}");
Console.WriteLine($"Average speed:{DistanceParse / TimeParse}");

Console.WriteLine();
Console.WriteLine();



//Task_9

int number1 = 10;
int number2 = 20;

Console.WriteLine(number1 == number2);
Console.WriteLine(number1 != number2);
Console.WriteLine(number1 > number2);
Console.WriteLine(number1 < number2);
Console.WriteLine(number1 <= number2);
Console.WriteLine(number1 >= number2);

Console.WriteLine();
Console.WriteLine();



//Task_10

Console.WriteLine("Rejalashtirilgan daqiqani kiriting:");
string PlannedTime = Console.ReadLine() ?? "";
int PlanTimeParsed = int.Parse(PlannedTime);

Console.WriteLine("Sarflangan vaqtni kiriting:");
string SpentTime = Console.ReadLine() ?? "";
int SpentTimeParsed = int.Parse(SpentTime);

const decimal cost = 12.50m;

decimal calculate = SpentTimeParsed * cost / 60;

Console.WriteLine("Total cost:");
Console.WriteLine(calculate);

Console.WriteLine($"Goal met: {SpentTimeParsed >= PlanTimeParsed}");
Console.WriteLine($"Within plan: {SpentTimeParsed <= PlanTimeParsed}");
Console.WriteLine($"Needs more time: {SpentTimeParsed < PlanTimeParsed}");

Console.WriteLine();
Console.WriteLine();



//Task_11

const int SecondsPerMinute = 60;
const int MinutesPerHour1 = 60;

Console.WriteLine("Jami sekundlarni kiriting:");
string inputSeconds = Console.ReadLine() ?? "";
int totalSeconds = int.Parse(inputSeconds);

int totalSecondsPerHour = SecondsPerMinute * MinutesPerHour1;

int hours = totalSeconds / totalSecondsPerHour;
int remainingSeconds = totalSeconds % totalSecondsPerHour;

int minutes = remainingSeconds / SecondsPerMinute;
int seconds = remainingSeconds % SecondsPerMinute;

int reconstructedSeconds =
    hours * totalSecondsPerHour +
    minutes * SecondsPerMinute +
    seconds;

Console.WriteLine($"Hours: {hours}");
Console.WriteLine($"Minutes: {minutes}");
Console.WriteLine($"Seconds: {seconds}");
Console.WriteLine($"Reconstructed seconds: {reconstructedSeconds}");

Console.WriteLine();
Console.WriteLine();



// Task_11

Console.WriteLine("Enter total seconds:");
string Task11_Input = Console.ReadLine() ?? "";
int Task11_TotalSeconds = int.Parse(Task11_Input);

const int Task11_SecondsPerMinute = 60;
const int Task11_MinutesPerHour = 60;

int Task11_SecondsPerHour =Task11_SecondsPerMinute * Task11_MinutesPerHour;

int Task11_Hours =Task11_TotalSeconds / Task11_SecondsPerHour;

int Task11_RemainingSeconds =Task11_TotalSeconds % Task11_SecondsPerHour;

int Task11_Minutes =Task11_RemainingSeconds / Task11_SecondsPerMinute;

int Task11_Seconds =Task11_RemainingSeconds % Task11_SecondsPerMinute;

int Task11_ReconstructedSeconds =Task11_Hours * Task11_SecondsPerHour +Task11_Minutes * Task11_SecondsPerMinute +Task11_Seconds;

Console.WriteLine($"Hours: {Task11_Hours}");
Console.WriteLine($"Minutes: {Task11_Minutes}");
Console.WriteLine($"Seconds: {Task11_Seconds}");
Console.WriteLine($"Reconstructed seconds: {Task11_ReconstructedSeconds}");

Console.WriteLine();
Console.WriteLine();



 // Task_12

Console.WriteLine("Enter temperature in Celsius:");
string Task12_Input = Console.ReadLine() ?? "";
double Task12_Celsius = double.Parse(Task12_Input);

double Task12_Fahrenheit =Task12_Celsius * 9.0 / 5 + 32;

double Task12_Kelvin =Task12_Celsius + 273.15;

bool Task12_BelowZero = Task12_Celsius < 0;

Console.WriteLine($"Celsius: {Task12_Celsius:F2}");
Console.WriteLine($"Fahrenheit: {Task12_Fahrenheit:F2}");
Console.WriteLine($"Kelvin: {Task12_Kelvin:F2}");
Console.WriteLine($"Below zero: {Task12_BelowZero}");

Console.WriteLine();
Console.WriteLine();




 // Task_13

Console.WriteLine("Enter a username:");
string Task13_OriginalUsername = Console.ReadLine() ?? "";

int Task13_OriginalLength =Task13_OriginalUsername.Length;

string Task13_TrimmedUsername =Task13_OriginalUsername.Trim();

string Task13_ReplacedUsername =Task13_TrimmedUsername.Replace(" ", "_");

string Task13_Username =Task13_ReplacedUsername.ToUpperInvariant();

int Task13_UsernameLength =Task13_Username.Length;

bool Task13_ContainsUnderscore =Task13_Username.Contains("_");

bool Task13_LengthInRange =Task13_UsernameLength >= 5 &&Task13_UsernameLength <= 12;

Console.WriteLine($"Original length: {Task13_OriginalLength}");
Console.WriteLine($"Username: {Task13_Username}");
Console.WriteLine($"Username length: {Task13_UsernameLength}");
Console.WriteLine($"Contains underscore: {Task13_ContainsUnderscore}");
Console.WriteLine($"Length in range: {Task13_LengthInRange}");

Console.WriteLine();
Console.WriteLine();




 // Task_14

Console.WriteLine("Enter your age:");
string Task14_Input = Console.ReadLine() ?? "";
int Task14_Age = int.Parse(Task14_Input);

Console.WriteLine("Do you have a library card? (true/false)");
string Task14_CardInput = Console.ReadLine() ?? "";
bool Task14_HasCard = Task14_CardInput == "true";

bool Task14_CanBorrow = Task14_Age >= 14 && Task14_HasCard;

Console.WriteLine($"Age requirement met: {Task14_Age >= 14}");
Console.WriteLine($"Can borrow: {Task14_CanBorrow}");

Console.WriteLine();
Console.WriteLine();
