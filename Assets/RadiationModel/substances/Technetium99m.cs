using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Technetium99m : RadioactiveSubstance
    {
        public override string name { get; } = "Technetium99m";
        public override double halfLife { get; } = 21625.92d;
        public override double atomicWeight { get; } = 98.9064d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.999963d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Technetium99() }, { 7.07e-11d, new GammaParticle(2172.6, 0.57067) }, { 0.89d, new GammaParticle(140511.0, 0.00882) }, { 0.000222d, new GammaParticle(142630.0, 0.00869) }, { 0.0044999264064d, new GammaParticle(2586.0, 0.47944) }, { 0.02117512717062367d, new GammaParticle(18250.0, 0.06794) }, { 0.04026455061917412d, new GammaParticle(18367.0, 0.0675) }, { 0.010701539732471687d, new GammaParticle(20695.0, 0.05991) }, { 0.012392383010202212d, new GammaParticle(20820.0, 0.05955) }, { 0.0016908432777305268d, new GammaParticle(21003.0, 0.05903) } } },
            { 3.7000000000000005e-05d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Ruthenium99() }, { 1.0d, new BetaParticle(-1, 220100.0) }, { 1.0399999999999999e-05d, new GammaParticle(89600.0, 0.01384) }, { 8.51e-08d, new GammaParticle(232800.0, 0.00533) }, { 9.694e-07d, new GammaParticle(322400.0, 0.00385) }, { 6.76607595453e-07d, new GammaParticle(2737.0, 0.45299) }, { 2.7804702017669503e-06d, new GammaParticle(19150.0, 0.06474) }, { 5.27603453845721e-06d, new GammaParticle(19279.0, 0.06431) }, { 1.4178616345747338e-06d, new GammaParticle(21736.0, 0.05704) }, { 1.6475552193758408e-06d, new GammaParticle(21875.0, 0.05668) }, { 2.2969358480110692e-07d, new GammaParticle(22072.0, 0.05617) } } },

        };
    }
}
    