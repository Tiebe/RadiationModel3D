using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lawrencium259 : RadioactiveSubstance
    {
        public override string name { get; } = "Lawrencium259";
        public override double halfLife { get; } = 6.2d;
        public override double atomicWeight { get; } = 259.1029d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.78d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Mendelevium255() }, { 1.0d, new AlphaParticle(9605002.09) } } },
            { 0.22d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    