using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cerium141 : RadioactiveSubstance
    {
        public override string name { get; } = "Cerium141";
        public override double halfLife { get; } = 2808345.6d;
        public override double atomicWeight { get; } = 140.90829d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Praseodymium141() }, { 1.0d, new BetaParticle(-1, 291700.0) }, { 0.483d, new GammaParticle(145443.3, 0.00852) }, { 0.024641247707999997d, new GammaParticle(5637.0, 0.21995) }, { 0.04798054690214311d, new GammaParticle(35551.0, 0.03488) }, { 0.08761969850647025d, new GammaParticle(36027.0, 0.03441) }, { 0.026655812572760063d, new GammaParticle(40857.0, 0.03035) }, { 0.033479700591386635d, new GammaParticle(41266.0, 0.03005) }, { 0.006823888018626576d, new GammaParticle(41766.0, 0.02969) } } },

        };
    }
}
    