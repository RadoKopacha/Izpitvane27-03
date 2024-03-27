namespace Izpitvane27._03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Да се създаде масив, който съдържа 26 елемента
            //1) Напишете и извикайте метод за въвеждане на оценките на учениците от Вашата група / от 14 - 26 номер / -3т.
            //2) Изведете на конзолата празните / 0 / оценки - 3т.
            //3) Да се изведе на конзолата БРОЯ на 6 - ците в класа -2т. / с метод /
            //4) Напишете метод, който връща всички оценки / като List<int> /, които са по - големи от Вашата оценка - 4т.
            //5) Изведете на конзолата оценката на Вашия номер - 1т.
            //6) Да се изведе на конзолата ПОСЛЕДНИЯТ елемент на масива - 1т.
            //7) Да се отпечати средно-аритметичното на елементите, които са в средата на масива - 3т.
            //8) Да се постави оценка "Отличен" на Вашия номер - 1т.
            //9). Да се въведе името Ви и да се отпечати, като средната / средните букви БЪДАТ ЗАМЕНЕНИ с @ -2т.
            int[] grades= Grades();
            Grades(); //1
            NoGrade();//2
                  
            ExselentGrade(grades);
            Console.WriteLine($"Broq na 6 e{grades}");





        }
        static int [] Grades()
        {
            int[] grades2 = new int[26];
            Console.WriteLine("Enter grades for students ");
            for (int i = 13; i < 26; i++)
            {
                Console.Write($"Grade for student {i + 1}: ");
                grades2[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Grade of number 17 is: {grades2[16]}");
            

            return grades2;
        }
        static void NoGrade()
        {
            Console.WriteLine("");
        }
        static int  ExselentGrade(int[] grades)
        {
            
            int count = 0;
            for (int i = 0; i < count; i++)
            {
                if (grades[i] == 6)
                {
                    count++;
                    
                } 
            }
            return count;
        }
    }
}
