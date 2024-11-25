using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Selenium84 : RadioactiveSubstance
    {
        public override string name { get; } = "Selenium84";
        public override double halfLife { get; } = 195.6d;
        public override double atomicWeight { get; } = 83.91847d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Bromine84() }, { 1.0d, new BetaParticle(-1, 917650.0) }, { 1.0d, new GammaParticle(408200.0, 0.00304) }, { 0.024d, new GammaParticle(498500.0, 0.00249) } } },

        };
    }
}
    