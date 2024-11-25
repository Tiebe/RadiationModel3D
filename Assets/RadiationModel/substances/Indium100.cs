using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium100 : RadioactiveSubstance
    {
        public override string name { get; } = "Indium100";
        public override double halfLife { get; } = 5.65d;
        public override double atomicWeight { get; } = 99.9311d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Silver100() }, { 1.0d, new BetaParticle(1, 6979950.0) }, { 0.00422862d, new GammaParticle(90700.0, 0.01367) }, { 0.59004d, new GammaParticle(296800.0, 0.00418) }, { 0.08752259999999999d, new GammaParticle(362700.0, 0.00342) }, { 0.0275352d, new GammaParticle(411700.0, 0.00301) }, { 0.0924396d, new GammaParticle(452800.0, 0.00274) }, { 0.0413028d, new GammaParticle(658200.0, 0.00188) }, { 0.8653919999999999d, new GammaParticle(794900.0, 0.00156) }, { 0.9834d, new GammaParticle(1004100.0, 0.00123) }, { 0.0796554d, new GammaParticle(1041900.0, 0.00119) }, { 0.028518599999999998d, new GammaParticle(1068500.0, 0.00116) }, { 0.059987399999999996d, new GammaParticle(1104100.0, 0.00112) }, { 0.024585d, new GammaParticle(1365300.0, 0.00091) }, { 1.8639d, new GammaParticle(511000.0, 0.00243) }, { 0.0097d, new GammaParticle(3388.0, 0.36595) }, { 0.034d, new GammaParticle(22983.0, 0.05395) }, { 0.064d, new GammaParticle(23173.0, 0.0535) }, { 0.0178d, new GammaParticle(26184.0, 0.04735) }, { 0.021099999999999997d, new GammaParticle(26381.0, 0.047) }, { 0.0032400000000000003d, new GammaParticle(26641.0, 0.04654) } } },
            { 0.0166d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Silver99() }, { 1.0d, new ProtonParticle() } } },

        };
    }
}
    