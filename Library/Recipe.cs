//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections;

namespace Full_GRASP_And_SOLID
{
    public class Recipe
    {
        private ArrayList steps = new ArrayList();

        public Product FinalProduct { get; set; }

        /// Precondicion: (Step != Null)
        /// Postcondicion: El Step está en la lista
        /// Invarianza: (Step != Null)
        public void AddStep(Step step)
        {
            this.steps.Add(step);
        }

        /// Precondicion: (Step != Null)
        /// Postcondicion: El Step no está la lista
        /// Invarianza: (Step != Null)
        public void RemoveStep(Step step)
        {
            this.steps.Remove(step);
        }

        /// Precondicion: (Steps != Null)
        /// Postcondicion: Se imprimen las recetas en la consola
        /// Invarianza: (Steps != Null)
        public void PrintRecipe()
        {
            Console.WriteLine($"Receta de {this.FinalProduct.Description}:");
            foreach (Step step in this.steps)
            {
                Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}");
            }
        }
    }
}