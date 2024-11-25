using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Oxygen24 : RadioactiveSubstance
    {
        public override string name { get; } = "Oxygen24";
        public override double halfLife { get; } = 0.072d;
        public override double atomicWeight { get; } = 24.01986d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Fluorine24() }, { 1.0d, new BetaParticle(-1, 5480000.0) }, { 0.21d, new GammaParticle(521500.0, 0.00238) }, { 0.18d, new GammaParticle(1309500.0, 0.00095) }, { 0.39d, new GammaParticle(1831600.0, 0.00068) } } },
            { 0.42d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Fluorine24() }, { 1.0d, new BetaParticle(-1, 5480000.0) }, { 0.21d, new GammaParticle(521500.0, 0.00238) }, { 0.18d, new GammaParticle(1309500.0, 0.00095) }, { 0.39d, new GammaParticle(1831600.0, 0.00068) } } },

        };
    }
}
    