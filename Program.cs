Console.WriteLine("Введите размер массива: ");
int count = Convert.ToInt32(Console.ReadLine());

String[] mass = new String[count];

Console.WriteLine("Введите объекты массива: ");

for (int i = 0; i < count; i++)
{
    mass[i] = Console.ReadLine();
}


Console.ReadLine();


int size_String(string[] mass)
{
    int j = 0;
    String[] result = new String[count];

    for (int i = 0; i < mass.Length; i++)
    {
        int size = System.Text.ASCIIEncoding.Unicode.GetByteCount(mass[i]) / 2;
        if (size <= 3)
        {
            result[j] = mass[i];
            j++;
        }
    }

    for (int i = 0; i < result.Length; i++)
    {
        Console.Write(result[i] + " ");
    }
    return 0;
}


