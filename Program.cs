void PrintArray(string[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
            Console.Write($"{array[i]} \t");          
    }
}
string[] newArray;
Console.Write("Введите элементы массива через запятую: ");
string? stringArray = Console.ReadLine();
string[] array = stringArray.Split(',').ToArray();

Console.WriteLine("Исходный массив:");
PrintArray(array);

Console.WriteLine();

Console.Write("Введите максимальную длинну элемента: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Полученный массив:");
newArray = (from elem in array where elem.Length <= n select elem).ToArray();

PrintArray(newArray);