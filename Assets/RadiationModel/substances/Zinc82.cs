using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zinc82 : RadioactiveSubstance
    {
        public override string name { get; } = "Zinc82";
        public override double halfLife { get; } = 0.166d;
        public override double atomicWeight { get; } = 81.95457d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Gallium82() }, { 1.0d, new BetaParticle(-1, 5308350.0) }, { 0.05d, new GammaParticle(34500.0, 0.03594) }, { 0.006999999999999999d, new GammaParticle(140700.0, 0.00881) }, { 0.0172d, new GammaParticle(163300.0, 0.00759) }, { 0.11d, new GammaParticle(366300.0, 0.00338) }, { 0.049d, new GammaParticle(530000.0, 0.00234) }, { 0.057d, new GammaParticle(2612900.0, 0.00047) }, { 0.12d, new GammaParticle(2943800.0, 0.00042) }, { 0.012d, new GammaParticle(2978700.0, 0.00042) }, { 0.00111465887052d, new GammaParticle(1127.0, 1.10013) }, { 0.009905699539247107d, new GammaParticle(9225.0, 0.1344) }, { 0.019249318964724264d, new GammaParticle(9252.0, 0.13401) }, { 0.004222550890684521d, new GammaParticle(10306.0, 0.1203) }, { 0.004247886196028628d, new GammaParticle(10313.0, 0.12022) }, { 2.5335305344107133e-05d, new GammaParticle(10365.0, 0.11962) } } },
            { 0.69d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Gallium82() }, { 1.0d, new BetaParticle(-1, 5308350.0) }, { 0.05d, new GammaParticle(34500.0, 0.03594) }, { 0.006999999999999999d, new GammaParticle(140700.0, 0.00881) }, { 0.0172d, new GammaParticle(163300.0, 0.00759) }, { 0.11d, new GammaParticle(366300.0, 0.00338) }, { 0.049d, new GammaParticle(530000.0, 0.00234) }, { 0.057d, new GammaParticle(2612900.0, 0.00047) }, { 0.12d, new GammaParticle(2943800.0, 0.00042) }, { 0.012d, new GammaParticle(2978700.0, 0.00042) }, { 0.00111465887052d, new GammaParticle(1127.0, 1.10013) }, { 0.009905699539247107d, new GammaParticle(9225.0, 0.1344) }, { 0.019249318964724264d, new GammaParticle(9252.0, 0.13401) }, { 0.004222550890684521d, new GammaParticle(10306.0, 0.1203) }, { 0.004247886196028628d, new GammaParticle(10313.0, 0.12022) }, { 2.5335305344107133e-05d, new GammaParticle(10365.0, 0.11962) } } },

        };
    }
}
    