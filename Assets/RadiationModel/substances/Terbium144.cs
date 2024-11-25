using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Terbium144 : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium144";
        public override double halfLife { get; } = 1.0d;
        public override double atomicWeight { get; } = 143.93305d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Europium144() }, { 1.0d, new BetaParticle(1, 6625500.0) }, { 0.21d, new GammaParticle(743000.0, 0.00167) }, { 0.0063d, new GammaParticle(1133400.0, 0.00109) }, { 0.039900000000000005d, new GammaParticle(1143900.0, 0.00108) }, { 0.0105d, new GammaParticle(1483500.0, 0.00084) }, { 0.0168d, new GammaParticle(1719100.0, 0.00072) }, { 0.0084d, new GammaParticle(1876400.0, 0.00066) }, { 0.0084d, new GammaParticle(2226500.0, 0.00056) } } },

        };
    }
}
    