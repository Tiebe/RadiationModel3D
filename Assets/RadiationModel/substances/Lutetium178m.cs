using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium178m : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium178m";
        public override double halfLife { get; } = 1386.0d;
        public override double atomicWeight { get; } = 177.94609d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Hafnium178() }, { 1.0d, new BetaParticle(-1, 1110700.0) }, { 0.643644d, new GammaParticle(88850.0, 0.01395) }, { 0.17220300000000002d, new GammaParticle(93150.0, 0.01331) }, { 0.813965d, new GammaParticle(213410.0, 0.00581) }, { 0.024842399999999997d, new GammaParticle(216640.0, 0.00572) }, { 0.941d, new GammaParticle(325600.0, 0.00381) }, { 0.113861d, new GammaParticle(331620.0, 0.00374) }, { 0.970171d, new GammaParticle(426360.0, 0.00291) }, { 0.00022584d, new GammaParticle(454200.0, 0.00273) }, { 0.28999494486386423d, new GammaParticle(9114.0, 0.13604) }, { 0.1729443256121623d, new GammaParticle(54608.0, 0.0227) }, { 0.3026677032064443d, new GammaParticle(55786.0, 0.02222) }, { 0.09985224914423788d, new GammaParticle(63333.0, 0.01958) }, { 0.12651279966574935d, new GammaParticle(64057.0, 0.01936) }, { 0.02666055052151151d, new GammaParticle(64935.0, 0.01909) } } },

        };
    }
}
    