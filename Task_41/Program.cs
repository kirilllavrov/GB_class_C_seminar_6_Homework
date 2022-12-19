Console.WriteLine("Введите числа:");
string? M = Console.ReadLine();

string[] str = M.Split(new char[] { ' ', '.', ',' }, StringSplitOptions.RemoveEmptyEntries);

int[] nums = str.Select(Int32.Parse).ToArray();

int result = 0;
for (int i = 0; i < nums.Length; i++)
{

    if (nums[i] > 0)
    {
        result++;
    }
}
Console.WriteLine(result);