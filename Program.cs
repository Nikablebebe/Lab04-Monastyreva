// int age = 15;
// if (age >= 18) 
// {
//   Console.WriteLine("Доступ разрешён");
// }
// Console.WriteLine( "Программа продолжает работу");


//  int age = 15;
//  if (age >= 18) 
//  {
//    Console.WriteLine("Доступ разрешён");
//  } else
//   {
//  Console.WriteLine("Доступ запрещён");
//  Console.WriteLine($"До совершеннолетия осталось ждать: {18 - age} лет");
//  }

//  int age = 60;
//  if (age < 13) {
//      Console.WriteLine("Ребёнок");
// } else if (age < 18) {
//    Console.WriteLine("Подросток");
// } else if (age < 60) {
//      Console.WriteLine("Взрослый");
//  } else {
//      Console.WriteLine("Пенсионер");
//  }

// int age = 16;
//  double height = 1.55;
// bool hasAdult = true; 

//  if (age >= 14 && (height >= 1.5 || hasAdult)) {
//      Console.WriteLine("Можно кататься");
//  } else
//  {
//     Console.WriteLine("Пока нельзя");
//  }

// ЗАДАЧА А

// Console.Write("Введите число: ");
// string input = Console.ReadLine();
// int number = int.Parse(input);

// if (number % 2 == 0)
//  {
//      Console.WriteLine($"{number} — чётное число");
//   } else
//    {
//        Console.WriteLine($"{number} — нечётное число");
//    }

//ЗАДАЧА В
// Console.Write("Введите первое число: ");
// int numberOne = int.Parse(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int numberTwo = int.Parse(Console.ReadLine());
// Console.Write("Введите третье число: ");
// int numberThree = int.Parse(Console.ReadLine());

// if (numberOne >= numberTwo && numberOne >= numberThree)
// {
//     Console.WriteLine($"Наибольшее: {numberOne}");
// } else if (numberTwo >= numberOne && numberTwo >= numberThree)
// {
//     Console.WriteLine($"Наибольшее: {numberTwo}");
// } else
// {
//     Console.WriteLine($"Наибольшее: {numberThree}");
// }

// Console.Write("Введите свою фамилию: ");
// string surname = Console.ReadLine()!.Trim();
// if (string.IsNullOrEmpty(surname)) {
// Console.WriteLine("Фамилия не введена. Завершение работы.");
// return;
// }
// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);
// var assigned = Enumerable.Range(1, 10)
// .OrderBy(_ => rnd.Next())
// .Take(2)
// .OrderBy(x => x)
// .ToList();
// Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");

//ВАРИАНТ 1

// Console.Write("Введите целое число: ");
// int number = int.Parse(Console.ReadLine());

// if (number > 0)
// {
//    Console.WriteLine("Положительное");
// } else if (number < 0)
// {
//    Console.WriteLine("Отрицательное");
// } else
// {
//    Console.WriteLine("Ноль");
// }

//ВАРИАНТ 9

Console.Write("Игрок 1, введите К (камень), Н (ножницы) или Б (бумага): ");
string p1 = Console.ReadLine();

Console.Write("Игрок 2, введите К (камень), Н (ножницы) или Б (бумага): ");
string p2 = Console.ReadLine();

if ((p1 != "К" && p1 != "Н" && p1 != "Б") || (p2 != "К" && p2 != "Н" && p2 != "Б"))
{
   Console.WriteLine("Ошибка ввода");
} else if (p1 == p2)
{
   Console.WriteLine("Ничья");
} else if (p1 == "К" && p2 == "Н")
{
   Console.WriteLine("Победил Игрок 1");
} else if (p2 == "К" && p1 == "Н")
{
   Console.WriteLine("Победил Игрок 2");
} else if (p1 == "Н" && p2 == "Б")
{
    Console.WriteLine("Победил Игрок 1");
} else if (p2 == "Н" && p1 == "Б")
{
    Console.WriteLine("Победил Игрок 2");
} else if (p1 == "Б" && p2 == "К")
 {
      Console.WriteLine("Победил Игрок 1");
} else if (p2 == "Б" && p1 == "К")
{
        Console.WriteLine("Победил Игрок 2");
}