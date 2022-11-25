// Напишите программу, которая на вход принимает число и выдает, является ли число 
// четным (делится ли оно на два без остатка)
// 5->2,4
// 8-> 2,4,6,8\
Console.Clear();
Console.WriteLine("ВВедите число a=");
int a= Convert.ToInt32(Console.ReadLine());
if ((a%2)!=0)
{
    Console.WriteLine("Число четное? НЕТ!");
}
    
else
{
    Console.WriteLine("Число четное? ДА!");
}

