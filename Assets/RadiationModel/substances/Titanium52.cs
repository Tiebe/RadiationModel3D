using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Titanium52 : RadioactiveSubstance
    {
        public override string name { get; } = "Titanium52";
        public override double halfLife { get; } = 102.0d;
        public override double atomicWeight { get; } = 51.94688d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Vanadium52() }, { 1.0d, new BetaParticle(-1, 982665.0) }, { 0.24600000000000002d, new GammaParticle(17153.0, 0.07228) }, { 0.917d, new GammaParticle(124453.0, 0.00996) }, { 0.004218841575d, new GammaParticle(536.0, 2.31314) }, { 0.051494036509538696d, new GammaParticle(4945.0, 0.25073) }, { 0.10130638699496104d, new GammaParticle(4952.0, 0.25037) }, { 0.020383576495500266d, new GammaParticle(5444.0, 0.22774) }, { 0.020383576495500266d, new GammaParticle(5444.0, 0.22774) } } },

        };
    }
}
    