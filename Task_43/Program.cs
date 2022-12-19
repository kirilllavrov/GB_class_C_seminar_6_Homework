//                        0   1   2   3
Console.WriteLine("Введи B1, B2, K1, K2:");
string? BK = Console.ReadLine();
string[] str = BK.Split(new char[] { ' ', '.', ',' }, StringSplitOptions.RemoveEmptyEntries);

int[] number = str.Select(Int32.Parse).ToArray();

// for (int i = 0; i < number.Length; i++)
// {
//     Console.WriteLine(number[i]);
// }


// y = k1 * x + b1, y = k2 * x + b2

// x = (b2-b1)/(k1-k2)
// y = k1*x + b1

double x = 0;
double y = 0;
double z = 0;
double q = 0;

// x = (number[1] - number[0])/(number[2] - number[3]);     // Почему не работает
// y = number[2] * x + number[0];                           // это выражение???


x = (number[1] - number[0]);
z = (number[2] - number[3]);
q = x/z;
y = number[2] * q + number[0];

Console.WriteLine($"Координата точки пересечения: ({y};{q})");