using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gadolinium143 : RadioactiveSubstance
    {
        public override string name { get; } = "Gadolinium143";
        public override double halfLife { get; } = 39.0d;
        public override double atomicWeight { get; } = 142.92675d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Samarium143() }, { 1.0d, new BetaParticle(1, 5643550.0) }, { 0.193991d, new GammaParticle(204770.0, 0.00605) }, { 0.7490000000000001d, new GammaParticle(258810.0, 0.00479) }, { 0.098868d, new GammaParticle(463700.0, 0.00267) }, { 0.00749d, new GammaParticle(554100.0, 0.00224) }, { 0.053928000000000004d, new GammaParticle(812900.0, 0.00153) }, { 0.010486d, new GammaParticle(1284200.0, 0.00097) }, { 0.008988000000000001d, new GammaParticle(1464800.0, 0.00085) }, { 1.662d, new GammaParticle(511000.0, 0.00243) }, { 0.043772932734719994d, new GammaParticle(6603.0, 0.18777) }, { 0.06848568583656572d, new GammaParticle(40901.0, 0.03031) }, { 0.12357575935865342d, new GammaParticle(41541.0, 0.02985) }, { 0.03893137402605793d, new GammaParticle(47146.0, 0.0263) }, { 0.048975668524780885d, new GammaParticle(47645.0, 0.02602) }, { 0.010044294498722947d, new GammaParticle(48248.0, 0.0257) } } },

        };
    }
}
    