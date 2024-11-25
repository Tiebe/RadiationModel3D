using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nickel59 : RadioactiveSubstance
    {
        public override string name { get; } = "Nickel59";
        public override double halfLife { get; } = 2398326374068.992d;
        public override double atomicWeight { get; } = 58.93435d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iron59() }, { 1.0d, new BetaParticle(1, -245900.0) }, { 7.4e-07d, new GammaParticle(511000.0, 0.00243) }, { 0.0097493686301664d, new GammaParticle(800.0, 1.5498) }, { 0.10244647772474595d, new GammaParticle(6915.0, 0.1793) }, { 0.2002472199467278d, new GammaParticle(6930.0, 0.17891) }, { 0.0415295753205262d, new GammaParticle(7677.0, 0.1615) }, { 0.0415295753205262d, new GammaParticle(7677.0, 0.1615) } } },

        };
    }
}
    