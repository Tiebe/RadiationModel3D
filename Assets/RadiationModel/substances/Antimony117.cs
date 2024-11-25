using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Antimony117 : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony117";
        public override double halfLife { get; } = 10080.0d;
        public override double atomicWeight { get; } = 116.90484d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Indium117() }, { 1.0d, new BetaParticle(1, 151500.0) } } },
            { 0.017d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tin117() }, { 1.0d, new BetaParticle(1, 878850.0) }, { 0.8590000000000001d, new GammaParticle(158562.0, 0.00782) }, { 0.00081605d, new GammaParticle(553000.0, 0.00224) }, { 0.0005154000000000001d, new GammaParticle(846000.0, 0.00147) }, { 0.0030924000000000004d, new GammaParticle(861350.0, 0.00144) }, { 0.0020616000000000002d, new GammaParticle(1004510.0, 0.00123) }, { 0.0010308000000000001d, new GammaParticle(1020600.0, 0.00121) }, { 0.0011167d, new GammaParticle(1021000.0, 0.00121) }, { 0.00028347d, new GammaParticle(1287600.0, 0.00096) }, { 9.449000000000001e-05d, new GammaParticle(1339500.0, 0.00093) }, { 0.0001718d, new GammaParticle(1420100.0, 0.00087) }, { 0.00055835d, new GammaParticle(1446400.0, 0.00086) }, { 0.00018898000000000002d, new GammaParticle(1578000.0, 0.00079) }, { 0.0362d, new GammaParticle(511000.0, 0.00243) }, { 0.075511829881368d, new GammaParticle(3753.0, 0.33036) }, { 0.2351790412941927d, new GammaParticle(25044.0, 0.04951) }, { 0.44016290715738854d, new GammaParticle(25271.0, 0.04906) }, { 0.12446151531196227d, new GammaParticle(28579.0, 0.04338) }, { 0.14898043382841883d, new GammaParticle(28810.0, 0.04304) }, { 0.02451891851645657d, new GammaParticle(29107.0, 0.0426) } } },

        };
    }
}
    