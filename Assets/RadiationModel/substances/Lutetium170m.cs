using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium170m : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium170m";
        public override double halfLife { get; } = 0.67d;
        public override double atomicWeight { get; } = 169.93858d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lutetium170() }, { 0.00865d, new GammaParticle(44520.0, 0.02785) }, { 0.0044634d, new GammaParticle(48420.0, 0.02561) }, { 0.3745605008d, new GammaParticle(8810.0, 0.14073) } } },

        };
    }
}
    