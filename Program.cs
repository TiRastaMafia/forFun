/*=========================================================*/
// string z = "31";
// string x = "18";
// string c = "79";
// Console.WriteLine($"{z}, {x}, {c}");

/*====Вывести на одной строке числа 47, 52 и  150=====================================================*/
// string z = "31";
// string x = "18";
// string c = "79";
// Console.WriteLine($"{z}, {x} ии {c}");
/*=== Вывести на экран числа 50 и  10 одно под другим.======================================================*/
// string x = "10";
// string z = "50";
// Console.WriteLine($"{z}");
// Console.Write($"{x}");

/*=====Вывести на экран числа 5, 10 и  21 одно под другим====================================================*/
// string z = "5";
// string x = "10";
// string c = "21";
// Console.WriteLine($"{z},\r\n{x},\r\n{c},");

/*=========================================================*/
// string z = "1";
// string x = "2";
// Console.WriteLine($"{z}\r\n{x}");

/*==1.6==Число π примерно равно 3,1415926. Вывести на экран этоx число с тремя цифрами в дробной части.
Текст '3.142' не использовать.======*/


// double pi = 1.23245325;
// Console.WriteLine(pi.ToString("#.####"));
// // выводит 1,2325
/*===1.7====Число e (основание натурального логарифма) приблизbтельно равно 2,71828. =======================
===========================*/
// double E = 2.71828;
// Console.WriteLine(E.ToString("#.#"));
// // выводит 1,2

/*==1.8=== Составить программу вывода на экран числа, вводимого с  клавиатуры.
//  Выводимому числу должно предшествовать собщение «Вы ввели число».=============================
=======================*/

// Console.WriteLine("Введите число:");
// int result = Convert.ToInt16(Console.ReadLine());
// Console.WriteLine($"Вы ввели число \n\r{result}");

/*====1.9.Составить программу вывода на экран числа, вводимого с клавиатуры. После выводимого числа должно
следовать сообщение «– вот какое число Вы ввели».============*/
// Console.WriteLine("Введите число:");
// int result = Convert.ToInt16(Console.ReadLine());
// Console.WriteLine($" {result} «– вот какое число Вы ввели ");

// /*=1.10= Составить программу, которая запрашивает имя человека и  повторяет его на экране.=======================================================*/
// // где знак ""?""  допускает значение Null
// Console.WriteLine("Введите Имя:");
// string? result = Convert.ToString(Console.ReadLine());
// Console.WriteLine($"{result} ");

/*==1.11 Same=======================================================*/

// /*==1.12= выводится на экран приветствие в виде слова «Привет», после
// которого должна стоять запятая, введенное имя и восклицательный знак.
// После запятой должен стоять пробел, а  перед восклицательным знаком пробела
// быть не должно.======================================================*/

// Console.WriteLine("Введите Имя:");
// string? result = Convert.ToString(Console.ReadLine());
// Console.WriteLine($"Привет, {result}!");

/*==1.13  Напишите программу, в  которую вводится целое число,
после чего на экран выводится следующее и  предыдущее целое
число. Например, при вводе числа 15 на экран должно быть выведено:=============*/

// Console.WriteLine("Введите число:");
// int? result = Convert.ToInt16(Console.ReadLine());
// Console.WriteLine($"Следующее за числом {result} число – {result + 1}\n\rПредыдущее за числом {result} число – {result - 1} ");

/*=1.14====Составить программу вывода на экран в одну строку трех любых чисел, вводимых с клавиатуры, с двумя пробелами между ними.===============*/
// Console.WriteLine("Введите три числа:");
// int? result0 = Convert.ToInt16(Console.ReadLine());
// int? result1 = Convert.ToInt16(Console.ReadLine());
// int? result2 = Convert.ToInt16(Console.ReadLine());
// Console.WriteLine($"{result0}  {result1}  {result2}");

/*====1.15   Same   =====================================================*/

/*=1.16==оставить программу вывода на экран следующей информации:======================================================*/

// Console.WriteLine("Введите значения:");
// string? resultt = Convert.ToString(Console.ReadLine());;
// string? resultv = Convert.ToString(Console.ReadLine());;
// string? resultx = Convert.ToString(Console.ReadLine());;
// string? resulty = Convert.ToString(Console.ReadLine());;

