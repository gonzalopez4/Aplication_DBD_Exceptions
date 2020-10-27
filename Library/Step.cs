//-------------------------------------------------------------------------------
// <copyright file="Step.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------------

namespace Full_GRASP_And_SOLID
{
    public class Step
    {
        /// Precondiciones: (input != null), (quantity > 0), (equipment != null), (time > 0)
        /// Postcondiciones: Se instancia Step
        public Step(Product input, double quantity, Equipment equipment, int time)
        {
            this.Quantity = quantity;
            this.Input = input;
            this.Time = time;
            this.Equipment = equipment;
        }

        /// Precondiciones: (Product != null)
        /// Postcondiciones: Product tiene un valor de retorno asignado
        /// Invarianza: El tiempo no es modificado
        public Product Input { get; set; }

        /// Precondiciones: (Quantity > 0)
        /// Postcondiciones: Quantity tiene un valor de retorno asignado
        /// Invarianza: El tiempo no es modificado
        public double Quantity { get; set; }

        /// Precondiciones: (Time > 0)
        /// Postcondiciones: Time tiene un valor de retorno asignado
        /// Invarianza: Input, Quantity, Equipment no son modificados
        public int Time { get; set; }

        /// Precondiciones: (Equipment != null)
        /// Postcondiciones: Equipment tiene un valor de retorno asignado
        /// Invarianza: El tiempo no es modificado
        public Equipment Equipment { get; set; }
    }
}