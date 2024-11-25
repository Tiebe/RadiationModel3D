using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iron60 : RadioactiveSubstance
    {
        public override string name { get; } = "Iron60";
        public override double halfLife { get; } = 82679146053431.05d;
        public override double atomicWeight { get; } = 59.93407d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cobalt60() }, { 1.0d, new BetaParticle(-1, 118700.0) }, { 0.0207d, new GammaParticle(58603.0, 0.02116) }, { 0.009349159968d, new GammaParticle(800.0, 1.5498) }, { 0.09417922111913617d, new GammaParticle(6915.0, 0.1793) }, { 0.1840876096933858d, new GammaParticle(6930.0, 0.17891) }, { 0.038178209187478024d, new GammaParticle(7677.0, 0.1615) }, { 0.038178209187478024d, new GammaParticle(7677.0, 0.1615) } } },

        };
    }
}
    