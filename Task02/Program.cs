//Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. 
//Сформируйте строку, в которой все заглавные буквы заменены на строчные.


string input = "aBcD1ef!-";
System.Console.WriteLine("Начальная строка" );
System.Console.WriteLine(input);
string result = input.ToLower();
System.Console.WriteLine("Обработанная строка");
System.Console.WriteLine(result);