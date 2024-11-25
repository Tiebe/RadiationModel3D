using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium123m : RadioactiveSubstance
    {
        public override string name { get; } = "Indium123m";
        public override double halfLife { get; } = 47.4d;
        public override double atomicWeight { get; } = 122.91079d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tin123() }, { 1.0d, new BetaParticle(-1, 2356350.0) }, { 0.45d, new GammaParticle(125760.0, 0.00986) }, { 0.0008774999999999999d, new GammaParticle(896500.0, 0.00138) }, { 0.0011250000000000001d, new GammaParticle(1170000.0, 0.00106) }, { 0.00020250000000000002d, new GammaParticle(2469000.0, 0.0005) }, { 0.00046125d, new GammaParticle(2598000.0, 0.00048) }, { 0.000585d, new GammaParticle(2695000.0, 0.00046) }, { 0.0006525d, new GammaParticle(3064000.0, 0.0004) }, { 0.00042750000000000004d, new GammaParticle(3103000.0, 0.0004) }, { 0.0010462499999999999d, new GammaParticle(3127000.0, 0.0004) }, { 0.0003825d, new GammaParticle(3155000.0, 0.00039) }, { 0.0013725d, new GammaParticle(3234000.0, 0.00038) }, { 0.0091099476d, new GammaParticle(3753.0, 0.33036) }, { 0.02848604752440638d, new GammaParticle(25044.0, 0.04951) }, { 0.053314706203268544d, new GammaParticle(25271.0, 0.04906) }, { 0.015075393711215612d, new GammaParticle(28579.0, 0.04338) }, { 0.018045246272325087d, new GammaParticle(28810.0, 0.04304) }, { 0.0029698525611094755d, new GammaParticle(29107.0, 0.0426) } } },

        };
    }
}
    