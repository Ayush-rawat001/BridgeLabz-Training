using System;
using System.Collections.Generic;

namespace MealPlanGenerator
{
  
    // Interface
    
    interface IMealPlan
    {
        string MealName { get; }
        int Calories { get; }

        void ShowMeal();
    }

    
    // Vegetarian Meal

    class VegetarianMeal : IMealPlan
    {
        public string MealName => "Vegetarian Meal";
        public int Calories => 450;

        public void ShowMeal()
        {
            Console.WriteLine("Meal Type : Vegetarian");
            Console.WriteLine("Includes  : Paneer, Rice, Vegetables");
            Console.WriteLine("Calories  : " + Calories);
        }
    }

  
    // Vegan Meal

    class VeganMeal : IMealPlan
    {
        public string MealName => "Vegan Meal";
        public int Calories => 400;

        public void ShowMeal()
        {
            Console.WriteLine("Meal Type : Vegan");
            Console.WriteLine("Includes  : Tofu, Lentils, Salad");
            Console.WriteLine("Calories  : " + Calories);
        }
    }


    // Keto Meal
    
    class KetoMeal : IMealPlan
    {
        public string MealName => "Keto Meal";
        public int Calories => 550;

        public void ShowMeal()
        {
            Console.WriteLine("Meal Type : Keto");
            Console.WriteLine("Includes  : Eggs, Cheese, Avocado");
            Console.WriteLine("Calories  : " + Calories);
        }
    }

   
    // High Protein Meal
   
    class HighProteinMeal : IMealPlan
    {
        public string MealName => "High Protein Meal";
        public int Calories => 600;

        public void ShowMeal()
        {
            Console.WriteLine("Meal Type : High Protein");
            Console.WriteLine("Includes  : Chicken, Eggs, Beans");
            Console.WriteLine("Calories  : " + Calories);
        }
    }

  
    // Generic Meal Class with Constraint
 
    class Meal<T> where T : IMealPlan, new()
    {
        public void GenerateMeal()
        {
            T meal = new T();
            meal.ShowMeal();
        }
    }

  
    // Generic Method for Validation
 
    class MealValidator
    {
        public static void ValidateMeal<T>(T meal)
            where T : IMealPlan
        {
            Console.WriteLine("\nValidating Meal Plan...");

            if (meal.Calories <= 700)
                Console.WriteLine("Meal Approved ✅");
            else
                Console.WriteLine("Meal Not Approved ❌");
        }
    }

  
    // Main Program
 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==== Personalized Meal Plan Generator ====\n");

            // Vegetarian
            Meal<VegetarianMeal> vegMeal = new Meal<VegetarianMeal>();
            vegMeal.GenerateMeal();
            MealValidator.ValidateMeal(new VegetarianMeal());

            Console.WriteLine();

            // Vegan
            Meal<VeganMeal> veganMeal = new Meal<VeganMeal>();
            veganMeal.GenerateMeal();
            MealValidator.ValidateMeal(new VeganMeal());

            Console.WriteLine();

            // Keto
            Meal<KetoMeal> ketoMeal = new Meal<KetoMeal>();
            ketoMeal.GenerateMeal();
            MealValidator.ValidateMeal(new KetoMeal());

            Console.WriteLine();

            // High Protein
            Meal<HighProteinMeal> proteinMeal = new Meal<HighProteinMeal>();
            proteinMeal.GenerateMeal();
            MealValidator.ValidateMeal(new HighProteinMeal());

            Console.ReadLine();
        }
    }
}
