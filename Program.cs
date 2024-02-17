Console.WriteLine("Введите количество элементов массива");
int num_of_elements = Convert.ToInt32(Console.ReadLine());
string[] array = new string[num_of_elements];
Console.WriteLine("Заполните ваш массив");
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine("Введите элемент "+i);
    array[i] = Console.ReadLine()!;
}
Console.WriteLine($"Ваш массив: [{string.Join(", ", array)}]");

int num_of_str = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        num_of_str++;
    }
}
string[] newArray = new string[num_of_str];

int index_count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        newArray[index_count] = array[i];
        index_count++;
    }
}
Console.WriteLine($"Новый массив: [{string.Join(", ", newArray)}]");