// Console.WriteLine($"{resultt} {resultv}\n\r{resultx} {resulty}");

/*=2.1======= вычисления значения функции y = 17x2 – 6x + 13 при любом значении x;===========
======================================*/
// double x = Convert.ToInt16(Console.ReadLine());
// double y = 0;
// y = 178 * (x*x) - 6 * (x + 13);
// Console.WriteLine(y);



/*====2.2 == Составить программу вычисления значения функции  ===================================================*/
// Console.WriteLine("Введите число a: ");
// double a = Convert.ToDouble(Console.ReadLine());
// double result = ((a * a) + 10) / (Math.Sqrt(a * a + 1));
// Console.WriteLine(result);






/*=====2.3==   Составить программу вычисления значения функции   ====не работает при а = 2 выдает 1.9802   а должно 1.0737=======================================*/

// Console.WriteLine("Введите число a: ");
// double a = Convert.ToDouble(Console.ReadLine());
// double result = Math.Sqrt(2 * a + Math.Sin(Math.Abs(3 * 2)) / 3.56);
// Console.WriteLine(result);



/*====2.4 == Дана сторона квадрата найти его периметр   ===================================================*/

// Console.WriteLine("Введите длинну стороны квадрата: ");
// double a = Convert.ToDouble(Console.ReadLine());
// double result = a * 4;
// Console.WriteLine(result);

/*====2.5 == Дан радиус окружности найти его диаметр   ===================================================*/

// Console.WriteLine("Введите длинну радиуса: ");
// double a = Convert.ToDouble(Console.ReadLine());
// double result = a * 2;
// Console.WriteLine(result);


/*=====2.6================	 Считая, что Земля  – идеальная сфера с  радиусом R ≈
6350  км, определить расстояние до линии горизонта от точки
с  заданной высотой над Землей.====================================*/
// double R = 6350;
// double H;
// for (double d = 1; d < 2; d++)
// {
//     H = (R + d) * (R + d) - (R * R);
//     H = Math.Sqrt(H);
//     Console.WriteLine("Horizone for high " + d + " kilometrs = " + H);
// }



/*==2.7==================Дана длина ребра куба a. Найти объем куба V и площадь его поверхности S.=====================================*/
// Console.WriteLine("Введите длинну ребра куба см: ");
// double a = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Обьем куба: " + Math.Pow(a, 3) + " куб.см\nПлощадь поверхности: " + Math.Pow(a, 2) * 6 + " кв.см");




/*===2.8=============дан радиус окружности. Найти длину окружности и  площадь круга.=========================================*/

// double radius = Convert.ToDouble(Console.ReadLine());
// double length,square;

// length = 2 * (Math.PI) * radius;
// square = (Math.PI) * Math.Pow(radius, 2);
// Console.WriteLine("Длинна окружности равна " + "{0:0.####}", length);
// Console.WriteLine("Площадь круга равна " + "{0:0.####}", square);


/*==2.9 ========  вычисления значения функции ======== z = 2x**3 – 3,44xy + 2,3x**2 – 7,1y + 2===========================*/


// double z, x, y;
// x = Convert.ToDouble(Console.ReadLine());
// y = Convert.ToDouble(Console.ReadLine());

// Convert.ToDouble(Console.ReadLine($"x: {x}  y: {y}"));
// z = 2 * (Math.Pow(x, 3)) - 3.44 * x * y + 2.3 * (Math.Pow(x, 2) - 7.1 * y + 2);
// Console.WriteLine($"результат равен  " + "{0:0.##}", z);

/*====2.10 ===== среднее арифметическое================================================*/
// double result, x, y;
// x = Convert.ToInt32(Console.ReadLine());
// y = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(result = (x + y) / 2);

/*====2.10.1 ===== среднее геометрическое================================================*/
// double result, x, y;
// x = Convert.ToInt32(Console.ReadLine());
// y = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(result = Math.Sqrt(x * y));


/*==2.11=====найти плотность==================================================*/
// double P, m, v;
// m = Convert.ToDouble(Console.ReadLine());
// v = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine(P = m / v);


