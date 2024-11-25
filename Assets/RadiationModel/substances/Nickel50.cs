using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nickel50 : RadioactiveSubstance
    {
        public override string name { get; } = "Nickel50";
        public override double halfLife { get; } = 0.0185d;
        public override double atomicWeight { get; } = 49.99629d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iron50() }, { 1.0d, new BetaParticle(1, 15508000.0) }, { 0.28d, new GammaParticle(511000.0, 0.00243) }, { 1.44539136e-06d, new GammaParticle(800.0, 1.5498) }, { 1.5196529462809683e-05d, new GammaParticle(6915.0, 0.1793) }, { 2.9703927800644415e-05d, new GammaParticle(6930.0, 0.17891) }, { 6.160342736545902e-06d, new GammaParticle(7677.0, 0.1615) }, { 6.160342736545902e-06d, new GammaParticle(7677.0, 0.1615) } } },
            { 0.73d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iron49() }, { 1.0d, new ProtonParticle() } } },
            { 0.14d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Manganese48() }, { 1.0d, new ProtonParticle() } } },

        };
    }
}
    