using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nickel55 : RadioactiveSubstance
    {
        public override string name { get; } = "Nickel55";
        public override double halfLife { get; } = 0.2037d;
        public override double atomicWeight { get; } = 54.95133d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iron55() }, { 1.0d, new BetaParticle(1, 6072700.0) }, { 1.9980000000000002d, new GammaParticle(511000.0, 0.00243) }, { 1.0047384e-05d, new GammaParticle(800.0, 1.5498) }, { 0.0001056597603227269d, new GammaParticle(6915.0, 0.1793) }, { 0.00020652806943457174d, new GammaParticle(6930.0, 0.17891) }, { 4.283217024270137e-05d, new GammaParticle(7677.0, 0.1615) }, { 4.283217024270137e-05d, new GammaParticle(7677.0, 0.1615) } } },

        };
    }
}
    