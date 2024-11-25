using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nitrogen22 : RadioactiveSubstance
    {
        public override string name { get; } = "Nitrogen22";
        public override double halfLife { get; } = 0.023d;
        public override double atomicWeight { get; } = 22.0341d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Oxygen22() }, { 1.0d, new BetaParticle(-1, 11240000.0) }, { 0.07d, new GammaParticle(1386000.0, 0.00089) }, { 0.24d, new GammaParticle(3198000.0, 0.00039) }, { 0.02d, new GammaParticle(3312000.0, 0.00037) } } },
            { 0.34d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Oxygen22() }, { 1.0d, new BetaParticle(-1, 11240000.0) }, { 0.07d, new GammaParticle(1386000.0, 0.00089) }, { 0.24d, new GammaParticle(3198000.0, 0.00039) }, { 0.02d, new GammaParticle(3312000.0, 0.00037) } } },
            { 0.12d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Oxygen20() }, { 1.0d, new BetaParticle(-1, 945476003.472) }, { 1.0d, new NeutronParticle() } } },

        };
    }
}
    