//--------------------------------------------------------------------------------------
// <copyright file="Product.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//---------------------------------------------------------------------------------------

namespace Full_GRASP_And_SOLID
{
    public class Product
    {
        /// Precondiciones: (description != null), (unitCost > 0)
        /// Postcondiciones: Se instancia Product
        public Product(string description, double unitCost)
        {
            this.Description = description;
            this.UnitCost = unitCost;
        }

        /// Precondiciones: (Description != null), (unitCost > 0)
        /// Postcondiciones: Description tiene un valor de retorno
        private string description;
        public string Description 
        {
             get
             {
                return this.description;
             }
             set
             {
                 if(string.IsNullOrWhiteSpace(value))
                 {
                     throw new System.Exception("Error: La descripcion no puede ser vacía");
                 }
                 this.description = value;
             } 
        }

        /// Precondiciones: (UnitCost > 0)
        /// Postcondiciones: UnitCost tiene un valor de retorno
        private double unitCost;
        public double UnitCost 
        {
             get
             {
                return this.unitCost;
             }
             set
             {
                 if(value > 0)
                 {
                     this.unitCost = value;
                 }
                 else
                 {
                     throw new System.Exception("Error: El valor de unitCost debe ser mayor que cero");
                 }
             } 
             
        }
    }
}