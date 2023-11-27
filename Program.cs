namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 
             * Bir tasodifiy (random) qiymat yarating. Va foydalanuvchidan ushbu qiymatni topmaguncha, 
             * qiymat kiritishini so'rashda davom eting. 
             * Agar kiritilgan son kichik bo'lsa "kichik", katta bo'lsa "katta", deb ekranga chiqaring. 
             */
            
            int counter = 0;
            int result = Random();

            while (true)
            {
                Console.Write("Son kiriting:");
                int n = int.Parse(Console.ReadLine());
                counter++;

                if (n > result)
                {
                    Console.WriteLine("Kichikroq son kiriting:");
                   
                }
                else if (n == result)
                {
                    Console.WriteLine($"Topildi uylangan son: {result} \n Urinishlar soni: {counter} ");
                    break;
                }
                else
                {
                    Console.WriteLine("KAttaroq son kiriting:");
                }


            }
           

        }
        static int Random()
        {
            Random rd = new Random();
            return rd.Next(1,100);
        }
    }
}