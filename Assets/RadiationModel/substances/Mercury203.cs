using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mercury203 : RadioactiveSubstance
    {
        public override string name { get; } = "Mercury203";
        public override double halfLife { get; } = 4027104.0d;
        public override double atomicWeight { get; } = 202.97287d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Thallium203() }, { 1.0d, new BetaParticle(-1, 246050.00001) }, { 0.8156d, new GammaParticle(279195.2, 0.00444) }, { 0.0538174736592d, new GammaParticle(12148.0, 0.10206) }, { 0.03615202052238344d, new GammaParticle(70832.0, 0.0175) }, { 0.06102636820118744d, new GammaParticle(72874.0, 0.01701) }, { 0.020754366751294634d, new GammaParticle(82629.0, 0.015) }, { 0.026918413676429137d, new GammaParticle(83631.0, 0.01483) }, { 0.006164046925134507d, new GammaParticle(84866.0, 0.01461) } } },

        };
    }
}
    