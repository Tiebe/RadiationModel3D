using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nickel53 : RadioactiveSubstance
    {
        public override string name { get; } = "Nickel53";
        public override double halfLife { get; } = 0.0552d;
        public override double atomicWeight { get; } = 52.96819d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iron53() }, { 1.0d, new BetaParticle(1, 10658250.0) }, { 0.9d, new GammaParticle(511000.0, 0.00243) }, { 4.2524352e-06d, new GammaParticle(800.0, 1.5498) }, { 4.468888223485827e-05d, new GammaParticle(6915.0, 0.1793) }, { 8.735121625265494e-05d, new GammaParticle(6930.0, 0.17891) }, { 1.8115901512486812e-05d, new GammaParticle(7677.0, 0.1615) }, { 1.8115901512486812e-05d, new GammaParticle(7677.0, 0.1615) } } },
            { 0.23399999999999999d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iron52() }, { 1.0d, new ProtonParticle() }, { 0.028999999999999998d, new GammaParticle(849300.0, 0.00146) } } },

        };
    }
}
    