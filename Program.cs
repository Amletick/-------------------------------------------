static string[] FilterStrings(string[] inputStrings)
{
    // Определяем размер массива resultStrings,
    // который не превышает максимальное количество элементов в inputStrings
    string[] resultStrings = new string[inputStrings.Length];
    int resultIndex = 0;
        foreach (string s in inputStrings)
        {
        if (s.Length <= 3)
            {
            resultStrings[resultIndex] = s;
            resultIndex++;
            }
        }

    // Создаем новый массив, который точно соответствует количеству найденных строк
    string[] finalResult = new string[resultIndex];
    Array.Copy(resultStrings, finalResult, resultIndex);
    return finalResult;
}
      // Можно ввести массив с клавиатуры
Console.Write("Введите строки через запятую: ");
string input = Console.ReadLine();
string[] inputStrings = input.Split(", ");
// Или задать массив на старте
// string[] inputStrings = { "Hello", "2", "world", ":-)" };
string[] filteredStrings = FilterStrings(inputStrings);
Console.WriteLine("Исходный массив: [" + string.Join(", ", inputStrings) + "]");
Console.WriteLine("Отфильтрованный массив: [" + string.Join(", ", filteredStrings) + "]");

