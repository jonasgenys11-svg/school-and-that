int x = 1;
while (x == 1)
{
    Console.WriteLine("ENTER FIRST NUMBER");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("ENTER SECOND NUMBER");
    int num2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter expressions");
    int Express = Convert.ToInt32(Console.ReadLine());
    switch (Express)
    {
        case 0:
            Console.WriteLine("Answer is = " + (num1 + num2));
            break;
        case 1:
            Console.WriteLine("Anser is = " + (num1 - num2));
            break;
        case 2:
            Console.WriteLine("Answer is = " + (num1 * num2));
            break;
        case 3:
            Console.WriteLine("Answer is = " + (num1 / num2));
            break;
    }
    Console.WriteLine("Continue?");
    x= Convert.ToInt32(Console.ReadLine());
}
