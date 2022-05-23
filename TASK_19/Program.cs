/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
23432 -> да
12821 -> да
*/

Console.WriteLine("Введите число: ");
int Number=Convert.ToInt32(Console.ReadLine());
int Numb=Number;
int reverse = 0;
while(Numb>0)
{
    int varNumber = Numb%10;
    Numb=Numb/10;
    reverse=reverse*10+varNumber;
}
if(Number==reverse)
{
    Console.WriteLine(Number+" -> да ");
}
else
{
    Console.WriteLine(Number+" -> нет ");
}