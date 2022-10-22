//Задача 13: Напишите программу, которая выводит третью цифру
//(слева направо) заданного числа или сообщает, что третьей цифры нет.
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
while(num>1000)
{
    num=num/10;        
}
if(num<100)
{
    Console.Write("Третьей цифры нет");
}
else
{
    num = num%10;   
    Console.Write($"{num} - третья цифра"); 
}
