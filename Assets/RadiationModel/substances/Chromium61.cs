using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Chromium61 : RadioactiveSubstance
    {
        public override string name { get; } = "Chromium61";
        public override double halfLife { get; } = 0.234d;
        public override double atomicWeight { get; } = 60.95438d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Manganese61() }, { 1.0d, new BetaParticle(-1, 4622800.0) }, { 0.09d, new GammaParticle(157200.0, 0.00789) }, { 0.16d, new GammaParticle(354800.0, 0.00349) }, { 0.05d, new GammaParticle(534600.0, 0.00232) }, { 0.21d, new GammaParticle(1142200.0, 0.00109) }, { 0.09d, new GammaParticle(1497300.0, 0.00083) }, { 0.2d, new GammaParticle(1860800.0, 0.00067) }, { 0.11d, new GammaParticle(2378200.0, 0.00052) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    