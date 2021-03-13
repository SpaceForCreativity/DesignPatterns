using StatePattern.Models;

namespace StatePattern.States.Interfaces
{
    public interface IWaterState
    {
        void Freeze(Water water);
        void WarmUp(Water water);
    }
}
