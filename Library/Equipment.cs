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
        private string description;
        public string Description 
        {
            get
            {
                return this.description;
            }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new System.Exception("Error: El valor ingresado es nulo o vacío");
                }
                this.description = value;
            }
        }

        /// Precondiciones: (HourlyCost > 0)
        /// Postcondiciones: HourlyCost tiene un valor de retorno
        private double hourlyCost;
        public double HourlyCost 
        {
            get
            {
                return this.hourlyCost;
            }
            set 
            {
                if (value > 0)
                {
                   this.hourlyCost = value;
                }
                else
                {
                    throw new System.Exception("Error: El HourlyCost debe ser mayor que cero");
                }
            }
        }
    }
}