// Задача 1: Задайте двумерный массив символов (тип char [,]). 
//Создать строку из символов этого массива.

string CreatString(char[,] array){
    string result = String.Empty;
    for (int i =0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++)
            result += array[i,j];
    }
    return result;
}



char[,] charArray = new char[,]{
    {'a', 'b'},
    {'c', 'd'}
};


System.Console.WriteLine(CreatString(charArray));
