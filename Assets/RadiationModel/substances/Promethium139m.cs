using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Promethium139m : RadioactiveSubstance
    {
        public override string name { get; } = "Promethium139m";
        public override double halfLife { get; } = 0.18d;
        public override double atomicWeight { get; } = 138.917d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Promethium139() }, { 0.401d, new GammaParticle(188700.0, 0.00657) }, { 0.072038704d, new GammaParticle(6109.0, 0.20295) }, { 0.07013622871161632d, new GammaParticle(38171.0, 0.03248) }, { 0.12733520100148205d, new GammaParticle(38724.0, 0.03202) }, { 0.0394785762027857d, new GammaParticle(43934.0, 0.02822) }, { 0.04962457028690162d, new GammaParticle(44387.0, 0.02793) }, { 0.010145994084115926d, new GammaParticle(44938.0, 0.02759) } } },
            { 0.0005d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Praseodymium139() }, { 1.0d, new BetaParticle(1, 3758500.0) } } },

        };
    }
}
    