/*====2.12=====================================================*/

// double PopDes, people, s;
// people = Convert.ToDouble(Console.ReadLine());
// s = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine(PopDes = people / s);

/*====2.12=========== ax + b = 0 (a ≠ 0).==========================================*/

// double result, b, a;
// b = Convert.ToDouble(Console.ReadLine());
// a = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine(result = -(b / a));

/*===2.14=====Даны катеты прямоугольного треугольника. Найти его гипотенузу.=================================================*/
// double result, b, a;
// b = Convert.ToDouble(Console.ReadLine());
// a = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("{0:0.##}", result = Math.Sqrt(Math.Pow(b, 2) + Math.Pow(a, 2)));



/*==2.15==Найти площадь кольца по заданным внешнему и  внутреннему радиусам=====================================================*/

// double result, R, r;
// R = Convert.ToDouble(Console.ReadLine());
// r = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("{0:0.#######}", result = Math.PI * (Math.Pow(R, 2) - Math.Pow(r, 2)));





/*==2.17==== Даны основания и  высота равнобедренной трапеции==Найти его периметр.================================================*/
// void FindPerimetr(double a, double b, double H)
// {
//     double result, A, B, h;
//     A = Convert.ToDouble(Console.ReadLine());
//     B = Convert.ToDouble(Console.ReadLine());
//     h = Convert.ToDouble(Console.ReadLine());
//     Console.WriteLine("{0:0.##}", result = h * ((A + B) / 2));
// }
// FindPerimetr(4, 6, 3);



/*==2.23==== Даны основания и  высота равнобедренной трапеции==Найти его периметр.================================================*/
// void FindPerimetr(double a, double b)
// {
//     double A, B, D;
//     A = Convert.ToDouble(Console.ReadLine());
//     B = Convert.ToDouble(Console.ReadLine());
//     D = Math.Sqrt(Math.Pow(A, 2) + Math.Pow(B, 2));
//     Console.WriteLine($"периметр равен: {(A + B) * 2}," + " диагональ равна: {0:0.##}", D);
// }
// FindPerimetr(4, 6);



/*===2.24.	 Даны два числа. Найти их сумму, разность, произведение, а также частное от деления первого числа на второе.======================================================*/
// void ResultsForSinbols(double a, double b)
// {
//     double A, B;
//     Console.Write("Введите первое число "); A = Convert.ToDouble(Console.ReadLine());
//     Console.Write("Введите второе число "); B = Convert.ToDouble(Console.ReadLine());

//     Console.WriteLine($"сумма равна: {(A + B)}, разность равна: {(A - B)} произведение равно: {(A * B)},"
//                     + " частное равно: {0:0.#}", A / B);
// }
// ResultsForSinbols(0,0);




/*==2.25===========Даны длины сторон прямоугольного параллелепипеда============================================*/

// void paralelepiped(double a, double b, double c)
// {
//     double A, B, C;
//     Console.Write("Введите сторону А "); A = Convert.ToDouble(Console.ReadLine());
//     Console.Write("Введите сторону B "); B = Convert.ToDouble(Console.ReadLine());
//     Console.Write("Введите сторону С "); C = Convert.ToDouble(Console.ReadLine());

//     Console.WriteLine($"объем равен: {(A * B * C)}, " + " площадь равна : {0:0.#}", A * B);
// }
// paralelepiped(0,0,0);





/*========2.26.	 Даны координаты на плоскости двух точек. Найти расстояние между этими точками.=================================================*/

// void FindString(double a, double b, double c, double d)
// {
//     double x1, x2, y1, y2;
//     Console.Write("Введите x1 "); x1 = Convert.ToDouble(Console.ReadLine());
//     Console.Write("Введите y1 "); y1 = Convert.ToDouble(Console.ReadLine());
//     Console.Write("Введите x2 "); x2 = Convert.ToDouble(Console.ReadLine());
//     Console.Write("Введите y2 "); y2 = Convert.ToDouble(Console.ReadLine());

//     Console.WriteLine($"объем равен: " + "{0:0.##}", Math.Sqrt((Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2))));
// }
// FindString(0,0,0,0);


