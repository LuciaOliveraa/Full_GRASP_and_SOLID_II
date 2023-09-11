using System;

namespace Full_GRASP_And_SOLID.Library
{
    public class ConsolePrinter
    {
        public void PrintRecipe(Recipe recipe)
        {
            Console.WriteLine($"Receta de {recipe.FinalProduct.Description}:");
            foreach (Step step in recipe.steps)
            {
                Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}");
            }
        }
    }
}

/* Para asignar la responsabilidad de imprimir la receta a una nueva clase se utilizó el criterio del 
principio de SRP, una clase solo puede tener una única responsabilidad para enfatizar el dinamismo y versatilidad del programa. */