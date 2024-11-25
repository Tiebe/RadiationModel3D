using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium201m : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium201m";
        public override double halfLife { get; } = 0.00211d;
        public override double atomicWeight { get; } = 200.97181d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Thallium201() }, { 0.861d, new GammaParticle(331100.0, 0.00374) }, { 0.9462999999999999d, new GammaParticle(588300.0, 0.00211) }, { 0.0561988854994d, new GammaParticle(12148.0, 0.10206) }, { 0.03838613273169915d, new GammaParticle(70832.0, 0.0175) }, { 0.064797658223665d, new GammaParticle(72874.0, 0.01701) }, { 0.02203693916317338d, new GammaParticle(82629.0, 0.015) }, { 0.02858191009463587d, new GammaParticle(83631.0, 0.01483) }, { 0.006544970931462494d, new GammaParticle(84866.0, 0.01461) } } },

        };
    }
}
    