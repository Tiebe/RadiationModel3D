using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cobalt66 : RadioactiveSubstance
    {
        public override string name { get; } = "Cobalt66";
        public override double halfLife { get; } = 0.2d;
        public override double atomicWeight { get; } = 65.93944d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Nickel66() }, { 1.0d, new BetaParticle(-1, 4798650.0) }, { 0.69d, new GammaParticle(1246100.0, 0.00099) }, { 1.0d, new GammaParticle(1425900.0, 0.00087) }, { 0.09d, new GammaParticle(1804700.0, 0.00069) } } },

        };
    }
}
    