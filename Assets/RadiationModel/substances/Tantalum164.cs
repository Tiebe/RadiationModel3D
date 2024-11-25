using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tantalum164 : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum164";
        public override double halfLife { get; } = 14.2d;
        public override double atomicWeight { get; } = 163.95353d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lutetium164() }, { 1.0d, new BetaParticle(1, 5679500.0) }, { 0.74d, new GammaParticle(210700.0, 0.00588) }, { 0.204d, new GammaParticle(376400.0, 0.00329) }, { 0.022000000000000002d, new GammaParticle(409500.0, 0.00303) }, { 0.017d, new GammaParticle(485000.0, 0.00256) }, { 0.024d, new GammaParticle(541500.0, 0.00229) }, { 0.141d, new GammaParticle(605200.0, 0.00205) }, { 0.040999999999999995d, new GammaParticle(642000.0, 0.00193) }, { 0.033d, new GammaParticle(650500.0, 0.00191) }, { 0.019d, new GammaParticle(765000.0, 0.00162) }, { 0.084d, new GammaParticle(816000.0, 0.00152) }, { 0.10300000000000001d, new GammaParticle(861800.0, 0.00144) }, { 0.07d, new GammaParticle(1142000.0, 0.00109) }, { 0.024d, new GammaParticle(1275500.0, 0.00097) }, { 0.026000000000000002d, new GammaParticle(1465000.0, 0.00085) }, { 1.7480000000000002d, new GammaParticle(511000.0, 0.00243) }, { 0.06546469358000001d, new GammaParticle(9114.0, 0.13604) }, { 0.05902130937456079d, new GammaParticle(54608.0, 0.0227) }, { 0.1032924560282828d, new GammaParticle(55786.0, 0.02222) }, { 0.034076923123248934d, new GammaParticle(63333.0, 0.01958) }, { 0.0431754615971564d, new GammaParticle(64057.0, 0.01936) }, { 0.009098538473907465d, new GammaParticle(64935.0, 0.01909) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    