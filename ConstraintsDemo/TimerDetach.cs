using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stride.Core.Mathematics;
using Stride.Input;
using Stride.Engine;

namespace ConstraintsDemo
{
    public class TimerDetach : AsyncScript
    {
        public TimeSpan TimeToLive;

        public override async Task Execute()
        {
            await Task.Delay(TimeToLive);
            await Script.NextFrame();
            this.Entity.Scene = null;
        }
    }
}
