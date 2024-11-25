using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Arsenic82 : RadioactiveSubstance
    {
        public override string name { get; } = "Arsenic82";
        public override double halfLife { get; } = 19.1d;
        public override double atomicWeight { get; } = 81.92474d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Selenium82() }, { 1.0d, new BetaParticle(-1, 3744450.0) }, { 0.54d, new GammaParticle(654400.0, 0.00189) }, { 0.09504d, new GammaParticle(754800.0, 0.00164) }, { 0.05886d, new GammaParticle(1075600.0, 0.00115) }, { 0.081d, new GammaParticle(1079300.0, 0.00115) }, { 0.1674d, new GammaParticle(1730000.0, 0.00072) }, { 0.056159999999999995d, new GammaParticle(1969400.0, 0.00063) }, { 0.03726d, new GammaParticle(2353300.0, 0.00053) }, { 0.06966d, new GammaParticle(2513300.0, 0.00049) }, { 0.08045999999999999d, new GammaParticle(2835000.0, 0.00044) }, { 0.045899999999999996d, new GammaParticle(3667400.0, 0.00034) } } },

        };
    }
}
    