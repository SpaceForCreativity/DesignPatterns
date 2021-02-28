using StatePattern.States.Interfaces;

namespace StatePattern.States
{
    public class NormalState : IWaterState
    {
        public void Freeze(Water water)
        {
            water.State = new IceState();
        }

        public void WarmUp(Water water)
        {
            water.State = new GassState();
        }

        public override string ToString()
        {
            return "Normal";
        }
    }
}
