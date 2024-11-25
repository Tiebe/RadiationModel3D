using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium150m : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium150m";
        public override double halfLife { get; } = 4e-05d;
        public override double atomicWeight { get; } = 149.97343d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Ytterbium149() }, { 1.0d, new ProtonParticle() } } },

        };
    }
}
    