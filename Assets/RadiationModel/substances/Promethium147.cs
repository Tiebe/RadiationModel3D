using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Promethium147 : RadioactiveSubstance
    {
        public override string name { get; } = "Promethium147";
        public override double halfLife { get; } = 82786439.60174d;
        public override double atomicWeight { get; } = 146.91514d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Samarium147() }, { 1.0d, new BetaParticle(-1, 112000.0) }, { 1.17e-10d, new GammaParticle(76073.0, 0.0163) }, { 2.85e-05d, new GammaParticle(121220.0, 0.01023) }, { 3.4e-09d, new GammaParticle(197299.0, 0.00628) }, { 3.78538013061342e-06d, new GammaParticle(6354.0, 0.19513) }, { 6.100173958733124e-06d, new GammaParticle(39522.0, 0.03137) }, { 1.1041038839335973e-05d, new GammaParticle(40117.0, 0.03091) }, { 3.451406360692291e-06d, new GammaParticle(45523.0, 0.02724) }, { 4.341869201750903e-06d, new GammaParticle(45998.0, 0.02695) }, { 8.904628410586112e-07d, new GammaParticle(46575.0, 0.02662) } } },

        };
    }
}
    