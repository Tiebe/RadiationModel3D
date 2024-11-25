using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold198 : RadioactiveSubstance
    {
        public override string name { get; } = "Gold198";
        public override double halfLife { get; } = 232770.24d;
        public override double atomicWeight { get; } = 197.96824d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Mercury198() }, { 1.0d, new BetaParticle(-1, 686750.0) }, { 0.9562d, new GammaParticle(411802.05, 0.00301) }, { 0.008051204d, new GammaParticle(675883.6, 0.00183) }, { 0.0015892044d, new GammaParticle(1087684.2, 0.00114) }, { 0.011924050708503529d, new GammaParticle(11777.0, 0.10528) }, { 0.008074709248017368d, new GammaParticle(68894.0, 0.018) }, { 0.013688267923406288d, new GammaParticle(70820.0, 0.01751) }, { 0.004645461484387417d, new GammaParticle(80316.0, 0.01544) }, { 0.006006581699312931d, new GammaParticle(81285.0, 0.01525) }, { 0.0013611202149255133d, new GammaParticle(82477.0, 0.01503) } } },

        };
    }
}
    