using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mercury206 : RadioactiveSubstance
    {
        public override string name { get; } = "Mercury206";
        public override double halfLife { get; } = 499.2d;
        public override double atomicWeight { get; } = 205.97751d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Thallium206() }, { 1.0d, new BetaParticle(-1, 653650.00001) }, { 3.5000000000000004e-05d, new GammaParticle(265832.0, 0.00466) }, { 0.26d, new GammaParticle(304896.0, 0.00407) }, { 0.0055000000000000005d, new GammaParticle(344520.0, 0.0036) }, { 3.5000000000000004e-05d, new GammaParticle(383590.0, 0.00323) }, { 0.022000000000000002d, new GammaParticle(649420.0, 0.00191) }, { 0.029504874547712d, new GammaParticle(12148.0, 0.10206) }, { 0.02299062733096421d, new GammaParticle(70832.0, 0.0175) }, { 0.03880929664241089d, new GammaParticle(72874.0, 0.01701) }, { 0.013198595944969084d, new GammaParticle(82629.0, 0.015) }, { 0.017118578940624903d, new GammaParticle(83631.0, 0.01483) }, { 0.003919982995655818d, new GammaParticle(84866.0, 0.01461) } } },

        };
    }
}
    