using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Europium144 : RadioactiveSubstance
    {
        public override string name { get; } = "Europium144";
        public override double halfLife { get; } = 10.2d;
        public override double atomicWeight { get; } = 143.91882d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Promethium144() }, { 1.0d, new BetaParticle(1, 2898550.0) }, { 0.0004512d, new GammaParticle(763000.0, 0.00162) }, { 0.015552d, new GammaParticle(817700.0, 0.00152) }, { 0.00038399999999999996d, new GammaParticle(1000600.0, 0.00124) }, { 0.096d, new GammaParticle(1660100.0, 0.00075) }, { 0.0096d, new GammaParticle(2423300.0, 0.00051) }, { 1.7409999999999999d, new GammaParticle(511000.0, 0.00243) }, { 0.0173606679574d, new GammaParticle(6354.0, 0.19513) }, { 0.028897865992427333d, new GammaParticle(39522.0, 0.03137) }, { 0.05230382985054721d, new GammaParticle(40117.0, 0.03091) }, { 0.016350071190004332d, new GammaParticle(45523.0, 0.02724) }, { 0.02056838955702545d, new GammaParticle(45998.0, 0.02695) }, { 0.004218318367021118d, new GammaParticle(46575.0, 0.02662) } } },

        };
    }
}
    