/*=====2.27.	 Даны основания и  высота равнобедренной трапеции. Найти периметр трапеции====================================================*/

//  (P) = a + b + 2√h**2 + (a - b)**2/4

// void FindPerim(double z, double x, double c)
// {
//     double a, b, h;
//     Console.Write("Введите a "); a = Convert.ToDouble(Console.ReadLine());

//     Console.Write("Введите b "); b = Convert.ToDouble(Console.ReadLine());
//     Console.Write("Введите h "); h = Convert.ToDouble(Console.ReadLine());

//     Console.WriteLine($"периметр равен: "+"{0:0.##}",(a + b) + 2*(Math.Sqrt(Math.Pow(h, 2)
//                                                 + (Math.Pow(a - b, 2)) / 4)));
// }
// FindPerim(0, 0, 0);


/*===2.28===== Даны основания равнобедренной трапеции и  угол при большем основании. Найти площадь трапеции.===========*/
// double a, b, alfa;
// Console.WriteLine("Укажите длинну меньшего основания: "); a = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Укажите длинну большего основания: "); b = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Укажите угол A при большем основании: "); alfa = Convert.ToInt32(Console.ReadLine());

// alfa = alfa * 3.1415 / 180;
// double S = ((a * a - b * b) * Math.Tan(alfa)) / 4;
// Console.Write(S);
// Console.Read();

/*========2.31.	 Известна стоимость 1 кг конфет, печенья и яблок. Найти 
стоимость всей покупки, если купили x кг конфет, у  кг печенья 
и  z кг яблок==================================================================================================*/

// void Sum(double a, double b, double c)
// {
//     double CoastOf_1kg_candys = 50;
//     double CoastOf_1kg_chocopie = 32;
//     double CoastOf_1kg_apple = 7;

//     Console.Write("Введите количество конфет: "); double weightCandys = Convert.ToDouble(Console.ReadLine());
//     Console.Write("Введите количество печенья: "); double weightChocopie = Convert.ToDouble(Console.ReadLine());
//     Console.Write("Введите количество яблок: "); double weightApple = Convert.ToDouble(Console.ReadLine());
//     Console.WriteLine($"Вся покупка стоит: " + "{0:0.##}", CoastOf_1kg_candys * weightCandys + CoastOf_1kg_chocopie * weightChocopie 
//                         + CoastOf_1kg_apple * weightApple);
// }
// Sum(0, 0, 0);

/*====Известна стоимость монитора, системного блока, клавиатуры и  мыши.
Сколько будут стоить 3 компьютера из этих элементов? N компьютеров?=====================================================*/

// void Sum(int a)
// {
//     double CoastOf_monitor = 50;
//     double CoastOf_computer_system_unit = 32;
//     double CoastOf_keyboadr = 2;
//     double CoastOf_manipulatormouse_type = 1;

//     Console.Write("Введите количество компьютеров: "); int quantityOfComputers =  Convert.ToInt32(Console.ReadLine());

//     Console.WriteLine($"Вся покупка стоит: " + "{0:0.##}", quantityOfComputers * (CoastOf_monitor
//                         + CoastOf_computer_system_unit + CoastOf_keyboadr + CoastOf_manipulatormouse_type));
// }
// Sum(0);




/*=========2.33.	 Возраст Тани – X лет, а  возраст Мити – Y лет. Найти их
средний возраст, а также определить, на сколько отличается возраст каждого ребенка от среднего значения.================================================*/

// void Sum(int a, int b)
// {
//     double Mitya = 50;
//     double Tanya = 32;

//     Console.WriteLine($"Средний возраст: " + "{0:0.##}", (Mitya + Tanya) / 2);
//     Mitya = Mitya - ((Mitya + Tanya) / 2);
//     Console.WriteLine($"разница со средним возрастом у Мити: " + "{0:0.#}", Mitya);
//     Console.WriteLine($"разница со средним возрастом у Тани: " + "{0:0.#}", Mitya);
// }
// Sum(0,0);

