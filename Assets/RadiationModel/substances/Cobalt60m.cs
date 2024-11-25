using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cobalt60m : RadioactiveSubstance
    {
        public override string name { get; } = "Cobalt60m";
        public override double halfLife { get; } = 628.02d;
        public override double atomicWeight { get; } = 59.93388d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9975d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cobalt60() }, { 0.0207d, new GammaParticle(58603.0, 0.02116) }, { 0.009340234092d, new GammaParticle(800.0, 1.5498) }, { 0.09410733783957236d, new GammaParticle(6915.0, 0.1793) }, { 0.18394710289204916d, new GammaParticle(6930.0, 0.17891) }, { 0.03814906926837847d, new GammaParticle(7677.0, 0.1615) }, { 0.03814906926837847d, new GammaParticle(7677.0, 0.1615) } } },
            { 0.0025d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Nickel60() }, { 1.0d, new BetaParticle(-1, 1440700.0) }, { 7.8e-05d, new GammaParticle(826100.0, 0.0015) }, { 0.0025d, new GammaParticle(1332492.0, 0.00093) }, { 7.5e-06d, new GammaParticle(2158570.0, 0.00057) } } },

        };
    }
}
    