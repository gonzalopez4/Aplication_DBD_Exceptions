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
        private Product input;
        public Product Input 
        { 
            get
            {
                return this.input;
            }
            set 
            {
                if (value == null)
                {
                    throw new NullValueException("El valor ingresado es vacío");
                }
                this.input = value;
            }
        }

        /// Precondiciones: (Quantity > 0)
        /// Postcondiciones: Quantity tiene un valor de retorno asignado
        /// Invarianza: El tiempo no es modificado
        private double quantity;
        public double Quantity 
        {
            get
            {
                return this.quantity;
            }
            set 
            {
                if (value > 0)
                {
                   this.quantity = value;
                }
                else
                {
                    throw new NegativeValueException("La cantidad debe ser mayor que cero");
                }
            }
        }

        /// Precondiciones: (Time > 0)
        /// Postcondiciones: Time tiene un valor de retorno asignado
        /// Invarianza: Input, Quantity, Equipment no son modificados
        private int time;
        public int Time 
        {
            get
            {
                return this.time;
            }
            set 
            {
                if (value > 0)
                {
                   this.time = value;
                }
                else
                {
                    throw new NegativeValueException("El tiempo debe ser mayor que cero");
                }
            }
        }

        /// Precondiciones: (Equipment != null)
        /// Postcondiciones: Equipment tiene un valor de retorno asignado
        /// Invarianza: El tiempo no es modificado
        private Equipment equipment;
        public Equipment Equipment 
        {
            get
            {
                return this.equipment;
            }
            set 
            {
                if (value == null)
                {
                   throw new NullValueException("El equipamiento no puede ser vacío");
                }
                else
                {
                    this.equipment = value;
                }
            }
        }
    }
}