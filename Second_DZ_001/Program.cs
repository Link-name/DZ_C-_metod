void SecondNumber()
{
    Console.WriteLine("введите число");
    int number = int.Parse(Console.ReadLine());
    int count = number / 10 % 10;
    Console.WriteLine(count);
}



void numbers()
{
    Console.WriteLine("введите число");
    int number = int.Parse(Console.ReadLine());
    int count = 0;
    int min = 99;
    if (number > min) 
    {
        count = number % 10;
    Console.WriteLine(count);
    }
    else Console.WriteLine("Третьего числа нет");
   

}



void weekend()
{
    Console.WriteLine("Введите день недели");
    int number = int.Parse(Console.ReadLine());
    int numb1 = 6;
    int numb2 = 7;
    if (numb1 == number)
    {
        Console.WriteLine("Введенный день недели  " + number + "   выходной");
    }
    else if (numb2 == number)
    {
        Console.WriteLine("Введенный день недели  " + number + "   выходной");
    }
    else 
    {
        Console.WriteLine("Введите день недели  не является выходным днем");
    }


}

weekend();