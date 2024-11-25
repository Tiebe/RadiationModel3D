using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zinc72 : RadioactiveSubstance
    {
        public override string name { get; } = "Zinc72";
        public override double halfLife { get; } = 167400.0d;
        public override double atomicWeight { get; } = 71.92684d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Gallium72() }, { 1.0d, new BetaParticle(-1, 221400.0) }, { 0.08278d, new GammaParticle(16400.0, 0.0756) }, { 0.008278d, new GammaParticle(41900.0, 0.02959) }, { 0.0057946d, new GammaParticle(46800.0, 0.02649) }, { 0.0173838d, new GammaParticle(79400.0, 0.01562) }, { 0.0215228d, new GammaParticle(88700.0, 0.01398) }, { 0.0231784d, new GammaParticle(102800.0, 0.01206) }, { 0.020695d, new GammaParticle(112100.0, 0.01106) }, { 0.8278d, new GammaParticle(144700.0, 0.00857) }, { 0.0935414d, new GammaParticle(191500.0, 0.00647) }, { 0.016d, new GammaParticle(1127.0, 1.10013) }, { 0.15d, new GammaParticle(9225.0, 0.1344) }, { 0.28d, new GammaParticle(9252.0, 0.13401) }, { 0.062d, new GammaParticle(10306.0, 0.1203) }, { 0.062d, new GammaParticle(10313.0, 0.12022) }, { 0.00037d, new GammaParticle(10365.0, 0.11962) } } },

        };
    }
}
    