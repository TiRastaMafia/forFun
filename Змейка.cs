

int N = 5;	// Поменять размер матрицы
int num = 1;
int sizeMarrix = N - 2;
// int delta = 0; // Поменять рамку заполнения где 1 самая полная
int[,] numbers = new int[N, N];

int rows = numbers.GetUpperBound(0) + 1;    // количество строк
int columns = numbers.GetUpperBound(1) + 1; // количество столбцов потому что 0 уже занят строкой

for (int delta = 0; delta < N - 2; delta++){
    for (int i = 0 + delta; i < N - delta; i++){
        numbers[0 + delta, i] = num;
        num++;
    }
    num--; // уменьшение num для исключения наложения при переключении стороны
    for (int i = 0 + delta; i < N - delta; i++){
        numbers[i, 4 - delta] = num;
        num++;
    }
    num--;
    for (int i = N - 1 - delta; i >= 0 + delta; i--){
        numbers[4 - delta, i] = num;
        num++;
    }
    num--;
    for (int i = N - 1 - delta; i >= 1 + delta; i--){
        numbers[i, 0 + delta] = num;
        num++;
    }
    num--;
    num++;
}
// Вывод резудьтата
for (int i = 0; i < rows; i++){
    for (int j = 0; j < columns; j++){
        Console.Write($"{numbers[i, j]} \t");
    }
    Console.WriteLine();
}


