#region Task1
//100'e kadar olan sayıların negatif ve pozitif halini yazdırın

using System.Text;

//for (int i = 0; i <= 100; i++)
//{
//    Console.WriteLine($"positive = {i} and negative = {i*(-1)}");
//}
#endregion
#region Task2
//Kullanıcıdan aldığınız metinsel değeri tersten ekrana yazdırınız
//Console.WriteLine("Please enter word");
//string input=Console.ReadLine();
//StringBuilder reverseWord = new StringBuilder();
//for (int i =input.Length-1 ; i >=0; i--)
//{
//    reverseWord.Append(input[i]);
//}
//Console.WriteLine(reverseWord);
#endregion
#region Task3
//10 ile 20 arasındaki sayıları asal sayı olup olmadığını gönderdiğim tabloya göre ayrıştırınız

for (int i = 10; i <= 20; i++)
{
    for(int j = 2; j <= i/2; j++)
    {
        if(i%j==0)
        {
            Console.WriteLine($"{i} eşittir {j} * {i / j}");
            goto run;
        }
    }
    Console.WriteLine($"{i} asal sayidir");
run: continue;
}

#endregion
#region Task4

//Kullanıcı dışarıdan dilediği kadar sayı girecek, her sayı girdikten sonra, sayı girmeye devam edip etmeyeceği sorulacak. 
//int[] numbers = new int[0];
//int resize=1;
//string input;

//do
//{
//    Console.WriteLine("Please enter number");
//    int number=int.Parse(Console.ReadLine());
//    Array.Resize(ref numbers,resize );
//    resize++;
//    numbers[numbers.Length-1]=number;
//    Console.WriteLine("do you want to continue?y/Y");
//     input = Console.ReadLine();
//} while (input.ToLower()=="y");
//int maxOdd=0;
//int minOdd=numbers[0];

//for (int i = 0; i < numbers.Length; i++)
//{
//    if (numbers[i] % 2 != 0 && maxOdd < numbers[i])
//    {
//        maxOdd = numbers[i];

//    }
//    if (numbers[i] % 2 != 0 && minOdd > numbers[i])
//    {
//        minOdd = numbers[i];
//    }

//}
//if(maxOdd != 0&&minOdd!=0&&minOdd%2!=0)
//{
//    Console.WriteLine($"{maxOdd}-{minOdd}={maxOdd - minOdd}");
//}
//else
//{
//    Console.WriteLine("There are no 2 odd numbers for the transaction");
//}


#endregion