/*===38.	 Напишите программу, в которой вычисляется сумма, разность, произведение, частное и среднее арифметическое
двух целых чисел, введенных с  клавиатуры. Например, при вводе чисел
2 и  7 должен быть получен ответ вида:
2+7=9 2-7=-5 2*7=14 2/7=0.2857142857142857 (2+7)/2=4.5======================================================*/


// void Sum(double a1, double b1)
// {
//     double a, b;
//     Console.Write("Введите a "); a = Convert.ToDouble(Console.ReadLine());
//     Console.Write("Введите b "); b = Convert.ToDouble(Console.ReadLine());

//     Console.WriteLine($"{a} + {b} = " + $"{a + b}; "
//                         + $"{a} - {b} = " + $"{a - b}; "
//                         + $"{a} * {b} = " + $"{a * b}; "
//                         + $"{a} / {b} = " + "{0:0.###}", (a / b) + "; "
//                         + $"{a} + {b} / 2 = " + $"{(a + b) / 2}");
// }
// Sum(0, 0);


/*===Известно значение температуры по шкале Цельсия. Найти соответствующее значение температуры по шкале======================================================*/


// Console.Write("Введите значение: "); double inputValue = Convert.ToDouble(Console.ReadLine());
// // double Kelvin = 0;
// double Celsii = -273.15;
// // double farenheit = -459.67;


// Console.WriteLine($"Фаренгейт = {(inputValue * 1.8) + 32}" );
// Console.WriteLine($"Кельвин =  " + "{0:0.#}", Math.Abs(Celsii - inputValue));



/*====2.37.	 У  американского писателя-фантаста Рэя Бредбери есть роман «450 градусов по Фаренгейту». Разработать программу,
которая определяет, какой температуре по шкале Цельсия соответствует указанное в  названии значение=====================================================*/

// Console.Write("Введите значение: "); double inputValue = Convert.ToDouble(Console.ReadLine());
// double Kelvin = 0;
// double Celsii = -273.15;
// double farenheit = -459.67;


// Console.WriteLine($"{(inputValue / 1.8) - 16 }");






/*=========================================================*/

// Console.Write("Введите сантиметров: "); int inputValue = Convert.ToInt32(Console.ReadLine());
// int Metr = 100;
// int result = 0;

// result = inputValue / Metr;

// Console.WriteLine(result);



// Console.Write("Введите киллограмы: "); int inputValue = Convert.ToInt32(Console.ReadLine());
// int Hundredweight = 100;
// int result = 0;

// result = inputValue / Hundredweight;

// Console.WriteLine(result);

/*====3.3 С  некоторого момента прошло 234 дня. Сколько полных недель прошло за этот период?=====================================================*/

// Console.Write("Введите дни: "); int inputValue = Convert.ToInt32(Console.ReadLine());
// int week = 7;
// int result = 0;

// result = inputValue / week;

// Console.WriteLine(result);



/*===3.4.	 Написать программу, которая решает следующую задачу: «N школьников делят k яблок поровну так, чтобы каждому
достались только целые яблоки, остальные яблоки остаются в  корзинке. Определить, сколько яблок достанется каждому школьнику
и  сколько яблок останется в корзинке».======================================================*/

// Console.Write("Введите количество человек: "); int numberOfChildren = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество яблок: "); int theNumberOfApplesEntered = Convert.ToInt32(Console.ReadLine());
// int result = 0;

// result = theNumberOfApplesEntered / numberOfChildren;
// Console.WriteLine(result);
// Console.WriteLine(theNumberOfApplesEntered % numberOfChildren);



/*==3.5.	 Дан прямоугольник с  размерами 543×130 мм. Сколько квадратов со стороной 130 мм можно отрезать от него?=======================================================*/
// int instantPerimetr = 543 * 130;
// int Square = 130 * 130;
// int result = 0;

// result = instantPerimetr / Square;
// Console.WriteLine(result);


/*====3.6.	 В  купейном вагоне имеется 9 купе с  четырьмя местами для пассажиров в каждом. Определить номер купе, в котором
 находится место с  заданным номером (нумерация мест сквозная, начинается с 1).=====================================================*/


// Console.Write("Введите место: "); int seats = Convert.ToInt32(Console.ReadLine());

