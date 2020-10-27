//-------------------------------------------------------------------------------
// <copyright file="Equipment.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------------

namespace Full_GRASP_And_SOLID
{
    public class Equipment
    {
        /// Precondiciones: (description != null), (hourlyCost > 0)
        /// Postcondiciones: Se instancia Equipment
        public Equipment(string description, double hourlyCost)
        {
            this.Description = description;
            this.HourlyCost = hourlyCost;
        }

        /// Precondiciones: (Description != null)
        /// Postcondiciones: Description tiene un valor de retorno
        public string Description { get; set; }

        /// Precondiciones: (HourlyCost > 0)
        /// Postcondiciones: HourlyCost tiene un valor de retorno
        public double HourlyCost { get; set; }
    }
}