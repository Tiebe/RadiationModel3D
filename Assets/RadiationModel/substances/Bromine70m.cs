using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bromine70m : RadioactiveSubstance
    {
        public override string name { get; } = "Bromine70m";
        public override double halfLife { get; } = 2.2d;
        public override double atomicWeight { get; } = 69.94725d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Arsenic70() }, { 1.0d, new BetaParticle(1, 7600000.0) }, { 1.504d, new GammaParticle(511000.0, 0.00243) }, { 9.3003428e-05d, new GammaParticle(1426.0, 0.86945) }, { 0.0007119884741324518d, new GammaParticle(11183.0, 0.11087) }, { 0.001380357646631353d, new GammaParticle(11223.0, 0.11047) }, { 0.00032211274307535954d, new GammaParticle(12546.0, 0.09882) }, { 0.0003402154792361947d, new GammaParticle(12571.0, 0.09863) }, { 1.8102736160835203e-05d, new GammaParticle(12652.0, 0.098) } } },

        };
    }
}
    