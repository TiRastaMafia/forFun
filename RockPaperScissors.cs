//Создание объекта для генерации чисел
Random rnd = new Random();
//Получить очередное (в данном случае - первое) случайное число

string CombOfComp = "";
int Winner = 0;
int Looser = 0;
int rock = 299, paper = 599, scissors = 900;
int victory = 3;

do
{
    int Num = rnd.Next(900);
    
    System.Console.WriteLine($"У Вас {Winner} побед у компьютера {Looser} побед");
    Console.WriteLine($"Введите ваш вариант: rock, paper, scissors ?");
    
    string userAnswer =  Console.ReadLine().ToLowerInvariant();


    // Если у компьютера камень
    if (Num <= rock)
    {
        CombOfComp = "rock";

        if (userAnswer == CombOfComp)
        {
            Console.WriteLine($"компьютер выбрал {CombOfComp} = Ничья");
        }
        else if (userAnswer == "paper")
        {
            Console.WriteLine($"компьютер выбрал {CombOfComp} Вы проиграли");
            Looser++;
        }
        else if (userAnswer == "scissors")
        {
            Console.WriteLine($"компьютер выбрал {CombOfComp} Вы выйграли");
            Winner++;
        }

    }
    // Если у компьютера бумага
    else if (rock <= Num && Num <= paper)
    {
        CombOfComp = "paper";
        if (userAnswer == CombOfComp)
        {
            Console.WriteLine($"компьютер выбрал {CombOfComp} = Ничья");
        }
        else if (userAnswer == "rock")
        {
            Console.WriteLine($"компьютер выбрал {CombOfComp} Вы проиграли");
            Looser++;
        }
        else if (userAnswer == "scissors")
        {
            Console.WriteLine($"компьютер выбрал {CombOfComp} Вы выйграли");
            Winner++;
        }
    }
    // Если у компьютера ножницы
    else if (Num <= scissors)
    {
        CombOfComp = "scissors";

        if (userAnswer == CombOfComp)
        {
            Console.WriteLine($"компьютер выбрал {CombOfComp} = Ничья");
        }
        else if (userAnswer == "rock")
        {
            Console.WriteLine($"компьютер выбрал {CombOfComp} Вы выйграли");
            Winner++;
        }
        else if (userAnswer == "paper")
        {
            Console.WriteLine($"компьютер выбрал {CombOfComp} Вы проиграли");
            Looser++;
        }
    }

}

while (Winner != victory + 1 && Looser != victory + 1); 

 System.Console.WriteLine($"У Вас {Winner} побед(ы) у компьютера {Looser} побед(ы)\n!!! Поздравляем Вы выйграли!!!");















