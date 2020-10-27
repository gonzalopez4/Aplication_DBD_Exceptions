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
        public string Description { get; set; }

        /// Precondiciones: (UnitCost > 0)
        /// Postcondiciones: UnitCost tiene un valor de retorno
        public double UnitCost { get; set; }
    }
}