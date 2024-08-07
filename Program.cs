Console.Title = "REMOSYS";

Console.WriteLine("Enter ID: ");
var id = Console.ReadLine();

Console.WriteLine("Enter password: ");
int psw = Convert.ToInt32(Console.ReadLine());

Console.Clear();

Console.WriteLine("Enter ID again: ");
var id2 = Console.ReadLine();

Console.WriteLine("Enter password again: ");
int psw2 = Convert.ToInt32(Console.ReadLine());

Console.Clear();

////// FIRST SOLUTION
var resultId = (id == id2) ? "IDs match" : "IDs do not match";
var resultPsw = (psw == psw2) ? "Passwords match" : "Passwords do not match";
Console.WriteLine(resultId);
Console.WriteLine(resultPsw);

////// SECOND SOLUTION

if (id == id2)
{
    Console.WriteLine("IDs match");
}
else
{
    Console.WriteLine("IDs do not match");
}
if (psw == psw2)
{
    Console.WriteLine("Passwords match");
}
else
{
    Console.WriteLine("Passwords do not match");
}
