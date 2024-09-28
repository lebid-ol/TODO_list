using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.Unicode;
        List<string> Todo = new List<string>();
     
        // В этом задании вам нужно создать список дел.
        // Исплоьзуйте массив или лист для хранения списка дел.
        // При запуске программа должна выводить меню на экран и ждать дальнейших действий пользователя.
        // После выполнения действия программа должна снова выводить меню и ждать дальнейших действий пользователя.
        // Все действия должны выполняться до тех пор, пока пользователь не выберет пункт "Выход".
        
        
        while (true)
        {
            Console.WriteLine("Список дел:");

            // Выводим список задач
            for (int i = 0; i < Todo.Count; i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"{i + 1}. {Todo[i]}");
                Console.ResetColor();
            }

            // Выводим меню
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1. Добавить задачу");
            Console.WriteLine("2. Удалить задачу");
            Console.WriteLine("3. Выход");

            // Обрабатываем выбор пользователя
            bool resultinput = int.TryParse(Console.ReadLine(), out int result);
            while (!resultinput || result <= 0 || result >= 4)
                {
                    Console.Write("Данные некорретны. Введите числовое значение от 1 до 3: ");
                    resultinput = int.TryParse(Console.ReadLine(), out result);
                }
            
            if (result == 3)
            {
                break;
            }

            switch (result)
            {
                case 1: Console.Write("Введите новую задачу: ");
                        string new_task = Console.ReadLine();
                    Todo.Add(new_task);
                    Console.WriteLine("Задача добавлена");
                    break;

                case 2: Console.Write("Введите номер задачи для удаления: "); 
                    bool elementToRemove = int.TryParse(Console.ReadLine(), out int number);
                    while (!elementToRemove)
                        {
                            Console.Write("Данные некорретны. Введите числовое значение задачи для удаления: ");
                            elementToRemove = int.TryParse(Console.ReadLine(), out number);
                        }
                    if (number >= 1 && number <= Todo.Count)
                        {
                            // Удаляем элемент по указанному индексу
                            Todo.RemoveAt(number - 1);
                            Console.WriteLine("Задача удалена");
                        }
                        else
                        {
                            Console.WriteLine("Задача с указанным номером не найдена");
                        }                      
                    break;
            }
        }
    }
}