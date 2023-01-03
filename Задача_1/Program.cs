//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int GetLogNumber(string message) 
{
    int result = 0;

    while(true)
    {
        Console.WriteLine(message);
        if(int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else 
        {
            Console.WriteLine("Ввели не число");
        }
    }

    return result;
} 

int midNum = GetLogNumber("Пожалуйста введите трехзначсное число: ");

// while (true)      (Так и не смог придумать, как сделать цикл не таким косячным)
// {
//     if (midNum > 100 && midNum < 999 )
//     {
//         break;
//     }
//     else 
//     {   
//         Console.WriteLine("Введите корректное число");
//     }
    
// }

midNum = (midNum /10) % 10;

Console.WriteLine($"Ваше число по середине: {midNum}");