// int coupe = 4;
// int van = coupe * 9;

// Console.WriteLine(seats / coupe + seats % coupe);


/*=====3.7.	 В  подъезде № 1 пятиэтажного жилого дома 15 квартир. Определить, на каком этаже этого подъезда находится квартира
с  заданным номером.====================================================*/

// Console.Write("Введите номер квартиры: "); int inputAppartment = Convert.ToInt32(Console.ReadLine());

// int floor = 5;
// int appartmentInFloor = 15 / floor;

// Console.WriteLine($"Квартира {inputAppartment} находится на {inputAppartment / appartmentInFloor + inputAppartment % appartmentInFloor} этаже");

/*===3.8.	 В кинотеатре имеется 20 рядов мест для зрителей, в каждом из которых расположено 15 кресел. Билет для зрителей имеет серию АВ и  номер билета, для первого места в  первом ряду 
равного 01643 (далее этот номер увеличивается согласно условному обозначению мест, имеющему вид, показанный в таблице 
ниже)======================================================*/


// while(0 == 0)
// {
//     Console.Write("Введите номер кресла: "); int inputSeats = Convert.ToInt32(Console.ReadLine());

//     int saets = inputSeats - 1643;

//     int numbersOfline = 20;
//     int numbersOfSaetsInLine = 15;
//     int AllSeats = numbersOfline * 15;
//     if (AllSeats < saets)
//     {

//         Console.WriteLine("Такого места в этом зале нет");
//         return;
//     }
//     else
//     {
//         Console.WriteLine($"Место 0{inputSeats} находится на {saets / numbersOfSaetsInLine + 1} ряду");
//     }
// }





/*======3.9.	 С  начала суток прошло n секунд. Определить:
а)  сколько полных часов прошло с  начала суток;
б)  сколько полных минут прошло с начала очередного часа;
в)  сколько полных секунд прошло с начала очередной минуты.===================================================*/


// Console.Write("Введите количество секунд: "); int inputSecondes = Convert.ToInt32(Console.ReadLine());

// int day = 60 * 60 * 24;
// int hour = 60 * 60;
// int minut = 60;

// Console.WriteLine("{0:0.#}", inputSecondes / day  + " дней");
// Console.WriteLine("{0:0.#}", (inputSecondes % day) / hour + " часов");
// Console.WriteLine("{0:0.#}", (inputSecondes % day % hour / minut + " минут") );
// Console.WriteLine("{0:0.#}", (inputSecondes % day % hour % minut + " секунд") );


/*==3.10.	 Дано целое число k (1 ≤ k ≤ 365). Присвоить целочисленной величине n значение 1, 2, ..., 6 или 0 в 
 зависимости на какой день недели (понедельник, вторник, ..., субботу или 
воскресенье) приходится k-й день года, в котором 1  января======================================================*/


// Console.Write("Введите день:\n");
// int inputday = 1;

// if (inputday % 7 == 1)
//     Console.WriteLine("Понедельник");
// else if (inputday % 7 == 2)
//     Console.WriteLine("Вторник");
// else if (inputday % 7 == 3)
//     Console.WriteLine("Среда");
// else if (inputday % 7 == 4)
//     Console.WriteLine("Четверг");
// else if (inputday % 7 == 5)
//     Console.WriteLine("Пятница");
// else if (inputday % 7 == 6)
//     Console.WriteLine("Суббота");
// else
//     Console.WriteLine("Воскресенье");


/*===В  подъезде № 1 пятиэтажного жилого дома 20 квартир.
Определить:
1)  на каком этаже этого подъезда находится квартира с заданным номером;
2)  какой по счету является эта квартира, если квартира с  минимальным номером является первой на этаже.======================================================*/


// Console.Write("Введите номер квартиры: "); int inputAppartment = Convert.ToInt32(Console.ReadLine());

// int floor = 5;
// int appartmentInFloor = 20 / floor;

// Console.WriteLine($"Квартира {inputAppartment} находится на {(inputAppartment + appartmentInFloor - 1) / appartmentInFloor}"
//                 + $" этаже  {(inputAppartment % appartmentInFloor)} по счету");




