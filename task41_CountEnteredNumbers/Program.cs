// Задача 41: Пользователь вводит с клавиатуры М чисел. 
// Посчитайте, сколько чисел больше 0 ввел пользователь.
// 0, 7, 8, -2, -2 ->2
// 1, -7, 567, 89, 223 -> 3

Console.WriteLine("Please enter the amount of numbers you want to enter");
int M=Convert.ToInt32(Console.ReadLine());
int [] array = getArray();
Console.WriteLine("Array is "+String.Join(" ", array));
int [] getArray( )
{
    int [] res=new int [M];
    
    for (int i = 0; i < M; i++)
    {
        Console.WriteLine($"Please enter the {i+1} number");
        int num=Convert.ToInt32(Console.ReadLine());
        res[i]=num;
    }
    return res;
   
}

void countPosNumbers(int [] array)
{
    int count=0;
    for (int j = 0; j < array.Length; j++)
    {
     if (array[j]>0) count ++;
    }
    Console.WriteLine($"Amount of positive numbers is:\t{count}");
}
 countPosNumbers(array);