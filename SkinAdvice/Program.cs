using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkinAdvice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Skin Care Advisor Program!");
            Console.WriteLine("Hello, can you tell me your name :");
            String name = Console.ReadLine();
            Console.WriteLine("Hi "+name+ " can I advice for your skin ?");
            Console.WriteLine("Please, enter your skin type :");
            Console.WriteLine("Example : dry, oily, combination, sensitive, normal");
            string skinType = Console.ReadLine().ToLower();
            switch (skinType)
            {
                case "dry":
                    Console.WriteLine("Use a gentle, moisturizing cleanser.");
                    Console.WriteLine("Apply a rich moisturizer regularly.");
                    Console.WriteLine("Avoid harsh, drying products.");
                    break;
                case "oily":
                    Console.WriteLine("Use a gentle, oil-free cleanser.");
                    Console.WriteLine("Use products containing salicylic acid to control oil.");
                    Console.WriteLine("Avoid heavy, greasy moisturizers");
                    break;
                case "combination":
                    Console.WriteLine("Use a gentle cleanser suitable for all skin types.");
                    Console.WriteLine("Moisturize dry areas while controlling oil in oily areas.");
                    Console.WriteLine("Consider using different products for different areas of your face.");
                    break;
                case "sensitive":
                    Console.WriteLine("Use fragrance-free, hypoallergenic products.");
                    Console.WriteLine("Patch test new products before applying them to your face.");
                    Console.WriteLine("Avoid harsh exfoliants and irritating ingredients.");
                    break;
                case "normal":
                    Console.WriteLine("Use a gentle cleanser suitable for all skin types.");
                    Console.WriteLine("Moisturize regularly to maintain skin health.");
                    Console.WriteLine("Protect your skin from the sun with SPF.");
                    break;
                default:
                    Console.WriteLine("Sorry, I can't give advice for you.");
                    break;
            }
            Console.WriteLine();

            Console.WriteLine("How do you usually spend money on skincare a little, medium or high ?");
            string skinCareAmount = Console.ReadLine();
            switch (skinCareAmount)
            {
                case "little":
                    Console.WriteLine("You can choice Ponds, Parnier, Bella, Hearty Heart,JM Solution, Dr Face, Simple ");
                    break;
                case "medium":
                    Console.WriteLine("You can choice Loreal, Cathy Doll, Fit me, Olay");
                    break;
                case "high":
                    Console.WriteLine(" You can choice RMS Beauty, Beauty Blender, Skin Ceuticals");
                    break;
                default:
                    Console.WriteLine("Your choice is invalid!");
                    break;
            }
            Console.WriteLine();
            Console.WriteLine("Do you feel like your skin is damaged or experiencing any unusual symptoms (Yes/ No) ?");
            string damageSkin = Console.ReadLine().ToLower();
            switch (damageSkin)
            {
                case "yes":
                    Console.WriteLine("It's important to prioritize your skin's health. Consider consulting a dermatologist for professional advice.");
                    break;
                case "no":
                    Console.WriteLine("Great! Remember to maintain a consistent skincare routine and listen to your skin's needs.");
                    break;
                default:
                    Console.WriteLine("Your choice is invalid!");
                    break;
            }
            Console.WriteLine();
            Console.WriteLine("Thank you for using the Skin Care Advisor Program. Have a wonderful day "+name);
            Console.ReadKey();
        }  
    }
}
