using StatePattern.States.Interfaces;

namespace StatePattern.States
{
    public class IceState : IWaterState
    {
        public void Freeze(Water water)
        {
            //Do nothing
        }

        public void WarmUp(Water water)
        {
            water.State = new NormalState();
        }

        public override string ToString()
        {
            return "Ice";
        }
    }
}
