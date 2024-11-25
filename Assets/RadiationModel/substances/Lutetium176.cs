using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium176 : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium176";
        public override double halfLife { get; } = 1.1865404166446592e+18d;
        public override double atomicWeight { get; } = 175.94269d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Hafnium176() }, { 1.0d, new BetaParticle(-1, 597050.0) }, { 0.14508d, new GammaParticle(88340.0, 0.01403) }, { 0.779688d, new GammaParticle(201830.0, 0.00614) }, { 0.9359999999999999d, new GammaParticle(306780.0, 0.00404) }, { 0.003744d, new GammaParticle(400990.0, 0.00309) }, { 0.23138373623788802d, new GammaParticle(9114.0, 0.13604) }, { 0.09619892089584643d, new GammaParticle(54608.0, 0.0227) }, { 0.16835652939420098d, new GammaParticle(55786.0, 0.02222) }, { 0.05554202823768952d, new GammaParticle(63333.0, 0.01958) }, { 0.0703717497771526d, new GammaParticle(64057.0, 0.01936) }, { 0.014829721539463101d, new GammaParticle(64935.0, 0.01909) } } },

        };
    }
}
    