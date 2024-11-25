using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Magnesium29 : RadioactiveSubstance
    {
        public override string name { get; } = "Magnesium29";
        public override double halfLife { get; } = 1.3d;
        public override double atomicWeight { get; } = 28.98861d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Aluminum29() }, { 1.0d, new BetaParticle(-1, 3797700.0) }, { 0.15d, new GammaParticle(960400.0, 0.00129) }, { 0.047d, new GammaParticle(1307400.0, 0.00095) }, { 0.16399999999999998d, new GammaParticle(1398000.0, 0.00089) }, { 0.07d, new GammaParticle(1430200.0, 0.00087) }, { 0.036000000000000004d, new GammaParticle(1467500.0, 0.00084) }, { 0.099d, new GammaParticle(1754200.0, 0.00071) }, { 0.027999999999999997d, new GammaParticle(1786400.0, 0.00069) }, { 0.025d, new GammaParticle(2034900.0, 0.00061) }, { 0.36d, new GammaParticle(2224000.0, 0.00056) }, { 0.040999999999999995d, new GammaParticle(2865500.0, 0.00043) }, { 0.015d, new GammaParticle(3061600.0, 0.0004) }, { 0.011000000000000001d, new GammaParticle(3184400.0, 0.00039) } } },

        };
    }
}
    