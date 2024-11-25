using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Fluorine20 : RadioactiveSubstance
    {
        public override string name { get; } = "Fluorine20";
        public override double halfLife { get; } = 11.07d;
        public override double atomicWeight { get; } = 19.99998d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Neon20() }, { 1.0d, new BetaParticle(-1, 3512234.6) }, { 0.999995d, new GammaParticle(1633602.0, 0.00076) }, { 8.2e-05d, new GammaParticle(3332540.0, 0.00037) }, { 5e-07d, new GammaParticle(4965850.0, 0.00025) }, { 3.813197372690977e-08d, new GammaParticle(848.0, 1.46208) }, { 1.9172756389890232e-08d, new GammaParticle(848.0, 1.46208) } } },

        };
    }
}
    