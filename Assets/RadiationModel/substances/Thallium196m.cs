using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium196m : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium196m";
        public override double halfLife { get; } = 5076.0d;
        public override double atomicWeight { get; } = 195.9709d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9620000000000001d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Gold196() }, { 1.0d, new BetaParticle(1, 2017849.99999) }, { 0.071d, new GammaParticle(84030.0, 0.01475) }, { 0.05d, new GammaParticle(222900.0, 0.00556) }, { 0.08d, new GammaParticle(301500.0, 0.00411) }, { 0.92d, new GammaParticle(426300.0, 0.00291) }, { 0.13d, new GammaParticle(505200.0, 0.00245) }, { 0.033d, new GammaParticle(588800.0, 0.00211) }, { 0.94d, new GammaParticle(635300.0, 0.00195) }, { 0.9d, new GammaParticle(695400.0, 0.00178) }, { 0.05d, new GammaParticle(723500.0, 0.00171) }, { 0.1332d, new GammaParticle(511000.0, 0.00243) }, { 0.472031002012d, new GammaParticle(11777.0, 0.10528) }, { 0.20439272557383684d, new GammaParticle(68894.0, 0.018) }, { 0.3464870750531223d, new GammaParticle(70820.0, 0.01751) }, { 0.11758919178116069d, new GammaParticle(80316.0, 0.01544) }, { 0.15204282497304075d, new GammaParticle(81285.0, 0.01525) }, { 0.03445363319188008d, new GammaParticle(82477.0, 0.01503) } } },
            { 0.038d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Thallium196() }, { 0.00015d, new GammaParticle(33700.0, 0.03679) }, { 1.65e-05d, new GammaParticle(120100.0, 0.01032) }, { 0.0036d, new GammaParticle(240700.0, 0.00515) }, { 0.021d, new GammaParticle(274600.0, 0.00452) }, { 0.0152077319072d, new GammaParticle(12148.0, 0.10206) }, { 0.0036335270717977736d, new GammaParticle(70832.0, 0.0175) }, { 0.00613357034402055d, new GammaParticle(72874.0, 0.01701) }, { 0.002085956811242618d, new GammaParticle(82629.0, 0.015) }, { 0.002705485984181676d, new GammaParticle(83631.0, 0.01483) }, { 0.0006195291729390577d, new GammaParticle(84866.0, 0.01461) } } },

        };
    }
}
    