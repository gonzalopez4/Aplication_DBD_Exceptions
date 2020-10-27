using System; 

namespace Full_GRASP_And_SOLID
{
    public class StepIsNotThereException : Exception
    {
        public StepIsNotThereException(string message) : base(message)
        {
            
        }
    }
}