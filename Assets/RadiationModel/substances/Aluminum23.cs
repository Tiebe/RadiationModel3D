using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Aluminum23 : RadioactiveSubstance
    {
        public override string name { get; } = "Aluminum23";
        public override double halfLife { get; } = 0.446d;
        public override double atomicWeight { get; } = 23.00724d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Sodium23() }, { 1.0d, new BetaParticle(1, 8138976.75) }, { 1.754966d, new GammaParticle(511000.0, 0.00243) }, { 7.72096496424e-08d, new GammaParticle(46.0, 26.95309) }, { 2.4193974246733743e-06d, new GammaParticle(1254.0, 0.98871) }, { 1.2171988443531744e-06d, new GammaParticle(1254.0, 0.98871) } } },
            { 0.0104d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Sodium22() }, { 1.0d, new ProtonParticle() } } },

        };
    }
}
    