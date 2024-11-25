using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead190 : RadioactiveSubstance
    {
        public override string name { get; } = "Lead190";
        public override double halfLife { get; } = 71.0d;
        public override double atomicWeight { get; } = 189.97808d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.996d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Mercury190() }, { 1.0d, new BetaParticle(1, 5477000.0) }, { 0.11077999999999999d, new GammaParticle(511000.0, 0.00243) }, { 0.185d, new GammaParticle(12148.0, 0.10206) }, { 0.142d, new GammaParticle(70832.0, 0.0175) }, { 0.24d, new GammaParticle(72874.0, 0.01701) }, { 0.0816d, new GammaParticle(82629.0, 0.015) }, { 0.106d, new GammaParticle(83631.0, 0.01483) }, { 0.0242d, new GammaParticle(84866.0, 0.01461) } } },
            { 0.004d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Mercury186() }, { 1.0d, new AlphaParticle(6719002.09) } } },

        };
    }
}
    