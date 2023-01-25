Console.WriteLine("Введите размер массива: ");
int count = Convert.ToInt32(Console.ReadLine());

int size = 3;
String[] mass = new String[count];

Console.WriteLine("Введите объекты массива: ");
for(int i = 0; i < count; i++)
{
    mass[i] = Console.ReadLine();
}


for(int i = 0; i < count; i++)
{
    Console.WriteLine(mass[i]);
}



