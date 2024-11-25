using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium181 : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium181";
        public override double halfLife { get; } = 210.0d;
        public override double atomicWeight { get; } = 180.95191d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Hafnium181() }, { 1.0d, new BetaParticle(-1, 1301500.0) }, { 0.066d, new GammaParticle(45800.0, 0.02707) }, { 0.039599999999999996d, new GammaParticle(52900.0, 0.02344) }, { 0.0352d, new GammaParticle(98900.0, 0.01254) }, { 0.039599999999999996d, new GammaParticle(105700.0, 0.01173) }, { 0.033d, new GammaParticle(125200.0, 0.0099) }, { 0.0264d, new GammaParticle(153400.0, 0.00808) }, { 0.0154d, new GammaParticle(159100.0, 0.00779) }, { 0.1606d, new GammaParticle(205900.0, 0.00602) }, { 0.0462d, new GammaParticle(240400.0, 0.00516) }, { 0.0176d, new GammaParticle(252000.0, 0.00492) }, { 0.0506d, new GammaParticle(329000.0, 0.00377) }, { 0.0374d, new GammaParticle(334400.0, 0.00371) }, { 0.033d, new GammaParticle(341700.0, 0.00363) }, { 0.0462d, new GammaParticle(463500.0, 0.00267) }, { 0.154d, new GammaParticle(574800.0, 0.00216) }, { 0.033d, new GammaParticle(590000.0, 0.0021) }, { 0.22d, new GammaParticle(652400.0, 0.0019) }, { 0.0418d, new GammaParticle(700400.0, 0.00177) }, { 0.08800000000000001d, new GammaParticle(806000.0, 0.00154) }, { 0.077d, new GammaParticle(858500.0, 0.00144) }, { 0.22471010227379998d, new GammaParticle(9114.0, 0.13604) }, { 0.012022390815184575d, new GammaParticle(54608.0, 0.0227) }, { 0.021040235938369928d, new GammaParticle(55786.0, 0.02222) }, { 0.006941324953784923d, new GammaParticle(63333.0, 0.01958) }, { 0.008794658716445497d, new GammaParticle(64057.0, 0.01936) }, { 0.0018533337626605744d, new GammaParticle(64935.0, 0.01909) } } },

        };
    }
}
    