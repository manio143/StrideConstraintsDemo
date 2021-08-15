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
    public class SetPhysicsFactors : StartupScript
    {
        public Vector3 AngularFactor;
        public Vector3 LinearFactor;

        public override void Start()
        {
            var body = Entity.Get<RigidbodyComponent>();
            body.AngularFactor = AngularFactor;
            body.LinearFactor = LinearFactor;
        }
    }
}
