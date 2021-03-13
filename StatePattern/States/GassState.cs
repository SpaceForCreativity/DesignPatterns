using StatePattern.Models;
using StatePattern.States.Interfaces;

namespace StatePattern.States
{
    public class GassState : IWaterState
    {
        public void Freeze(Water water)
        {
            water.State = new NormalState();
        }

        public void WarmUp(Water water)
        {
            //Do nothing
        }

        public override string ToString()
        {
            return "Gass";
        }
    }
}
