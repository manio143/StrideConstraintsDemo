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
    public class UpNDown : AsyncScript
    {
        public bool Enabled = true;
        public RigidbodyComponent Rigidbody { get; set; }
        public Vector3 Normal = Vector3.UnitY;
        public float Velocity;
        public float Time;
        
        private float t = 0;

        public override async Task Execute()
        {
            var v = Velocity;
            Rigidbody ??= Entity.Get<RigidbodyComponent>();
            while(Game.IsRunning && Enabled)
            {
                await Script.NextFrame();
                Rigidbody.LinearVelocity = Normal * v;
                t += (float)Game.UpdateTime.Elapsed.TotalSeconds;
                if (t > Time)
                {
                    v *= -1;
                    t = 0;
                }
            }
        }
    }
}
