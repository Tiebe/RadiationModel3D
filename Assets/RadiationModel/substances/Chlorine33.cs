using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Chlorine33 : RadioactiveSubstance
    {
        public override string name { get; } = "Chlorine33";
        public override double halfLife { get; } = 2.511d;
        public override double atomicWeight { get; } = 32.97745d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Phosphorus33() }, { 1.0d, new BetaParticle(1, 2667050.0) }, { 0.005235999999999999d, new GammaParticle(840400.0, 0.00148) }, { 6.159999999999999e-05d, new GammaParticle(1125000.0, 0.0011) }, { 0.0002552d, new GammaParticle(1472000.0, 0.00084) }, { 2.288e-05d, new GammaParticle(1519000.0, 0.00082) }, { 0.0045848d, new GammaParticle(1967300.0, 0.00063) }, { 6.776e-05d, new GammaParticle(2026000.0, 0.00061) }, { 0.00010164d, new GammaParticle(2312000.0, 0.00054) }, { 1.5839999999999997e-05d, new GammaParticle(2409000.0, 0.00051) }, { 0.0044d, new GammaParticle(2867700.0, 0.00043) }, { 1.32e-05d, new GammaParticle(3094000.0, 0.0004) }, { 5.72e-06d, new GammaParticle(3212000.0, 0.00039) }, { 3.959999999999999e-06d, new GammaParticle(3584000.0, 0.00035) }, { 5.28e-06d, new GammaParticle(3832000.0, 0.00032) }, { 2.992e-06d, new GammaParticle(3905000.0, 0.00032) }, { 4.180000000000001e-06d, new GammaParticle(3935000.0, 0.00032) }, { 4.84e-06d, new GammaParticle(4053000.0, 0.00031) }, { 2.5520000000000003e-06d, new GammaParticle(4144000.0, 0.0003) }, { 4.356e-06d, new GammaParticle(4375000.0, 0.00028) }, { 2.948e-06d, new GammaParticle(4424000.0, 0.00028) }, { 3.7399999999999998e-06d, new GammaParticle(4746000.0, 0.00026) }, { 1.9983033453999999d, new GammaParticle(511000.0, 0.00243) }, { 1.2999999999999998e-06d, new GammaParticle(185.0, 6.70185) }, { 1.9e-05d, new GammaParticle(2306.0, 0.53766) }, { 3.76e-05d, new GammaParticle(2308.0, 0.53719) }, { 3.5e-06d, new GammaParticle(2466.0, 0.50277) }, { 3.5e-06d, new GammaParticle(2466.0, 0.50277) } } },

        };
    }
}
    