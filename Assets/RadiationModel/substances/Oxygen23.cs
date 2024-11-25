using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Oxygen23 : RadioactiveSubstance
    {
        public override string name { get; } = "Oxygen23";
        public override double halfLife { get; } = 0.097d;
        public override double atomicWeight { get; } = 23.0157d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Fluorine23() }, { 1.0d, new BetaParticle(-1, 5665000.0) }, { 0.027000000000000003d, new GammaParticle(911000.0, 0.00136) }, { 0.031d, new GammaParticle(1237000.0, 0.001) }, { 0.057d, new GammaParticle(1621000.0, 0.00076) }, { 0.021d, new GammaParticle(1716000.0, 0.00072) }, { 0.515d, new GammaParticle(2243000.0, 0.00055) }, { 0.052000000000000005d, new GammaParticle(2673000.0, 0.00046) }, { 0.07200000000000001d, new GammaParticle(2926000.0, 0.00042) }, { 0.045d, new GammaParticle(3367000.0, 0.00037) }, { 0.10099999999999999d, new GammaParticle(3868000.0, 0.00032) }, { 0.171d, new GammaParticle(4066000.0, 0.0003) } } },
            { 0.07d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Fluorine23() }, { 1.0d, new BetaParticle(-1, 5665000.0) }, { 0.027000000000000003d, new GammaParticle(911000.0, 0.00136) }, { 0.031d, new GammaParticle(1237000.0, 0.001) }, { 0.057d, new GammaParticle(1621000.0, 0.00076) }, { 0.021d, new GammaParticle(1716000.0, 0.00072) }, { 0.515d, new GammaParticle(2243000.0, 0.00055) }, { 0.052000000000000005d, new GammaParticle(2673000.0, 0.00046) }, { 0.07200000000000001d, new GammaParticle(2926000.0, 0.00042) }, { 0.045d, new GammaParticle(3367000.0, 0.00037) }, { 0.10099999999999999d, new GammaParticle(3868000.0, 0.00032) }, { 0.171d, new GammaParticle(4066000.0, 0.0003) } } },

        };
    }
}
    