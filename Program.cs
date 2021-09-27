using System;
using System.Collections.Generic;

namespace BackTest2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Manager");
            Console.WriteLine("Please enter the total of containers : ");
            int nContenedores = Convert.ToInt32(Console.ReadLine());
            List<int> contenedores = new List<int>();

            for(int i = 1; i < Convert.ToInt32(nContenedores) + 1; i++){
                Console.WriteLine("Container No " + i + " - Please enter the amount of units : ");
                String units = Console.ReadLine();
                contenedores.Add(Convert.ToInt32(units));

                Console.WriteLine("===============================================");
            }

            Console.WriteLine("Please enter your total desired units : ");
            String target = Console.ReadLine();

            Console.WriteLine("============== RESULTS =================");
            int result = restock(contenedores, Convert.ToInt32(target));
            if(result > 0){
                Console.WriteLine("The amount of units was completed, but it has an amount that needs to be resold, the amount is : " + result);
            } else {
                Console.WriteLine("The amount of units was not completed, the amount left to complete the target is : " + Math.Abs(result));
            }
            Console.WriteLine("Press enter to exit the application, thank you");
            String resultF = Console.ReadLine();
        }

        public static int restock(List<int> itemCount, int target){
            int result = 0;
            bool valid = true;
            for(int i = 0; i < itemCount.Count; i++){
                result += itemCount[i];
                if(result >= target){
                    result -= target;
                    valid = false;
                    break;
                }
            }
            if (valid) result -= target;
            return result;
        }
    }
}
