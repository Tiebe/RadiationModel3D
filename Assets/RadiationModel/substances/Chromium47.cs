using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Chromium47 : RadioactiveSubstance
    {
        public override string name { get; } = "Chromium47";
        public override double halfLife { get; } = 0.5d;
        public override double atomicWeight { get; } = 46.9629d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Titanium47() }, { 1.0d, new BetaParticle(1, 5187305.0) }, { 0.037000000000000005d, new GammaParticle(87500.0, 0.01417) }, { 2.0d, new GammaParticle(511000.0, 0.00243) }, { 1.390100112316821e-05d, new GammaParticle(536.0, 2.31314) }, { 0.00016968237414572088d, new GammaParticle(4945.0, 0.25073) }, { 0.0003338232818133403d, new GammaParticle(4952.0, 0.25037) }, { 6.716765450493876e-05d, new GammaParticle(5444.0, 0.22774) }, { 6.716765450493876e-05d, new GammaParticle(5444.0, 0.22774) } } },

        };
    }
}
    