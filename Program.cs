using System;

namespace BMICalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continueCalculating = true;

            while (continueCalculating)
            {
                Console.WriteLine("Welcome to the BMI Calculator!");

                // Input berat badan
                Console.Write("Enter your weight (in kilograms): ");
                double weight = Convert.ToDouble(Console.ReadLine());

                // Input tinggi badan dalam sentimeter
                Console.Write("Enter your height (in centimeters): ");
                double heightInCm = Convert.ToDouble(Console.ReadLine());

                // Konversi tinggi badan dari sentimeter ke meter
                double heightInM = heightInCm / 100;

                // Hitung BMI
                double bmi = CalculateBMI(weight, heightInM);

                // Tampilkan hasil
                Console.WriteLine($"Your BMI is: {bmi:F2}");
                Console.WriteLine($"Category: {GetBMICategory(bmi)}");

                // Tanya pengguna jika mereka ingin menghitung lagi
                Console.Write("Do you want to calculate again? (yes/no): ");
                string userResponse = Console.ReadLine().Trim().ToLower();

                if (userResponse != "yes")
                {
                    continueCalculating = false;
                }
            }

            Console.WriteLine("Thank you for using the BMI Calculator!");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        static double CalculateBMI(double weight, double height)
        {
            return weight / (height * height);
        }

        static string GetBMICategory(double bmi)
        {
            if (bmi < 18.5)
                return "Underweight";
            else if (bmi >= 18.5 && bmi < 24.9)
                return "Normal weight";
            else if (bmi >= 25 && bmi < 29.9)
                return "Overweight";
            else
                return "Obesity";
        }
    }
}