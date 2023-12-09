namespace seminar_04

// Задача 1

// {
// 	public class Program
// 	{
// 		static void Main() {
// 			Console.Write("Введите число: ");
// 			string ? number = Console.ReadLine();
// 			if (number == "q") {
// 				Console.WriteLine("Exit");
// 				return;
// 			}
// 			int num = Convert.ToInt32(number);
// 			int total = 0;
// 			for(int i = 1; i <= num; i++){
// 				total += i;
// 			}
// 			if (total % 2 == 0)	{
// 				Console.WriteLine(total);
// 			} else {
// 				Console.WriteLine("Сумма цифр числа не четная");
// 				Main();
// 			}
// 		}
// 	}
// }

// Задача 2

// {
// 	public class Program
// 	{
// 		public static void Main(string [] arg) 
// 		{
// 			Random rand = new Random();
// 			int size = 10;			
// 			int [] array = new int[size];
// 			int total = 0;

// 			for (int i = 0; i < size; i++) 
// 			{
// 				array[i] = rand.Next(100,999);
// 				if (array[i] % 2 == 0) {
// 					total++;
// 				}
// 			}
// 			foreach (int el in array)
// 			{
// 				Console.Write(el + ",");
// 			}
// 			Console.WriteLine("Количество четных чисел => " + total);			
// 		}
// 	}
// }


// задача 3

// {
// 	public class Program
// 	{
// 		public static void Main(string [] arg) 
// 		{
// 			Random rand = new Random();
// 			int size = 10;			
// 			int [] array = new int[size];

// 			for (int i = 0; i < size; i++) 
// 			{
// 				array[i] = rand.Next(100,999);
// 			}
			
// 			Console.Write(string.Join(" ", array));
// 			Console.WriteLine("");
			
// 			int[] ReverseArray = Enumerable.Reverse(array).ToArray();
// 			Console.Write(string.Join(" ", ReverseArray));
// 		}
// 	}
// }

