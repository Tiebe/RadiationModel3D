using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ruthenium108 : RadioactiveSubstance
    {
        public override string name { get; } = "Ruthenium108";
        public override double halfLife { get; } = 273.0d;
        public override double atomicWeight { get; } = 107.91019d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rhodium108() }, { 1.0d, new BetaParticle(-1, 685000.0) }, { 0.011479999999999999d, new GammaParticle(73650.0, 0.01683) }, { 0.023799999999999998d, new GammaParticle(91330.0, 0.01358) }, { 0.0784d, new GammaParticle(150460.0, 0.00824) }, { 0.28d, new GammaParticle(164950.0, 0.00752) } } },

        };
    }
}
    