/*==3.13.==Дана таблица из 10 строк и  5 столбцов. Определить:
1)  в какой строке находится значение с порядковым номером n, если нумерацию вести построчно сверху вниз, а в каждой
строке – слева направо; 2) в  какой строке находится это значение.=====================================================*/

// Console.Write("Введите значение: "); int inputNumber = Convert.ToInt32(Console.ReadLine());
// int Line = 10;
// if(inputNumber <= 50)Console.WriteLine($"значение с порядковым номером находится в {inputNumber / Line +1} строке");
// else
// Console.WriteLine($"{inputNumber} за пределами таблицы");
// return 0;


/*===В жилом 9-этажном доме имеется 4 подъезда, на каждом этаже – 6 квартир. Определить:
1) в каком подъезде находится квартира с заданным номером;
2) на каком этаже этого подъезда она находится;
3)  какой по счету на этаже является эта квартира, если квартира с минимальным номером являет ======================================================*/

// Console.Write("Введите номер квартиры: "); int inputAppartment = Convert.ToInt32(Console.ReadLine());

// int floor = 9;
// int appartmentInFloor = 6;

// Console.Write($"Квартира {inputAppartment} находится на {(inputAppartment - (inputAppartment / inputAppartment)) % (floor)  + 1 } этаже\n"
//                 + $"она {((inputAppartment + appartmentInFloor - 1) % appartmentInFloor) + 1} по счету на этаже\n"
//                 + $"в {(inputAppartment - 1) / (appartmentInFloor * floor) +1} подъезде" );


/*==3.15.	 На складе товары находятся в 10-ярусном стеллаже, разбитом на 8 секций. В каждой секции
на каждом ярусе предусмотрено 15 мест для товаров. Нумерация мест показана на рис. 3.1. направление раскладки -> ↑
Склад обслуживается роботом. Определить, в  какой секции и  на
каком ярусе робот должен взять товар, находящийся на месте
с  заданным номером=======================================================*/

// Console.WriteLine("Введите номер заказа: "); int inputNumber = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество мест в секции: "); int column = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество секции: "); int section = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество ярусов: "); int levels = Convert.ToInt32(Console.ReadLine());

// for (int inputNumber = 0; inputNumber < column*section*levels + 1; inputNumber++)
// {
//     Console.WriteLine($"Посылка {inputNumber} находится на {(inputNumber - 1) / (column * section) + 1} ярусе "
//                     + $"Секции {((inputNumber - ((column * section) * (((inputNumber - 1) / (column * section) + 1) - 1))) - 1) / column + 1}");
// }



/*====3.16.	 Дано двузначное число. Найти:
а)  число десятков в  нем;
б)  число единиц в  нем.=====================================================*/

// Console.WriteLine("Введите число"); int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"В вашем числе {number} десятков {number / 10} единиц {number % 10}");


/*====3.17.	 Написать программу, в  которой рассчитывается сумма цифр двузначного числа, вводимого с  клавиатуры.=====================================================*/

//Console.WriteLine("Введите число"); int number = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"В вашем числе {number} десятков {number / 10} единиц {number % 10}");


/*=3.17== Написать программу в которой рассчитывается сумма цифр двухзначного числа, вводимого с клавиатуры  ======================================================*/

//Console.WriteLine("Введите число"); int number = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"В вашем числе {number} сумма десятков и единиц равна {(number / 10) +(number % 10)}");





/*====Получить число образованное пр перестановки заданного числа=====================================================*/
//Console.WriteLine("Введите число"); int number = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"Новое число будет равно {((number % 10) * 10) + number/10}");

/*===Все цифры через запятую ======================================================*/
//Console.WriteLine("Введите число"); int number = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"Вот эти числа {number / 100},{number / 10 % 10},{number % 10}");

/*===Все цифры через запятую ======================================================*/
//Console.WriteLine("Введите число"); int number = Convert.ToInt32(Console.ReadLine()); Console.WriteLine($"Число единиц в нем {number % 10}");
//Console.WriteLine($"Число десятков в нем { number / 10 % 10 }");
//Console.WriteLine($"Сумма его цифр равна {(number / 100) + (number / 10 % 10) + number % 10}");
//Console.WriteLine($"Произведение чисел равно {(number / 100) * (number / 10 % 10)* ( number % 10)}");



