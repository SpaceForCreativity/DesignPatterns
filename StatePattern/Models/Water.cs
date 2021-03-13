using StatePattern.States;
using StatePattern.States.Interfaces;
using System;

namespace StatePattern.Models
{
    public class Water
    {
        public IWaterState State { get; set; }


        public event Action BeforeFreeze;
        public event Action AfterFreeze;
        public event Action BeforeWarmUp;
        public event Action AfterWarmUp;


        public Water()
        {
            State = new NormalState();
        }

        public void Freeze()
        {
            BeforeFreeze?.Invoke();
            State.Freeze(this);
            AfterFreeze?.Invoke();
        }

        public void WarmUp()
        {
            BeforeWarmUp?.Invoke();
            State.WarmUp(this);
            AfterWarmUp?.Invoke();
        }
    }
}
