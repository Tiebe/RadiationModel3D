using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium177 : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium177";
        public override double halfLife { get; } = 574067.52d;
        public override double atomicWeight { get; } = 176.94376d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Hafnium177() }, { 1.0d, new BetaParticle(-1, 248399.99999) }, { 0.00164d, new GammaParticle(71641.8, 0.01731) }, { 0.0623d, new GammaParticle(112949.8, 0.01098) }, { 0.00046499999999999997d, new GammaParticle(136724.5, 0.00907) }, { 0.1041d, new GammaParticle(208366.2, 0.00595) }, { 0.001997d, new GammaParticle(249674.2, 0.00497) }, { 0.002186d, new GammaParticle(321315.9, 0.00386) }, { 0.030365354846605998d, new GammaParticle(9114.0, 0.13604) }, { 0.015716035926459485d, new GammaParticle(54608.0, 0.0227) }, { 0.027504438093208763d, new GammaParticle(55786.0, 0.02222) }, { 0.009073911672637533d, new GammaParticle(63333.0, 0.01958) }, { 0.011496646089231755d, new GammaParticle(64057.0, 0.01936) }, { 0.0024227344165942215d, new GammaParticle(64935.0, 0.01909) } } },

        };
    }
}
    