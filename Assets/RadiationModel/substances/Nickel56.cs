using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nickel56 : RadioactiveSubstance
    {
        public override string name { get; } = "Nickel56";
        public override double halfLife { get; } = 524880.0d;
        public override double atomicWeight { get; } = 55.94213d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iron56() }, { 1.0d, new BetaParticle(1, 3349780.0) }, { 0.988d, new GammaParticle(158380.0, 0.00783) }, { 0.365d, new GammaParticle(269500.0, 0.0046) }, { 0.365d, new GammaParticle(480440.0, 0.00258) }, { 0.495d, new GammaParticle(749950.0, 0.00165) }, { 0.86d, new GammaParticle(811850.0, 0.00153) }, { 0.14d, new GammaParticle(1561800.0, 0.00079) }, { 2.636e-05d, new GammaParticle(511000.0, 0.00243) }, { 0.009899999999999999d, new GammaParticle(800.0, 1.5498) }, { 0.1043d, new GammaParticle(6915.0, 0.1793) }, { 0.204d, new GammaParticle(6930.0, 0.17891) }, { 0.042300000000000004d, new GammaParticle(7677.0, 0.1615) }, { 0.042300000000000004d, new GammaParticle(7677.0, 0.1615) } } },

        };
    }
}
    