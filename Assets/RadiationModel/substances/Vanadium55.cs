using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Vanadium55 : RadioactiveSubstance
    {
        public override string name { get; } = "Vanadium55";
        public override double halfLife { get; } = 6.54d;
        public override double atomicWeight { get; } = 54.94726d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Chromium55() }, { 1.0d, new BetaParticle(-1, 2992660.0) }, { 0.010164d, new GammaParticle(224080.0, 0.00553) }, { 0.007986d, new GammaParticle(242080.0, 0.00512) }, { 0.010164d, new GammaParticle(314810.0, 0.00394) }, { 0.01089d, new GammaParticle(334060.0, 0.00371) }, { 0.01452d, new GammaParticle(363050.0, 0.00342) }, { 0.726d, new GammaParticle(517860.0, 0.00239) }, { 0.045011999999999996d, new GammaParticle(565820.0, 0.00219) }, { 0.18077400000000002d, new GammaParticle(880610.0, 0.00141) }, { 0.046464d, new GammaParticle(921180.0, 0.00135) }, { 0.02178d, new GammaParticle(961390.0, 0.00129) }, { 0.03993d, new GammaParticle(1214650.0, 0.00102) } } },

        };
    }
}
    