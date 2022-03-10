Console.WriteLine("Quiere ver los multiplos de 2 o 3?");
Console.WriteLine("(1) Multiplos de 2 (2) Multiplos de 3");
int option = Convert.ToInt32(Console.ReadLine());

Console.Clear();
for (int i = 1; i <= 100; i++)
{
    switch (option)
    {
        case 1: 
            if (i % 2 == 0) 
                {
                Console.WriteLine("Multiplos de 2");
                Console.WriteLine(i);
                }
            break;

        case 2:
            if (i % 3 == 0)
            {
                Console.WriteLine("Multiplos de 3");
                Console.WriteLine(i);
            }
            break;
    }
}
