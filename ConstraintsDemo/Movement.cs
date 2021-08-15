using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stride.Core.Mathematics;
using Stride.Input;
using Stride.Engine;
using Stride.Physics;

namespace ConstraintsDemo
{
    public class Movement : AsyncScript
    {
        public Vector3 Impulse { get; set; }
        public bool Once;

        public override async Task Execute()
        {
            var ypr = Matrix.RotationYawPitchRoll(MathUtil.PiOverTwo, 0, 0);
            var axi = Matrix.RotationAxis(new Vector3(0, 0, 1), 0);

            await Script.NextFrame();
            var body = this.Entity.Get<RigidbodyComponent>();
            
            do
            {
                body.ApplyImpulse(Impulse);
                await Task.Delay(TimeSpan.FromSeconds(5));
            } while (!Once);
        }
    }
}
