using System.Numerics;
using ValveResourceFormat.Serialization;

namespace GUI.Types.ParticleRenderer
{
    public class Particle
    {
        // Base properties
        public Vector3 ConstantColor { get; set; } = Vector3.One;
        public float ConstantLifetime { get; set; } = 1;
        public float ConstantRadius { get; set; } = 5;

        // Variable fields
        public float Alpha { get; set; } = 1;

        public Vector3 Color { get; set; }

        public float Lifetime { get; set; }

        public Vector3 Position { get; set; }

        public float Radius { get; set; }

        public Vector3 Velocity { get; set; }

        public Particle()
        {
            Init();
        }

        public Particle(IKeyValueCollection baseProperties)
        {
            if (baseProperties.ContainsKey("m_flConstantRadius"))
            {
                ConstantRadius = baseProperties.GetFloatProperty("m_flConstantRadius");
            }

            if (baseProperties.ContainsKey("m_flConstantLifespan"))
            {
                ConstantLifetime = baseProperties.GetFloatProperty("m_flConstantLifespan");
            }

            Init();
        }

        private void Init()
        {
            Color = ConstantColor;
            Lifetime = ConstantLifetime;
            Radius = ConstantRadius;
        }
    }
}
