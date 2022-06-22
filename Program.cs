string input = Console.ReadLine();

int number = Int32.Parse(input);

int module = number % 2;


if (module == 0)
{
    Console.WriteLine("Even");
}  else  {
    Console.WriteLine("odd");
}