/*===3.12 Дано 3х значное число Найти число полученное при чтении <-  ======================================================*/
//Console.WriteLine("Введите число"); int number = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"Произведение чисел равно {((number / 100) + ((number / 10 % 10) * 10) + ((number % 10) * 100))}");


//*===Из 3х значного числа получить 6 разных чисел======================================================*/

/*
Console.WriteLine("Введите число"); int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Первое число равно {((number / 100)* 10) + (((number / 10) % 10) * 100) + (number % 10)}");
Console.WriteLine($"Второе число равно {((number / 100)* 1) + (((number / 10) % 10) * 10) + ((number % 10) * 100)}");
Console.WriteLine($"Третье число равно {((number / 100)* 100) + (((number / 10) % 10) * 1) + ((number % 10) * 10)}");
Console.WriteLine($"Четвертое число равно {((number / 100)* 1) + (((number / 10) % 10) * 100) + ((number % 10) * 10)}");
Console.WriteLine($"Пятое число равно {((number / 100) * 10) + (((number / 10) % 10) * 1) + ((number % 10) * 100)}");
*/


/*=========================================================*/
//Console.WriteLine("Введите число"); int number = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"Первое число равно  {(number / 1000) }, {((number % 1000) / 100)}, {((number % 100) / 10)}, {number % 10}");


//Console.WriteLine("Введите число"); int number = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"Первое число равно  {(number / 10000) }, {((number % 10000) / 1000)}, {((number % 1000) / 100)}, {(number % 100) / 10}, {number % 10}");


/*
for(int number = 1; number < 151; number++){
	if(number % 3 == 0  && (number / 100)  == 1 &&  ((number / 10) % 10) == 4 && number % 10 == 7) 
		Console.WriteLine(number);
}

*/


/*====Определить угол (в градусах) между положением часовой стрелки в начале суток и в указанный момент времени =====================================================*/

/*
Console.WriteLine("Введите время: часы минуты секунды ");
string? enter = Console.ReadLine();
string[] table = enter.Split(" ");
int hours = Convert.ToInt32(table[0]);
int minutes = Convert.ToInt32(table[1]);
int seconds = Convert.ToInt32(table[2]);
double result = hours * 30 + minutes * 0.5 + seconds * 0.00833333;

if (result <= 360)
{
    Console.WriteLine($"угол равен = " + "{0:0.#}", result);
}
else {
    Console.WriteLine($"угол равен = " + "{0:0.#}", result - 360);
}

*/




/*====3.48 С начала суток часовая стрелка повернулась на у градусов от 0 до 360 Определить количество полных часов и минут прошедших с началва суток=====================================================*/

/*
Console.WriteLine("Введите значение "); double result = Convert.ToDouble(Console.ReadLine());


Console.WriteLine($"Время равно  = {result/ 30} часов {result % 30 * 2.12} минут");
*/



// Console.WriteLine($"Кельвин =  " + "{0:0.#}", Math.Abs(Celsii - inputValue));



/*====Часовая стрелка образует с лучом, проходящим чрез центр и через точкку, соответствующую 12 часам на циферблате от 0 до 2Пи
Определить какое значение угла для минутной стрелки а так же полное количество часов и минут=====================================================*/


Console.WriteLine("Введите значение от 0 до 2Пи"); double result = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"угол минутной стрелки равен  = {result * 57.32} градусов");
Console.Write("часов " + "{0:#.#}", (result * 57.32/ 30)); 
Console.Write("минут " + "{0:#.#}", (result * 57.32 % 30 * 2.12)); 





/*=========================================================*/
/*=========================================================*/
/*=========================================================*/

/*=========================================================*/
/*=========================================================*/
/*=========================================================*/
/*=========================================================*/
/*=========================================================*/
/*=========================================================*/
/*=========================================================*/
/*=========================================================*/
/*=========================================================*/
/*=========================================================*/
/*=========================================================*/
/*=========================================================*/
/*=========================================================*/
