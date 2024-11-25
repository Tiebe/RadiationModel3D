using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Erbium149 : RadioactiveSubstance
    {
        public override string name { get; } = "Erbium149";
        public override double halfLife { get; } = 4.0d;
        public override double atomicWeight { get; } = 148.94231d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Dysprosium149() }, { 1.0d, new BetaParticle(1, 6976000.0) }, { 0.14d, new GammaParticle(171500.0, 0.00723) }, { 0.04d, new GammaParticle(343900.0, 0.00361) }, { 0.04d, new GammaParticle(1233000.0, 0.00101) }, { 0.2d, new GammaParticle(1577900.0, 0.00079) }, { 0.72d, new GammaParticle(1748400.0, 0.00071) }, { 1.5489199999999999d, new GammaParticle(511000.0, 0.00243) }, { 0.03d, new GammaParticle(7656.0, 0.16194) }, { 0.039d, new GammaParticle(46700.0, 0.02655) }, { 0.07d, new GammaParticle(47547.0, 0.02608) }, { 0.022000000000000002d, new GammaParticle(53982.0, 0.02297) }, { 0.027999999999999997d, new GammaParticle(54577.0, 0.02272) }, { 0.006d, new GammaParticle(55293.0, 0.02242) } } },
            { 0.07d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Dysprosium148() }, { 1.0d, new ProtonParticle() } } },

        };
    }
}
    